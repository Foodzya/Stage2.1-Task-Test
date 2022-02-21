using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileReaderWriter.FileWriter
{
    public class TxtWriter : IWriteAction
    {
        public void WriteToANewFile(string fileContent)
        {
            StreamWriter sw = File.CreateText();
            
            sw.Write(fileContent);
        }
    }
}
