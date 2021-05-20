using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy.StaticStrategy
{
    public class TextProcessor<LS> where LS: IListStrategy, new()
    {
        private readonly StringBuilder _stringBuilder = new StringBuilder();
        private IListStrategy _listStrategy = new LS();

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
    }
}