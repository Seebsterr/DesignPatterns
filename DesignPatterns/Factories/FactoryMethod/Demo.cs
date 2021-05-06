namespace DesignPatterns.Factories.FactoryMethod
{
    public class Demo
    {
        public void Start()
        {
            var solarPoint = Point.NewPolarPoint(1.0, 2);
            var cartesianPoint = Point.NewCatresianPoint(1.0, 2);

            System.Console.WriteLine(solarPoint);
            System.Console.WriteLine(cartesianPoint);
        }
    }
}