using System.Diagnostics;

namespace DesignPatterns.Proxy.CompositeProxy
{
    public class Demo
    {
        public void Start()
        {
            // age x y age x y age x y
            var creatures = new Creature[100];
            foreach (var creature in creatures)
            {
                creature.X++;
            }

            // age age age
            // x x x
            // y y y
            var creatures2 = new Creatures(100);
            foreach (var creature in creatures2)
            {
                creature.X++;
            }
        }
    }
}
