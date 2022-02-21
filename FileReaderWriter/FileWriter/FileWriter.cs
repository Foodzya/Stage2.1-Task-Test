using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderWriter.FileWriter
{
    public class FileWriter
    {
        private IWriteAction _writer;

        public FileWriter(IWriteAction writer)
        {
            _writer = writer;
        }

        public void SetWriter(IWriteAction writer)
        {
            _writer = writer;
        }

        public void WriteToANewFile(string fileContent)
        {
            _writer.WriteToANewFile(fileContent);
        }
    }
}
