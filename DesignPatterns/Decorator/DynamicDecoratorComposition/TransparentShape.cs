namespace DesignPatterns.Decorator.DynamicDecoratorComposition
{
    public class TransparentShape : Shape
    {
        private readonly float _transparency;
        private readonly Shape _shape;

        public TransparentShape(Shape shape, float transparency)
        {
            _shape = shape;
            _transparency = transparency;
        }

        public override string AsString() => $"{_shape.AsString()} has {_transparency * 100.0f} transparency";
    }

    public class TransparentShape<T> : Shape where T : Shape, new()
    {
        private readonly float _transparency;
        private T _shape = new T();

        public TransparentShape(float transparency)
        {
            _transparency = transparency;
        }

        public override string AsString()
        {
            return $"{_shape.AsString()} has transparency {_transparency * 100.0f}";
        }
    }
}