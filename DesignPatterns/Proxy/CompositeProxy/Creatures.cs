using System.Collections.Generic;

namespace DesignPatterns.Proxy.CompositeProxy
{
    public class Creatures
    {
        public int Size { get; }
        private byte[] _age;
        private int[] _x;
        private int[] _y;

        public Creatures(int size)
        {
            Size = size;
            _age = new byte[size];
            _x = new int[size];
            _y = new int[size];
        }

        public CreatureProxy GetElement(int index)
        {
            return new CreatureProxy(this, index);
        }

        public IEnumerator<CreatureProxy> GetEnumerator()
        {
            for (int i = 0; i < Size; i++)
            {
                yield return new CreatureProxy(this, i);
            }
        }

        public struct CreatureProxy
        {
            private readonly Creatures _creatures;
            private readonly int _index;

            public CreatureProxy(Creatures creatures, int index)
            {
                _creatures = creatures;
                _index = index;
            }

            public ref byte Age => ref _creatures._age[_index];
            public ref int X => ref _creatures._x[_index];
            public ref int Y => ref _creatures._y[_index];
        }
    }
}