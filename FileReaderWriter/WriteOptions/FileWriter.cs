namespace FileReaderWriter.WriteOptions
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

        public void WriteToFile(string fileContent, string destPath)
        {
            _writer.WriteToFile(fileContent, destPath);
        }
    }
}
