using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderWriter.FileWriter
{
    public interface IWriteAction
    {
        public void WriteToANewFile(string fileContent);
    }
}
