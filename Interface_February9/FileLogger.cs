using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Interface_February9
{
    internal class FileLogger : ILoggerDriver
    {

        private string fileNameFiedl;
        //as a field and reuses the value


        private StreamWriter streamWriterField;



        public FileLogger(string filenameee)
        { 
            this.fileNameFiedl= filenameee; 
            this.streamWriterField = new StreamWriter(filenameee);
        }
           
        public void Log(string message)
        {
            //StreamWriter streamWriterVariable;
            
            //streamWriterVariable=  File.CreateText(this.fileNameFiedl);


            this.streamWriterField.WriteLine(message);

            this.streamWriterField.Flush();

        }
    }
}
