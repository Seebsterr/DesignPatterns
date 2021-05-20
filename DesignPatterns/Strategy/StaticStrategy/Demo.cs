namespace DesignPatterns.Strategy.StaticStrategy
{
    public class Demo
    {
        public void Start()
        {
            var tp = new TextProcessor<MarkdownListStrategy>();
            tp.AppendList(new[] { "foo", "bar" });
            System.Console.WriteLine(tp);

            var tp2 = new TextProcessor<HtmlListStrategy>();
            tp2.AppendList(new[] { "foo", "bar" });
            System.Console.WriteLine(tp2);
        }
    }
}