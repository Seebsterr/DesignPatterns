namespace DesignPatterns.Strategy.DynamicStrategy
{
    public class Demo
    {
        public void Start()
        {
            var tp = new TextProcessor();
            tp.SetOutputFormat(OutputFormat.Markdown);
            tp.AppendList(new[] { "foo", "bar" });
            System.Console.WriteLine(tp);

            tp = new TextProcessor();
            tp.SetOutputFormat(OutputFormat.Html);
            tp.AppendList(new[] { "foo", "bar" });
            System.Console.WriteLine(tp);
        }
    }
}