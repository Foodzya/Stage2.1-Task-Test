using System;
using System.IO;
using FileReaderWriter.FileReader;
using FileReaderWriter.FileWriter;

namespace FileReaderWriter 
{
    public class Program
    {
        public void Main(string[] args)
        {

        }

        public void WriteFromTxtFile(string fileName)
        {   
            string fileExtension = GetFileExtension(fileName);

            FileReader fileReader = new FileReader();
            string fileContent = fileReader.ReadFromTxtFile(fileName);

            if(fileName)

            FileWriter fileWriter = new FileWriter(new TxtWriter());
            fileWriter.WriteToANewFile(fileContent);
        }

        public string GetFileExtension(string fileName)
        {
             string extension;

             extension = Path.GetExtension(fileName);

             return extension;
        }
    }
}

