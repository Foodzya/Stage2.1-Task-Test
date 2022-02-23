﻿using System;
using System.IO;

namespace FileReaderWriter.WriteOptions
{
    public class FileWriter
    {
        private IWriteAction _writer;

        public FileWriter()
        {

        }

        public FileWriter(IWriteAction writer)
        {
            _writer = writer;
        }

        public void WriteToFile(string fileContent, string targetFile)
        {
            ValidateFileExtension(targetFile);

            _writer.WriteToFile(fileContent, targetFile);
        }

        private void SetWriter(IWriteAction writer)
        {
            _writer = writer;
        }

        private void ValidateFileExtension(string path)
        {
            string extension = Path.GetExtension(path);

            switch (extension)
            {
                case ".txt":
                    SetWriter(new TxtWriter());
                    break;
                case ".rtxt":
                    SetWriter(new RTxtWriter());
                    break;
                case ".etxt":
                    SetWriter(new ETxtWriter());
                    break;
                case ".btxt":
                    SetWriter(new BTxtWriter());
                    break;
                default:
                    Console.WriteLine("This file type is unsupported.");
                    break;
            }
        }
    }
}
