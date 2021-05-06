namespace DesignPatterns.Factories.AbstractFactory
{
    public class Demo
    {
        public void Start()
        {
            var machine = new HotDrinkMatchine();
            var drink = machine.MakeDrink();
        }
    }
}