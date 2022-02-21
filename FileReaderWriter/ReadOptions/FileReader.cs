using System;
using System.IO;

namespace FileReaderWriter.ReadOptions
{
    public class FileReader
    {
        private IReadFormatter _formatter;

        public FileReader(IReadFormatter formatter)
        {
            _formatter = formatter;
        }

        public string FormatContent(string content)
        {
            return _formatter.FormatContent(content);
        }

        public string ReadContentFromFile(string path)
        {
            string content = string.Empty;

            if (File.Exists(path))
            {
                return content = File.ReadAllText(path);
            }
            else
            {
                Console.WriteLine("File doesn't exist. Please re-try...");
            }

            return string.Empty;
        }
    }
}
