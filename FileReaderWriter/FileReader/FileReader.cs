using System.IO;

namespace FileReaderWriter.FileReader 
{
    public class FileReader
    {
        private string projectDir = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);

        public string ReadFromTxtFile(string fileName) 
        {
            try 
            {
                string text = File.ReadAllText($"{projectDir}\\{fileName}");
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine(e.Message());
            }

            return text;
        }
    }
}
