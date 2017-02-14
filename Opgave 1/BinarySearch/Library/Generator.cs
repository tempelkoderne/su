using System;

namespace Library
{
    public class Generator
    {
        public delegate IComparable Initializer(int value);

        public static IComparable SimpleInitializer(int value)
        {
            return value;
        }

        private Random rand;

        public Generator()
        {
            this.rand = new Random ();
        }

        public int NextInt(int maxValue)
        {
            return this.rand.Next (maxValue);
        }

        public IComparable [] NextArray (int size, int maxValue)
        {
            return this.NextArray (size, maxValue, 
                new Initializer (Generator.SimpleInitializer));
        }

        public IComparable [] NextArray (int size, int maxValue, Initializer initializer)
        {
            IComparable[] array = new IComparable[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = initializer(rand.Next(maxValue));
            }
            Array.Sort(array);

            return array;
        }
    }
}