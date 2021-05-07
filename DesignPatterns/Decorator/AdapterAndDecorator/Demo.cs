namespace DesignPatterns.Decorator.AdapterAndDecorator
{
    public class Demo
    {
        public void Start()
        {
            MyStringBuilder s = "hello ";
            s += "world";

            System.Console.WriteLine(s);
        }
    }
}