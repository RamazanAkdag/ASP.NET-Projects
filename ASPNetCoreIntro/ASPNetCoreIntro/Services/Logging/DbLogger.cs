namespace ASPNetCoreIntro.Services.Logging
{
    public class DbLogger : InLogger
    {
        public void Log(string logMessage)
        {
            //veritabanına kaydetme kodları
            Console.WriteLine(logMessage.ToString());
        }
    }
}
