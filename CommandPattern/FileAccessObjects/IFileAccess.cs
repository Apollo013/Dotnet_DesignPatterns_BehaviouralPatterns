namespace CommandPattern.FileAccessObjects
{
    public interface IFileAccess
    {
        void OpenFile();
        void WriteFile();
        void ReadFile();
        void CloseFile();
    }
}
