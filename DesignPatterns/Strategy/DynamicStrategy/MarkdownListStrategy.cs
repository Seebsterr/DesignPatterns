using System.Text;

namespace DesignPatterns.Strategy.DynamicStrategy
{
    public class MarkdownListStrategy : IListStrategy
    {
        public void AddListItem(StringBuilder sb, string item)
        {
            sb.AppendLine($" * {item}");
        }

        public void End(StringBuilder sb)
        {

        }

        public void Start(StringBuilder sb)
        {

        }
    }
}