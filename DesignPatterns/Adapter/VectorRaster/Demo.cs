using System.Collections.Generic;
using MoreLinq;

namespace DesignPatterns.Adapter.VectorRaster
{
    public class Demo
    {
        private static readonly List<VectorObject> vectorObjects = new List<VectorObject>
    {
      new VectorRectangle(1, 1, 10, 10),
      new VectorRectangle(3, 3, 6, 6)
    };

        public static void DrawPoint(Point p)
        {
            System.Console.WriteLine(".");
        }

        private static void Draw()
        {
            foreach (var vo in vectorObjects)
            {
                foreach (var line in vo)
                {
                    var adapter = new LineToPointAdapter(line);
                    adapter.ForEach(DrawPoint);
                }
            }
        }

        public void Start()
        {
            Draw();
            Draw();
        }
    }
}