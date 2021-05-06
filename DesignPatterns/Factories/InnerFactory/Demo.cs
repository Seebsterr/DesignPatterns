namespace DesignPatterns.Factories.InnerFactory
{
    public class Demo
    {
        public void Start()
        {
            var solarPoint = Point.Factory.NewPolarPoint(1.0, 2);
            var cartesianPoint = Point.Factory.NewCatresianPoint(1.0, 2);
            var origin = Point.Origin;

            System.Console.WriteLine(solarPoint);
            System.Console.WriteLine(cartesianPoint);
        }
    }
}