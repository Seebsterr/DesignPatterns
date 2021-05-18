namespace DesignPatterns.Decorator.DynamicDecoratorComposition
{
    public class ColoredShape : Shape
    {
        private Shape _shape;
        private readonly string _color;

        public ColoredShape(Shape shape, string color)
        {
            _shape = shape;
            _color = color;
        }

        public override string AsString() => $"{_shape.AsString()} has the color {_color}";
    }

    public class ColoredShape<T> : Shape where T : Shape, new()
    {
        private readonly string _color;
        private T _shape = new T();

        public ColoredShape() : this("black")
        {

        }

        public ColoredShape(string color)
        {
            _color = color;
        }

        public override string AsString()
        {
            return $"{_shape.AsString()} has the color {_color}";
        }
    }
}