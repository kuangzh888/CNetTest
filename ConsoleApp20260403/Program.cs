using log4net;
using log4net.Config;

namespace ConsoleApp20260403
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlConfigurator.Configure(new FileInfo("log4net.config"));
            ILog log = LogManager.GetLogger(typeof(Program));
            log.Debug("debug message");
            log.Info("hello world");
            log.Error("error message");



            while (true)
            {
                Console.WriteLine("input a num");
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine(100 / num);
                }
                catch (FormatException ex)
                {
                    log.Error(ex.Message);
                }
                catch (Exception ex)
                {
                    log.Error(ex.StackTrace);
                }
            }

        }
    }
}
