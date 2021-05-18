using System;

namespace DesignPatterns.Decorator.DynamicDecoratorComposition
{
    public class Demo
    {
        public void Start()
        {
            var square = new Square(1.23f);
            Console.WriteLine(square.AsString());

            var redSquare = new ColoredShape(square, "red");
            Console.WriteLine(redSquare.AsString());

            var redHalfTransparentSquare = new TransparentShape(redSquare, 0.5f);
            Console.WriteLine(redHalfTransparentSquare.AsString());

            ColoredShape<Circle> blueCircle = new ColoredShape<Circle>("blue");
            Console.WriteLine(blueCircle.AsString());

            TransparentShape<ColoredShape<Square>> blackHalfSquare = new TransparentShape<ColoredShape<Square>>(0.4f);
            Console.WriteLine(blackHalfSquare.AsString());
        }
    }
}