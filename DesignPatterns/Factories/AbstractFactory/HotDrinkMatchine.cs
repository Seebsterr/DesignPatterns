using DesignPatterns.Factories.AbstractFactory.Enums;
using System;
using System.Collections.Generic;
using static System.Console;

namespace DesignPatterns.Factories.AbstractFactory
{
    public class HotDrinkMatchine
    {
        private const string FACTORY_NAME = "Factory";
        private List<(string Name, IHotDrinkFactory Drink)> _factories = new List<(string, IHotDrinkFactory)>();

        public HotDrinkMatchine()
        {
            InitFactories();
        }

        private void InitFactories()
        {
            foreach (var t in typeof(HotDrinkMatchine).Assembly.GetTypes())
            {
                if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    var name = t.Name.Replace(FACTORY_NAME, string.Empty);
                    _factories.Add((name, (IHotDrinkFactory)Activator.CreateInstance(t)));
                }
            }
        }

        public IHotDrink MakeDrink()
        {
            WriteAllDrinks();
            return SelectProductFromUser();
        }

        private void WriteAllDrinks()
        {
            WriteLine("Available drinks:");
            for (int i = 0; i < _factories.Count; i++)
            {
                WriteLine($"{i}: {_factories[i].Name}");
            }
        }

        private void WriteAllSizes()
        {
            WriteLine("Available size:");
            for (int i = 0; i < Enum.GetNames(typeof(HotDrinkSize)).Length; i++)
            {
                WriteLine($"{i}: {(HotDrinkSize)i}");
            }
        }

        private IHotDrink SelectProductFromUser()
        {
            while (true)
            {
                string s;
                if ((s = ReadLine()) != null && int.TryParse(s, out int i) && i >= 0 && i < _factories.Count)
                {
                    WriteAllSizes();
                    Write("Specyfy size from 0 to 2: ");
                    s = ReadLine();

                    if (s != null && int.TryParse(s, out int amount) && amount >=  0 && amount < Enum.GetNames(typeof(HotDrinkSize)).Length)
                    {
                        return _factories[i].Drink.Prepare((HotDrinkSize)amount);
                    }
                }

                WriteLine("Incorrect input, try again!");
            }
        }
    }
}