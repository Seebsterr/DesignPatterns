using DesignPatterns.Proxy.ProtectionProxy;

namespace DesignPatterns.ProtectionProxy
{
    public class CarProxy : ICar
    {
        private Driver _driver { get; set; }
        private Car _car { get; set; }

        public CarProxy(Driver driver)
        {
            _driver = driver;
            _car = new Car();
        }

        public void Drive()
        {
            if(_driver.Age >= 18)
            {
                _car.Drive();
            }
            else
            {
                System.Console.WriteLine("Cannot drive.");
            }
        }
    }
}