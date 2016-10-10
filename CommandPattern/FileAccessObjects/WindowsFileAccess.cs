using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.FileAccessObjects
{
    public class WindowsFileAccess : IFileAccess
    {
        public void CloseFile()
        {
            Console.WriteLine("Closing file in Windows OS");
        }

        public void OpenFile()
        {
            Console.WriteLine("Opening file in Windows OS");
        }

        public void ReadFile()
        {
            Console.WriteLine("Reading file in Windows OS");
        }

        public void WriteFile()
        {
            Console.WriteLine("Writing file in Windows OS");
        }
    }
}
