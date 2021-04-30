namespace DesignPatterns.Proxy.ValueProxy
{
    public class Percentage
    {
        private readonly float _value;
        public Percentage(float value)
        {
            _value = value;
        }

        public static float operator *(float f, Percentage p)
        {
            return f * p._value;
        }
        public static float operator +(Percentage p1, Percentage p2)
        {
            return p1._value + p2._value;
        }

        public override string ToString()
        {
            return $"{(int)(_value * 100)}%";
        }
    }
}
