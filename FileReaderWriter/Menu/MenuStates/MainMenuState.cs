using System;

namespace FileReaderWriter.Menu.MenuStates
{
    public class MainMenuState : MenuState
    {
        public override void PressBack()
        {
            Console.WriteLine("Would you like to quit the application?\n" +
                "If so, press Q");
            if (Console.ReadKey().Key == ConsoleKey.Q)
                Environment.Exit(0);
        }

        public override void PressSubmit()
        {
            Console.WriteLine("Nothing special...");
        }

        public override void ReadFromSpecificFile()
        {
            Console.WriteLine("Nothing special...");
        }

        public override void WriteToSpecificFile()
        {
            Console.WriteLine("Nothing special...");
        }
        public override void DisplayMenu()
        {
            Console.WriteLine("Select which action you would like to perform...\n" +
                "1 Read from file with one of the above specific types (txt, rtxt, etxt, btxt)\n" +
                "2 Read from txt file or console and write to a new file with specific type (txt, rtxt, etxt, btxt\n" +
                "3 Quit application");
             switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    _menuContext.ChangeMenuState(new ReadMenuState());
                    _menuContext.DisplayMenu();
                    break;
                case ConsoleKey.D2:
                    _menuContext.ChangeMenuState(new WriteMenuState());
                    _menuContext.DisplayMenu();
                    break;
                case ConsoleKey.D3:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}