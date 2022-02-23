using FileReaderWriter.Menu;
using FileReaderWriter.Menu.MenuStates;
using System;
using System.IO;

namespace FileReaderWriter 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Logic logic = new Logic();

            logic.LaunchMenu();

            //logic.WriteFromRtxtToTxt(@"E:\Study\Internship Tasks\File Reader\new_file.rtxt", @"E:\Study\Internship Tasks\File Reader\destination.txt");
        
        }
    }
}

