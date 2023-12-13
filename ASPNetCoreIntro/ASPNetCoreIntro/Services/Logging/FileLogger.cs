
namespace ASPNetCoreIntro.Services.Logging
{
    public class FileLogger : InLogger
    {
        public void Log(string logMessage)
        {
            Console.WriteLine(logMessage.ToString());
        }
    }
}
