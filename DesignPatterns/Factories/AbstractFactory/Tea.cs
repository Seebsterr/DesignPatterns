namespace DesignPatterns.Factories.AbstractFactory
{
    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            System.Console.WriteLine("Drinking tea...");
        }
    }
}