using Microsoft.SqlServer.Server;

namespace SortWithDifferentWays
{
    public class DifferentSorts : Sort
    {
        public override int[] Sorts(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int buffer = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = buffer;
                    }
                }
            }

            return input;
        }
    }
}