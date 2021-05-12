using static System.Console;

namespace DesignPatterns.Builder.Builder
{
    public class Demo
    {
        public void Start()
        {
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello").AddChild("li", "world");
            WriteLine(builder);
        }
    }
}