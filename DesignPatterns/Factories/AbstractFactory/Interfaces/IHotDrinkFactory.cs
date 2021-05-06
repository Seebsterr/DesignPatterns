using DesignPatterns.Factories.AbstractFactory.Enums;

namespace DesignPatterns.Factories.AbstractFactory
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(HotDrinkSize size);
    }
}