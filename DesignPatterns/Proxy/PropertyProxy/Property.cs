using System;
using System.Collections.Generic;

namespace DesignPatterns.Proxy.PropertyProxy
{
    public class Property<T> where T : new()
    {
        public T Value
        {
            get => _value;
            set
            {
                if (Equals(_value, value))
                {
                    return;
                }

                Console.WriteLine($"Assigning value to {value}");
                _value = value;
            }
        }

        private T _value;

        public Property() : this(Activator.CreateInstance<T>()) { }

        public Property(T value)
        {
            _value = value;
        }

        public static implicit operator T(Property<T> property)
        {
            return property.Value;
        }

        public static implicit operator Property<T>(T value)
        {
            return new Property<T>(value);
        }
    }
}