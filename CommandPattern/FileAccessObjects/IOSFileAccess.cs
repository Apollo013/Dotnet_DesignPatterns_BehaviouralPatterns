using System;

namespace CommandPattern.FileAccessObjects
{
    public class IOSFileAccess : IFileAccess
    {
        public void CloseFile()
        {
            Console.WriteLine("Closing file in IOS");
        }

        public void OpenFile()
        {
            Console.WriteLine("Opening file in IOS");
        }

        public void ReadFile()
        {
            Console.WriteLine("Reading file in IOS");
        }

        public void WriteFile()
        {
            Console.WriteLine("Writing file in IOS");
        }
    }
}
