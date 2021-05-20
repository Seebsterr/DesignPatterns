using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy.DynamicStrategy
{
    public class TextProcessor
    {
        private readonly StringBuilder _stringBuilder = new StringBuilder();
        private IListStrategy _listStrategy;

        public void SetOutputFormat(OutputFormat format)
        {
            switch (format)
            {
                case OutputFormat.Markdown:
                    _listStrategy = new MarkdownListStrategy();
                    break;
                case OutputFormat.Html:
                    _listStrategy = new HtmlListStrategy();
                    break;
            }
        }

        public void AppendList(IEnumerable<string> items)
        {
            _listStrategy.Start(_stringBuilder);
            foreach (var item in items)
            {
                _listStrategy.AddListItem(_stringBuilder, item);
            }
            _listStrategy.End(_stringBuilder);
        }

        public override string ToString()
        {
            return _stringBuilder.ToString();
        }

        public StringBuilder Clear()
        {
            return _stringBuilder.Clear();
        }
    }
}