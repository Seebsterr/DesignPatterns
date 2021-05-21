namespace DesignPatterns.Flyweight.TextFormatting
{
    public class Demo
    {
        public void Start()
        {
            var ft = new FormattedText("This is a brave new world");
            ft.Capitalize(10, 15);
            System.Console.WriteLine(ft);

            var bft = new BetterFormattedText("This is a brave new world");
            bft.GetRange(10, 15).Capitalize = true;
            System.Console.WriteLine(bft);
        }
    }
}