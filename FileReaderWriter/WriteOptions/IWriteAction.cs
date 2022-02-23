namespace FileReaderWriter.WriteOptions
{
    public interface IWriteAction
    {
        public void WriteToFile(string fileContent, string targetFile);
    }
}
