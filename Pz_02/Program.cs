namespace Pz_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p;
            double q, n, m, k;
            double e = 2.718;

            Console.WriteLine("введите p:");
            p = Int32.Parse(Console.ReadLine());
            Console.WriteLine("введите q:");
            q = Double.Parse(Console.ReadLine());

            Console.WriteLine("n:");
            if (p > 2)
            {
                Console.WriteLine(n = Math.Pow(Math.Sin(p + q), 3) + Math.Sqrt(Math.Abs(p) + 1));
            }
            else
            {
                Console.WriteLine(n = p * Math.Cos(q) + 1/ Math.Sqrt(Math.Abs(q)));

            }

            Console.WriteLine("m:");
            if (n <= 2)
            {
                Console.WriteLine(m = Math.Pow(e, (2 * p) + 1* n * (p * n)));
            }
            else
            {
                Console.WriteLine(m = 13 * n); ;
            }

            k = 2 + 13 * n - (p * m + q * n) / 2.5;

            Console.WriteLine("k:");
            Console.WriteLine(k);
        }
    }
}