using CommandPattern.FileAccessObjects;

namespace CommandPattern.Commands
{
    public class OpenFileCommand : ICommand
    {
        IFileAccess _fileAccess;

        public OpenFileCommand(IFileAccess fileAccess)
        {
            _fileAccess = fileAccess;
        }

        public void Execute()
        {
            _fileAccess.OpenFile();
        }
    }
}
