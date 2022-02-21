using System.IO;

namespace FileReaderWriter.WriteOptions
{
    public class TxtWriter : IWriteAction
    {
        public void WriteToFile(string fileContent, string destPath)
        {
            using (StreamWriter sw = File.CreateText(destPath))
            {
                sw.WriteLine(fileContent);
            }            
        }
    }
}
