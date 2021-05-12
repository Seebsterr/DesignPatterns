using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.Builder
{
    public class HtmlElement
    {
        public List<HtmlElement> Elements = new List<HtmlElement>();
        public string Name { get; set; }
        public string Text { get; set; }

        private const int INDENT_SIZE = 2;
 
        public HtmlElement()
        {

        }
        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }

        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', INDENT_SIZE * indent);
            sb.Append($"{i}<{Name}>\n");

            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', INDENT_SIZE * indent + 1));
                sb.Append(Text);
                sb.Append("\n");
            }

            foreach (var e in Elements)
            {
                sb.Append(e.ToStringImpl(indent + 1));
            }

            sb.Append($"{i}</{Name}>\n");
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }
}