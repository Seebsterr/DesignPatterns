namespace DesignPatterns.Proxy.PropertyProxy
{
    public class Demo
    {
        public void Start()
        {
            var property = new Property<int>();
            property.Value = 1;
            property.Value = 1;
        }
    }
}
