namespace FileReaderWriter.Menu.MenuStates 
{
    abstract class MenuState 
    {
        protected Menu _menu;

        public SetMenu(Menu menu)
        {
            _menu = menu;            
        }

        public abstract void ReturnToPreviousMenu();
    }
}