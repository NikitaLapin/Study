using System;

namespace SortWithDifferentWays
{
    public abstract class Sort : ISort
    {
        public virtual void Print(int[] input)
        {
            foreach (int i in input)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        public virtual int[] Sorts(int[] input)
        {
            throw new NotImplementedException();
        }
    }
}