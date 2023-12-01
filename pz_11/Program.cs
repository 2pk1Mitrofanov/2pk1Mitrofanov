namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = { 3.5, 4.0, 5.2, 6.7, 7.1 };

            foreach (var number  in numbers)
            {
                double result;
                PowerA3(number, out result);
                Console.WriteLine($"3 степень числа {number}: {result}") ;
            }
        }
        static void PowerA3(double A, out double B)
        {
            B = Math.Pow(A, 3);
        }
    }
}
