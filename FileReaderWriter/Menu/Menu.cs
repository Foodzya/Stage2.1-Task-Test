namespace FileReaderWriter.Menu
{
    public class Menu
    {
        private MenuState _menuState = null;

        public Menu(MenuState menustate)
        {
            _menuState = menustate;
        }

        public void ChangeState(MenuState menuState)
        {
            Console.WriteLine($"Transition to {menuState.GetType().Name}.");

            _menuState = menuState;

            _menuState.SetMenu(this);
        }

        public void ReturnToPreviousMenu()
        {
            this._menuState.ReturnToPreviousMenu();
        }
    }
}