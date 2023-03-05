namespace CodeHomeWork_2_4
{
    internal sealed class Program
    {
        static void Main(string[] args)
        {
            FileService fileservice = new FileService() /*{Path = ".\\log\\", FileName = $"{DateTime.Now.ToString("hh.hh.ss dd.MM.yyyy") + ".txt"}" }*/;

            Starter.Run();

            Console.ReadKey();
        }

    }
}