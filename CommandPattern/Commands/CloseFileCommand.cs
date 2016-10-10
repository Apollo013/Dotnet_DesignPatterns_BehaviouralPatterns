using CommandPattern.FileAccessObjects;

namespace CommandPattern.Commands
{
    public class CloseFileCommand : ICommand
    {
        IFileAccess _fileAccess;

        public CloseFileCommand(IFileAccess fileAccess)
        {
            _fileAccess = fileAccess;
        }

        public void execute()
        {
            _fileAccess.CloseFile();
        }
    }
}
