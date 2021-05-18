namespace DesignPatterns.NullObject
{
    public class ConsoleLog : ILog
    {
        public void Info(string msg)
        {
            System.Console.WriteLine(msg);
        }

        public void Warn(string msg)
        {
            System.Console.WriteLine("WARNING!!! " + msg);
        }
    }
}