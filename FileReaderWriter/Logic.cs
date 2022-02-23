using FileReaderWriter.ReadOptions;
using FileReaderWriter.WriteOptions;
using FileReaderWriter.Menu;
using System;

namespace FileReaderWriter
{
    public class Logic
    {
        public void LaunchMenu()
        {
            MenuContext menu = new MenuContext();

            menu.DisplayMenu();

            Console.ReadLine();
        }
    }
}
