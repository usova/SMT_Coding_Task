using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Timers;

namespace FileImporter.BL.FileWatcher
{
    public class FileWatcher : IFileWatcher
    {
        private readonly string folderPath;
        private readonly TimeSpan timePeriod;
        private HashSet<string> processedFiles = new HashSet<string>();
        private Timer timer;

        public event FileAddedEventHandler FileAdded = delegate { };

        public FileWatcher(string folderPath, TimeSpan time)
        {
            if (string.IsNullOrWhiteSpace(folderPath))
                throw new ArgumentNullException(nameof(folderPath));

            if (time == null)
                throw  new ArgumentNullException(nameof(time));

            if(!Directory.Exists(folderPath))
                throw new ArgumentOutOfRangeException(nameof(folderPath), "Directory not exists");
          
            this.folderPath = folderPath;
            this.timePeriod = time;

            InitializeTimer();
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        private void InitializeTimer()
        {
            timer = new Timer(timePeriod.TotalMilliseconds);
            timer.Elapsed += async (sender, e) => await HandleTimerAsync();
        }

        private Task HandleTimerAsync()
        {
            return new TaskFactory().StartNew(() =>
            {
                var files = Directory.GetFiles(folderPath);

                Parallel.ForEach(
                    files,
                    file =>
                    {
                        if (!processedFiles.Contains(file))
                        {
                            processedFiles.Add(file);
                            OnFileAdded(file);
                        }
                    });
            });
        }

        private void OnFileAdded(string file)
        {
            FileAdded?.Invoke(
                this,
                new FileAddedEventArgs
                {
                    FileFullName = file,
                    FileExtension = Path.GetExtension(file),
                    Name = Path.GetFileName(file)
                });
        }
    }
}
