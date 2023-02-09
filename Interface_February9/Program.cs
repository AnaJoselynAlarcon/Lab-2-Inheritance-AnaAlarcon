using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Interface_February9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            TerminalLogger logger = new TerminalLogger();

            logger.Log("Action A");
            // same as Console.WriteLine("Does something");


            FileLogger fileLoggerInstance = new FileLogger();

            fileLoggerInstance.Log("Action A.1");

            //create a variable type FileStream
            //StreamWriter streamWriterVariable;

            //while debugginh you can open a file
            //open is for read and write
            //create a file will OVERWRITE the file if it already exists
            //streamWriterVariable = File.CreateText("log.txt");



            //streamWriterVariable.WriteLine("Action by the user");
            //streamWriterVariable.Flush();




            Console.WriteLine("Does something 2");
            streamWriterVariable.WriteLine("does something 2.1");

            //we need to store it in a hard-drive
            streamWriterVariable.Flush();
            //you can do streamWriterVariable.Close(); and will flush until the end but


           


        }
    }
}
