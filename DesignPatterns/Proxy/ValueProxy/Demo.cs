namespace DesignPatterns.Proxy.ValueProxy
{
    public class Demo
    {
        public void Start()
        {
            System.Console.WriteLine(10f * 5f.Percent());
            System.Console.WriteLine(10f.Percent() + 5f.Percent());
            System.Console.WriteLine(20f.Percent());
        }
    }
}
