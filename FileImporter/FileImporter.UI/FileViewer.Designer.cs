namespace FileImporter.UI
{
    partial class FileViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numCheckingTime = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridImportedData = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblValidation = new System.Windows.Forms.Label();
            this.btnMonitoringStart = new System.Windows.Forms.Button();
            this.btnMonitoringStop = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUploadPlugin = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowsePlugin = new System.Windows.Forms.Button();
            this.txtUploadingPlugin = new System.Windows.Forms.TextBox();
            this.lblSettingWarning = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPluginWarning = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckingTime)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridImportedData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(7, 26);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(485, 23);
            this.txtPath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowse.Location = new System.Drawing.Point(498, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 26);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(16, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose folder";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numCheckingTime);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(611, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 72);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set checking time";
            // 
            // numCheckingTime
            // 
            this.numCheckingTime.Location = new System.Drawing.Point(10, 27);
            this.numCheckingTime.Name = "numCheckingTime";
            this.numCheckingTime.Size = new System.Drawing.Size(188, 23);
            this.numCheckingTime.TabIndex = 1;
            this.numCheckingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(859, 434);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(851, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Viewer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gridImportedData, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(845, 402);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // gridImportedData
            // 
            this.gridImportedData.AllowUserToAddRows = false;
            this.gridImportedData.AllowUserToDeleteRows = false;
            this.gridImportedData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridImportedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridImportedData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridImportedData.Location = new System.Drawing.Point(3, 88);
            this.gridImportedData.Name = "gridImportedData";
            this.gridImportedData.ReadOnly = true;
            this.gridImportedData.Size = new System.Drawing.Size(839, 311);
            this.gridImportedData.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblValidation);
            this.groupBox3.Controls.Add(this.btnMonitoringStart);
            this.groupBox3.Controls.Add(this.btnMonitoringStop);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(839, 79);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File monitoring";
            // 
            // lblValidation
            // 
            this.lblValidation.AutoSize = true;
            this.lblValidation.ForeColor = System.Drawing.Color.Red;
            this.lblValidation.Location = new System.Drawing.Point(177, 34);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(149, 17);
            this.lblValidation.TabIndex = 2;
            this.lblValidation.Text = "Validation message";
            // 
            // btnMonitoringStart
            // 
            this.btnMonitoringStart.Location = new System.Drawing.Point(6, 31);
            this.btnMonitoringStart.Name = "btnMonitoringStart";
            this.btnMonitoringStart.Size = new System.Drawing.Size(75, 23);
            this.btnMonitoringStart.TabIndex = 1;
            this.btnMonitoringStart.Text = "Start";
            this.btnMonitoringStart.UseVisualStyleBackColor = true;
            this.btnMonitoringStart.Click += new System.EventHandler(this.btnMonitoringStart_Click);
            // 
            // btnMonitoringStop
            // 
            this.btnMonitoringStop.Location = new System.Drawing.Point(87, 31);
            this.btnMonitoringStop.Name = "btnMonitoringStop";
            this.btnMonitoringStop.Size = new System.Drawing.Size(75, 23);
            this.btnMonitoringStop.TabIndex = 0;
            this.btnMonitoringStop.Text = "Stop";
            this.btnMonitoringStop.UseVisualStyleBackColor = true;
            this.btnMonitoringStop.Click += new System.EventHandler(this.btnMonitoringStop_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblPluginWarning);
            this.tabPage2.Controls.Add(this.btnUploadPlugin);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.lblSettingWarning);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(851, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUploadPlugin
            // 
            this.btnUploadPlugin.Location = new System.Drawing.Point(741, 313);
            this.btnUploadPlugin.Name = "btnUploadPlugin";
            this.btnUploadPlugin.Size = new System.Drawing.Size(75, 23);
            this.btnUploadPlugin.TabIndex = 9;
            this.btnUploadPlugin.Text = "Upload";
            this.btnUploadPlugin.UseVisualStyleBackColor = true;
            this.btnUploadPlugin.Click += new System.EventHandler(this.btnUploadPlugin_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnBrowsePlugin);
            this.groupBox4.Controls.Add(this.txtUploadingPlugin);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(16, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(800, 120);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Upload plugin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(525, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "In order to remove plugin just delete appropriate DLL from application base folde" +
    "r.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(555, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Plugin file name should follow pattern \'Plugin.*.dll\', for instance: \"Plugin.CSVL" +
    "oader.dll\".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plugin must implement \'ILoder\' Interface.";
            // 
            // btnBrowsePlugin
            // 
            this.btnBrowsePlugin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowsePlugin.Location = new System.Drawing.Point(718, 22);
            this.btnBrowsePlugin.Name = "btnBrowsePlugin";
            this.btnBrowsePlugin.Size = new System.Drawing.Size(75, 26);
            this.btnBrowsePlugin.TabIndex = 3;
            this.btnBrowsePlugin.Text = "Browse";
            this.btnBrowsePlugin.UseVisualStyleBackColor = true;
            this.btnBrowsePlugin.Click += new System.EventHandler(this.btnBrowsePlugin_Click);
            // 
            // txtUploadingPlugin
            // 
            this.txtUploadingPlugin.Enabled = false;
            this.txtUploadingPlugin.Location = new System.Drawing.Point(7, 25);
            this.txtUploadingPlugin.Name = "txtUploadingPlugin";
            this.txtUploadingPlugin.Size = new System.Drawing.Size(705, 23);
            this.txtUploadingPlugin.TabIndex = 2;
            // 
            // lblSettingWarning
            // 
            this.lblSettingWarning.AutoSize = true;
            this.lblSettingWarning.ForeColor = System.Drawing.Color.Red;
            this.lblSettingWarning.Location = new System.Drawing.Point(16, 23);
            this.lblSettingWarning.Name = "lblSettingWarning";
            this.lblSettingWarning.Size = new System.Drawing.Size(119, 17);
            this.lblSettingWarning.TabIndex = 7;
            this.lblSettingWarning.Text = "SettingWarning";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(741, 133);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPluginWarning
            // 
            this.lblPluginWarning.AutoSize = true;
            this.lblPluginWarning.ForeColor = System.Drawing.Color.Red;
            this.lblPluginWarning.Location = new System.Drawing.Point(16, 167);
            this.lblPluginWarning.Name = "lblPluginWarning";
            this.lblPluginWarning.Size = new System.Drawing.Size(113, 17);
            this.lblPluginWarning.TabIndex = 10;
            this.lblPluginWarning.Text = "PluginWarning";
            // 
            // FileViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 434);
            this.Controls.Add(this.tabControl1);
            this.Name = "FileViewer";
            this.Text = "File Importer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCheckingTime)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridImportedData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numCheckingTime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView gridImportedData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMonitoringStart;
        private System.Windows.Forms.Button btnMonitoringStop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.Label lblSettingWarning;
        private System.Windows.Forms.Button btnUploadPlugin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBrowsePlugin;
        private System.Windows.Forms.TextBox txtUploadingPlugin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPluginWarning;
    }
}

