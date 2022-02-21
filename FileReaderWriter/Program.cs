namespace FileReaderWriter 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Logic logic = new Logic();

            logic.WriteFromRtxtToTxt(@"E:\Study\Internship Tasks\File Reader\new_file.rtxt", @"E:\Study\Internship Tasks\File Reader\destination.txt");
        }
    }
}

