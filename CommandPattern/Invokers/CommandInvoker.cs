using CommandPattern.Commands;

namespace CommandPattern.Invokers
{
    public class CommandInvoker
    {
        ICommand _command;

        public CommandInvoker(ICommand command)
        {
            _command = command;
        }

        public void execute()
        {
            _command.execute();
        }
    }
}
