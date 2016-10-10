using CommandPattern.FileAccessObjects;

namespace CommandPattern.Commands
{
    class ReadFileCommand : ICommand
    {
        IFileAccess _fileAccess;

        public ReadFileCommand(IFileAccess fileAccess)
        {
            _fileAccess = fileAccess;
        }

        public void execute()
        {
            _fileAccess.ReadFile();
        }
    }
}
