using System;
using System.IO;
using FileReaderWriter.ReadOptions;
using FileReaderWriter.WriteOptions;

namespace FileReaderWriter.Menu.MenuStates
{
    public class ReadMenuState : MenuState
    {
        public override void DisplayMenu()
        {
            Console.Clear();

            Console.WriteLine("READ MENU\n" +
                "—————————————————————————————\n" +
                "1 -- Read from (only txt, rtxt, etxt, btxt)\n" +
                "2 -- Back to the main menu");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Specify path to the file..\n" +
                        @"Example: C:\ExampleFolder\example.txt");
                    _menuContext.ReadFromSpecificFile();
                    break;
                case ConsoleKey.D2:
                    _menuContext.PressBack();
                    break;
            }
        }

        public void InformationAboutMenuState()
        {
            Console.WriteLine("Hello\nThis is Read Menu State");
        }

        public override void PressBack()
        {
            _menuContext.ChangeMenuState(new MainMenuState());
        }

        public override void PressSubmit()
        {
            throw new NotImplementedException();
        }

        public override void ReadFromSpecificFile()
        {
            string? path = Console.ReadLine();

            FileReader fileReader = new FileReader();

            if (File.Exists(path))
            {
                string content = fileReader.ReadContentFromFile(path);

                FileWriter fileWriter = new FileWriter(new TxtWriter());

                Console.WriteLine("Specify destination txt file...");

                string? targetFile = Console.ReadLine();

                if (File.Exists(targetFile))
                {
                    fileWriter.WriteToFile(content, targetFile);
                }
            }
        }

        public override void WriteToSpecificFile()
        {
            Console.WriteLine("That's doing nothing here");
        }
    }
}