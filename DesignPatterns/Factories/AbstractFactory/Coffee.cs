namespace DesignPatterns.Factories.AbstractFactory
{
    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            System.Console.WriteLine("Drinking coffe...");
        }
    }
}
