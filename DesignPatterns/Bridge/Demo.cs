using Autofac;

namespace DesignPatterns.Bridge
{
    public class Demo
    {
        public void Start()
        {
            IRenderer raster = new RasterRenderer();
            var circleFromRastel = new Circle(raster, 5);

            circleFromRastel.Draw();
            circleFromRastel.Resize(5);
            circleFromRastel.Draw();

            //or by DI
            var cb = new ContainerBuilder();
            cb.RegisterType<VectorRenderer>().As<IRenderer>().SingleInstance();
            cb.Register((c, p) => new Circle(c.Resolve<IRenderer>(), p.Positional<float>(0)));
            using (var c = cb.Build())
            {
                var circleFromVector = c.Resolve<Circle>(new PositionalParameter(0, 5.0f));
                circleFromVector.Draw();
                circleFromVector.Resize(5);
                circleFromVector.Draw();
            };
        }
    }
}