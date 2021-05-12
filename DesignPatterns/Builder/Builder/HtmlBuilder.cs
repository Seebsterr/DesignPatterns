namespace DesignPatterns.Builder.Builder
{
    public class HtmlBuilder
    {
        private HtmlElement _htmlElement = new HtmlElement();

        public HtmlBuilder(string name)
        {
            _htmlElement.Name = name;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            _htmlElement.Elements.Add(e);
            return this;
        }

        public override string ToString()
        {
            return _htmlElement.ToString();
        }

        public void Clear()
        {
            var rootName = _htmlElement.Name;
            _htmlElement = new HtmlElement { Name = rootName };
        }
    }
}