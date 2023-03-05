namespace CodeHomeWork_2_4
{
    public class Logger : FileService
    {
        public string Log { get; private set; }

        public void FileLog(string type, string message)
        {
            Log += $"{DateTime.Now}: {type}: {message}\n";

            StreamWriter(Log);
        }

        public void ConsoleLog(string type, string message)
        {
            string Log = $"{DateTime.Now}: {type}: {message}\n";

            Console.WriteLine(Log);
        }

    }
}
