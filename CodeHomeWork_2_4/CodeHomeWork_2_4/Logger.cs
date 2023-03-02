namespace CodeHomeWork_2_4
{
    public class Logger : FileService
    {
        public string log { get; private set; }


        public void FileLog(string type, string message)
        {
            log += $"{DateTime.Now}: {type}: {message}\n";

            StreamWriter(log);
        }

        public void ConsoleLog(string type, string message)
        {
            string Log = $"{DateTime.Now}: {type}: {message}\n";

            Console.WriteLine(Log);
        }

    }
}
