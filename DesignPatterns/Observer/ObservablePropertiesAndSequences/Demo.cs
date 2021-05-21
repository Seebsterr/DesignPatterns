using System;
using System.ComponentModel;

namespace DesignPatterns.Observer.ObservablePropertiesAndSequences
{
    public class Demo
    {
        public void Start()
        {
            var market = new Market();
            market.Prices.ListChanged += (sender, eventArgs) =>
            {
                if (eventArgs.ListChangedType == ListChangedType.ItemAdded)
                {
                    Console.WriteLine($"Added price {((BindingList<float>)sender)[eventArgs.NewIndex]}");
                }
            };
            market.AddPrice(123);
        }
    }
}