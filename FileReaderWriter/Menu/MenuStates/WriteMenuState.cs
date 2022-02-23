using FileReaderWriter.ReadOptions;
using FileReaderWriter.WriteOptions;
using System;
using System.IO;

namespace FileReaderWriter.Menu.MenuStates
{
    public class WriteMenuState : MenuState
    {
        public override void DisplayMenu()
        {
            Console.Clear();

            Console.WriteLine("WRITE MENU\n" +
                "—————————————————————————————\n" +
                "1 -- Write text (only .txt, .rtxt, .etxt, .btxt are applicable)\n" +
                "2 -- Back to the main menu");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    WriteToSpecificFile();
                    break;
                case ConsoleKey.D2:
                    _menuContext.PressBack();
                    break;
            }
        }

        public void InformationAboutMenuState()
        {
            Console.WriteLine("Hello\nThis is Write Menu State");
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
            Console.WriteLine("That's doing nothing special");
        }

        public override void WriteToSpecificFile()
        {
            string? content = GetSourceText();

            string targetFile = PathToDestinationFile();

            FileWriter fileWriter = new FileWriter();

            fileWriter.WriteToFile(content, targetFile);
        }

        private string GetSourceText()
        {
            Console.WriteLine("READ OPTIONS\n" +
                "—————————————————————————————\n" +
                "1 -- To read text from txt\n" +
                "2 -- To read text from console input\n" +
                "3 -- Back to the menu");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Specify path to the txt file..\n" 
                        + @"Example: C:\ExampleFolder\example.txt");
                    string? path = Console.ReadLine();
                    if (File.Exists(path))
                        return File.ReadAllText(path);
                    break;
                case ConsoleKey.D2:
                    string? content = Console.ReadLine();
                    return content;
                case ConsoleKey.D3:
                    _menuContext.DisplayMenu();
                    break;
                default:
                    Console.WriteLine("An error occured. Try again.");
                    GetSourceText();
                    break;
            }

            return string.Empty;
        }

        private string PathToDestinationFile()
        {
            Console.WriteLine("Specify destination file (only .txt, .rtxt, .etxt, .btxt files are applicable..");

            string? path = Console.ReadLine();

            if (File.Exists(path))
            {
                return path;
            }
            else
            {
                Console.WriteLine("An error occured\n" +
                    "1 -- Try again\n" +
                    "Press any button to get back to the main menu");
                if (!(Console.ReadKey().Key == ConsoleKey.D1))
                    _menuContext.ChangeMenuState(new MainMenuState());
            }

            return string.Empty;
        }
    }
}