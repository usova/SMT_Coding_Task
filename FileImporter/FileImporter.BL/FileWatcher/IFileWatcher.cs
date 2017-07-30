namespace FileImporter.BL.FileWatcher
{
    public interface IFileWatcher
    {
        event FileAddedEventHandler FileAdded;

        void Start();

        void Stop();
    }
}