using CommandPattern.FileAccessObjects;

namespace CommandPattern.Commands
{
    public class WriteFileCommand : ICommand
    {
        IFileAccess _fileAccess;

        public WriteFileCommand(IFileAccess fileAccess)
        {
            _fileAccess = fileAccess;
        }

        public void execute()
        {
            _fileAccess.WriteFile();
        }
    }
}
