using System;

namespace FileReaderWriter.Menu.MenuStates
{
    public class WriteMenuState : MenuState
    {
        public override void DisplayMenu()
        {
            throw new NotImplementedException();
        }

        public void InformationAboutMenuState()
        {
            Console.WriteLine("Hello\nThis is Write Menu State");
        }

        public override void PressBack()
        {
            throw new NotImplementedException();
        }

        public override void PressSubmit()
        {
            throw new NotImplementedException();
        }

        public override void ReadFromSpecificFile()
        {
        }

        public override void WriteToSpecificFile()
        {
            
        }
    }
}