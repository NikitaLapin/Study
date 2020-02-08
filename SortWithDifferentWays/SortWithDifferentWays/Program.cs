namespace SortWithDifferentWays
{
    internal class Program
    {
        private static void Sort(ISort sort)
        {
            const int size = 5;
            var input = new int[size] {14, 1, 12, 65, 51};
            
            int[] result = new int[size];
            result = sort.Sorts(input);
            sort.Print(result);
        }
        
        public static void Main(string[] args)
        {
            var sort1 = new DifferentSorts();
            var sort2 = new SortCommand();
            var sort3 = new MySort();
            
            Sort(sort1);
            Sort(sort2);
            Sort(sort3);
        }
    }
}