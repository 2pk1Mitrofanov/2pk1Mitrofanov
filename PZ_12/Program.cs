namespace PZ_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 7, 5, 2, 3, 4, 8, 1, 16 };
            Array.Sort(numbers);

            double median = CalculateMedian(numbers);

            Console.WriteLine($"Медиана равна {median}");
        }
        static double CalculateMedian(int[] sortedArray)
        {
            int n = sortedArray.Length;

            if (n % 2 == 0 )
            {
                int middleIndex1 = n / 2 - 1;
                int middleIndex2 = n / 2;
                return (sortedArray[middleIndex1] + sortedArray[middleIndex2]) / 2.0;
            }
            else
            {
                int middleIndex = n / 2;
                return sortedArray[middleIndex];
            }
        }
    }
}
