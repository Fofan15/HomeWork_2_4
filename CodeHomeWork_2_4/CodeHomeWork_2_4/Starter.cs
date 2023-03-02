using static CodeHomeWork_2_4.Actions;

namespace CodeHomeWork_2_4
{
    static class Starter 
    {
        public static void Run()
        {
            Logger log = new Logger();
            Random rand = new Random();
            

            for (int i = 0; i < 100; i++)
            {
                bool point = false;
                int random = rand.Next(0, 3);

                try
                {
                    switch (random)
                    {
                        case 0:
                            {
                                point = Info();
                            }
                            break;
                        case 1:
                            {
                                point = Warning();
                            }
                            break;
                        case 2:
                            {
                                point = Error();
                            }
                            break;
                    }
                }
                catch (BusinessException ex)
                {
                    log.FileLog("Warning", $"Action got this custom Exception: {ex.ExceptionMessage}");
                    log.ConsoleLog("Warning", $"Action got this custom Exception: {ex.ExceptionMessage}");
                }
                catch (Exception ex) 
                {
                    log.FileLog("Error", $"Action failed by reason: {ex.Message}");
                    log.ConsoleLog("Error", $"Action failed by reason: {ex.Message}");
                }
                if (point)
                {
                    log.ConsoleLog("Info", $"Start method: Info");
                    log.FileLog("Info", $"Start method: Info");
                }
            }
                
        }
    }
}

