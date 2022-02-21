using FileReaderWriter.ReadOptions;
using FileReaderWriter.WriteOptions;
using System.IO;

namespace FileReaderWriter
{
    public class Logic
    {
        public void WriteFromRtxtToTxt(string rtxtPath, string txtPath)
        {
            FileReader fileReader = new FileReader(new RTxtFormatter());

            string content = fileReader.ReadContentFromFile(rtxtPath);

            string formattedContent = fileReader.FormatContent(content);

            FileWriter fileWriter = new FileWriter(new TxtWriter());

            fileWriter.WriteToFile(formattedContent, txtPath);
        }
    }
}
