using System;
using System.ComponentModel;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileImporter.BL;
using FileImporter.BL.FileWatcher;
using FileImporter.Common;

namespace FileImporter.UI
{
    public partial class FileViewer : Form
    {
        private const string PluginWarningMessage = "Plugin doesn't follow requiremnts";
        private const string SettingWarningMessage = "In order to change settings you should stop monitoring!";
        private const string FileNotSupportedWarningMessage = "File type '{0}' not supported! Please load plugin.\n";
        private const string ValidationMessage = "Please choose monitoring folder and checking period";
        private const string ConfigKey_MonitoringFolder = "MonitoringFolderPath";
        private const string ConfigKey_MonitoringPeriod = "MonitoringPeriodInSec";

        private FileLoadManager fileLoadManager;
        private readonly BindingList<ImportedDataItem> loadedData = new BindingList<ImportedDataItem>();
        private object locker = new object();

        public FileViewer()
        {
            InitializeComponent();
            InitFileManager();
            gridImportedData.DataSource = loadedData;
            ReadSettings();
            EnablingControls(isMonitoringStarted: false);
        }

        private void InitFileManager()
        {
            fileLoadManager = new FileLoadManager(new LoaderFactory());
            fileLoadManager.DataLoaded += FileLoadManager_DataLoaded;
            fileLoadManager.FileNotSupported += FileLoadManager_FileNotSupported;
        }

        private void FileLoadManager_FileNotSupported(object sender, FileTypeNotSupportedEventEventArgs args)
        {
            Invoke((MethodInvoker)delegate { lblValidation.Text += string.Format(FileNotSupportedWarningMessage, args.FileExtension); });
        }

        private void FileLoadManager_DataLoaded(object sender, DataLoadedEventArgs args)
        {
            lock (locker)
            {
                loadedData.RaiseListChangedEvents = false;

                foreach (var item in args.LoadedData)
                {
                    loadedData.Add(item);
                }

                loadedData.RaiseListChangedEvents = true;
                Invoke((MethodInvoker)delegate { loadedData.ResetBindings(); });
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateSetting(ConfigKey_MonitoringFolder, txtPath.Text);
            UpdateSetting(ConfigKey_MonitoringPeriod, numCheckingTime.Value.ToString());

            ConfigurationManager.AppSettings[ConfigKey_MonitoringFolder] = txtPath.Text;
            ConfigurationManager.AppSettings[ConfigKey_MonitoringPeriod] = numCheckingTime.Value.ToString();

            EnablingControls(isMonitoringStarted: false);
        }

        private static void UpdateSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void btnMonitoringStart_Click(object sender, EventArgs e)
        {
            if (!IsSettingsValid())
            {
                lblValidation.Text = ValidationMessage;
                return;
            }

            var folderPath = ConfigurationManager.AppSettings["MonitoringFolderPath"];
            var monitoringPeriodInSec = Convert.ToInt32(ConfigurationManager.AppSettings["MonitoringPeriodInSec"]);

            fileLoadManager.StartMonitoring(new FileWatcher(folderPath, TimeSpan.FromSeconds(monitoringPeriodInSec)));

            EnablingControls(isMonitoringStarted: true);
        }

        private void btnMonitoringStop_Click(object sender, EventArgs e)
        {
            fileLoadManager.StopMonitoring();
            EnablingControls(isMonitoringStarted: false);
        }

        private void EnablingControls(bool isMonitoringStarted)
        {
            btnMonitoringStart.Enabled = !isMonitoringStarted;
            btnMonitoringStop.Enabled = isMonitoringStarted;

            btnBrowse.Enabled = !isMonitoringStarted;
            numCheckingTime.Enabled = !isMonitoringStarted;
            btnSave.Enabled = !isMonitoringStarted;

            btnBrowsePlugin.Enabled = !isMonitoringStarted;
            btnUploadPlugin.Enabled = false;

            lblValidation.Text = string.Empty;
            lblPluginWarning.Text = string.Empty;
            lblSettingWarning.Text = isMonitoringStarted
                ? SettingWarningMessage
                : string.Empty;
        }

        private bool IsSettingsValid()
        {
            return
                !string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings[ConfigKey_MonitoringFolder]) &&
                !string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings[ConfigKey_MonitoringPeriod]);
        }

        private void ReadSettings()
        {
            txtPath.Text = ConfigurationManager.AppSettings[ConfigKey_MonitoringFolder];

            numCheckingTime.Value = !string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings[ConfigKey_MonitoringPeriod])
                ? Convert.ToInt32(ConfigurationManager.AppSettings[ConfigKey_MonitoringPeriod])
                : 0;
        }

        private void btnBrowsePlugin_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Dll files | *.dll";
                ofd.FileName = "Plugin.*.dll";
                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
                {
                    txtUploadingPlugin.Text = ofd.FileName;
                    btnUploadPlugin.Enabled = true;
                }
            }
        }

        private void btnUploadPlugin_Click(object sender, EventArgs e)
        {
            if (!fileLoadManager.TryAddPlugin(txtUploadingPlugin.Text))
            {
                Invoke((MethodInvoker) delegate { lblPluginWarning.Text = PluginWarningMessage; });
                return;
            }

            txtUploadingPlugin.Text = string.Empty;
            btnUploadPlugin.Enabled = false;
        }
    }
}
