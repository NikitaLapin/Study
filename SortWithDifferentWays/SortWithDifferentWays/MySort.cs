namespace SortWithDifferentWays
{
    public class MySort : DifferentSorts
    {
        public override int[] Sorts(int[] input)
        {
            int[] result = new int[input.Length];
            int theSmallest = input[0], buffer = 0, theSmallestNumberId = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0 + buffer; j < input.Length; j++)
                {
                    if (theSmallest > input[j])
                    {
                        theSmallest = input[j];
                        theSmallestNumberId = j;
                    }
                }

                input[theSmallestNumberId] = input[i];
                result[i] = theSmallest;
                buffer++;
                if (buffer == 5)
                {
                    buffer--;
                }
                theSmallest = input[buffer];
            }

            return result;
        }
    }
}