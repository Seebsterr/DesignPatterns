using System;
using System.ComponentModel;

namespace DesignPatterns.Observer.ObservablePropertiesAndSequences
{
    public class Market
    {
        public BindingList<float> Prices = new BindingList<float>();
        public void AddPrice(float price)
        {
            Prices.Add(price);
        }
    }
}