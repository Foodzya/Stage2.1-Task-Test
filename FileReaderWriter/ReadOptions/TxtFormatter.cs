using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderWriter.ReadOptions
{
    public class TxtFormatter : IReadFormatter
    {
        public string FormatContent(string content)
        {
            return content;
        }
    }
}
