using System;
using FileReaderWriter.ReadOptions;
using FileReaderWriter.WriteOptions;

namespace FileReaderWriter.Menu.MenuStates
{
    public class ReadMenuState : MenuState
    {
        public override void DisplayMenu()
        {
            throw new NotImplementedException();
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
            Console.WriteLine("You've chosen read from RTXT. Specify path to the file...");
            string path = Console.ReadLine();

            FileReader reader = new FileReader(new RTxtFormatter());
            string content = reader.ReadContentFromFile(path);
            string formattedContent = reader.FormatContent(content);

            FileWriter writer = new FileWriter(new TxtWriter());
            writer.WriteToFile(formattedContent, @"E:\Study\Test.txt");


        }

        public override void WriteToSpecificFile()
        {
            throw new NotImplementedException();
        }
    }
}