namespace CodeHomeWork_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileService.Path = ".\\log\\";

            FileService.FileName = $"{DateTime.Now.ToString("hh.hh.ss dd.MM.yyyy") + ".txt"}";

            Starter.Run();

            Console.ReadKey();
        }

    }
}