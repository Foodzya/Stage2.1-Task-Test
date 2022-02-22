namespace FileReaderWriter.Menu.MenuStates
{
    public class ReadMenu : MenuState
    {
        public override void ReturnToPreviousMenu()
        {
            this._menu.ChangeState(new BaseMenu());
        }
    }
}