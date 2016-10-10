using CommandPattern.Commands;
using CommandPattern.FileAccessObjects;
using CommandPattern.Invokers;

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
            CommandInvoker invoker = new CommandInvoker(winOpenCommand);
            invoker.execute();

            invoker = new CommandInvoker(iosOpenCommand);
            invoker.execute();

            invoker = new CommandInvoker(winCloseCommand);
            invoker.execute();

            invoker = new CommandInvoker(iosCloseCommand);
            invoker.execute();
        }
    }
}
