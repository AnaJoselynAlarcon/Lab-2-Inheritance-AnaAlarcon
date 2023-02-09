using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_February9
{
    internal class TerminalLogger : ILoggerDriver
    {
        public TerminalLogger()
        { 
        
        }

        //Add a method to output to the terminal
        //you could output to a fax, printer, terminal, etc
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
