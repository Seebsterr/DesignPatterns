
namespace DesignPatterns.Proxy.ProtectionProxy
{
    public class Demo
    {
        public void Start()
        {
            ICar car = new DesignPatterns.ProtectionProxy.CarProxy(new Driver() { Age = 18 });
            car.Drive();
        }
    }
}
