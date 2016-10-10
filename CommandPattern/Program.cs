using CommandPattern.Commands;
using CommandPattern.FileAccessObjects;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // File Access Objects
            IFileAccess winAccess = new WindowsFileAccess();
            IFileAccess iosAccess = new IOSFileAccess();


            // Commands
            ICommand winOpenCommand = new OpenFileCommand(winAccess);
            ICommand iosOpenCommand = new OpenFileCommand(iosAccess);

            ICommand winCloseCommand = new CloseFileCommand(winAccess);
            ICommand iosCloseCommand = new CloseFileCommand(iosAccess);


            // Invoke commands
            winOpenCommand.Execute();
            winCloseCommand.Execute();

            iosOpenCommand.Execute();
            iosCloseCommand.Execute();
        }
    }
}
