namespace DesignPatterns.Factories.Factory
{
    public class Demo
    {
        public void Start()
        {
            var solarPoint = PointFactory.NewPolarPoint(1.0, 2);
            var cartesianPoint = PointFactory.NewCatresianPoint(1.0, 2);

            System.Console.WriteLine(solarPoint);
            System.Console.WriteLine(cartesianPoint);
        }
    }
}