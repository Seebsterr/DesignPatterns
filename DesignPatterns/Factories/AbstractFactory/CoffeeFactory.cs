using DesignPatterns.Factories.AbstractFactory.Enums;

namespace DesignPatterns.Factories.AbstractFactory
{
    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(HotDrinkSize size)
        {
            System.Console.WriteLine($"Preparing coffe... with size={size}");
            return new Coffee();
        }
    }
}