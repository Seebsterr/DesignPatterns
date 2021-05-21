using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Flyweight.TextFormatting
{
    public class BetterFormattedText
    {
        private string _plainText;
        private List<TextRange> _formatting;

        public BetterFormattedText(string plainText)
        {
            _formatting = new List<TextRange>();
            _plainText = plainText;
        }

        public TextRange GetRange(int start, int end)
        {
            var range = new TextRange { Start = start, End = end };
            _formatting.Add(range);
            return range;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (var i = 0; i < _plainText.Length; i++)
            {
                var c = _plainText[i];
                foreach (var range in _formatting.Where(x => x.Covers(i) && x.Capitalize))
                {
                    c = char.ToUpperInvariant(c);
                }
                sb.Append(c);
            }

            return sb.ToString();
        }

        public class TextRange
        {
            public int Start, End;
            public bool Capitalize;

            public bool Covers(int position)
            {
                return position >= Start && position <= End;
            }
        }
    }
}