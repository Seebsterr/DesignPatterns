using DesignPatterns.Factories.AbstractFactory.Enums;

namespace DesignPatterns.Factories.AbstractFactory
{
    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(HotDrinkSize size)
        {
            System.Console.WriteLine($"Preparing tea... with size={size}");
            return new Tea();
        }
    }
}