using FileReaderWriter.Menu;

namespace FileReaderWriter 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Logic logic = new Logic();

            Menu menu = new FileReaderWriter.Menu(new ReadMenu());
            menu.

            logic.WriteFromRtxtToTxt(@"E:\Study\Internship Tasks\File Reader\new_file.rtxt", @"E:\Study\Internship Tasks\File Reader\destination.txt");
        }
    }
}

