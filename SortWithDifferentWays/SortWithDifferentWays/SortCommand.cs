using System;

namespace SortWithDifferentWays
{
    public class SortCommand : DifferentSorts
    {
        public override int[] Sorts(int[] input)
        {
            Array.Sort(input);
            return input;
        }
    }
}