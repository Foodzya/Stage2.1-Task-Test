using System;
using System.IO;

namespace FileReaderWriter.WriteOptions
{
    public class TxtWriter : IWriteAction
    {
        public void WriteToFile(string fileContent, string targetFile)
        {
            try
            {
                using (StreamWriter sw = File.CreateText(targetFile))
                {
                    sw.WriteLine(fileContent);
                    Console.WriteLine("Succesfully saved!");
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message + "\nPlease specify txt file for writing there");
            }                        
        }
    }
}
