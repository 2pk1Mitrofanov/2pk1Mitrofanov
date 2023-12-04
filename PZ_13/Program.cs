namespace PZ_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Вычисление n-го члена арифметической прогрессии с использованием рекурсии.");

            double a1 = 0.5;
            double d = 0.3;

            Console.WriteLine("Введите номер члена прогрессии:");
            int n = int.Parse(Console.ReadLine());

            double result1 = CalculateNthTermArithmetic(a1, d, n);

            Console.WriteLine($"член прогрессии: {result1}");

            Console.WriteLine("\n----------------\n");

            Console.WriteLine("2. Вычисление n-го члена геометрической прогрессии с использованием рекурсии.");

            double b1 = 14;
            double q = 2;

            Console.WriteLine("Введите номер члена прогрессии:");
            int n2 = int.Parse(Console.ReadLine());

            double result2 = CalculateNthTermGeometric(b1, q, n2);

            Console.WriteLine($"Член геометрической прогрессии: {result2}");

            Console.WriteLine("\n----------------\n");

            Console.WriteLine("3. Вывод всех чисел от A до B включительно с использованием рекурсии.");

            Console.WriteLine("Введите значение А: ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение В: ");
            int B = int.Parse(Console.ReadLine());

            if (A < B)
            {
                PrintAscending(A, B);
            }
            else
            {
                PrintDescending(A, B);
            }
            Console.WriteLine("\n----------------\n");
            
            static void PrintAscending(int start, int end)
            {
                if (start<=end)
                {
                    Console.Write($"{start}");
                    PrintAscending(start + 1, end);
                }
            }
            
            static void PrintDescending(int start, int end)
            {
                if (start >= end)
                {
                    Console.Write($"{start} ");
                    PrintDescending(start - 1, end);
                }
            }

            static double CalculateNthTermArithmetic(double a1, double d, int n)
            {
                if (n==1)
                {
                    return a1;
                }
                else
                {
                    return CalculateNthTermArithmetic(a1, d, n - 1) + d;
                }
            }
        }
        static double CalculateNthTermGeometric(double b1, double q, int n)
        {
            if (n == 1)
            {
                return b1;
            }
            else
            {
                return CalculateNthTermGeometric(b1, q, n - 1) * q;
            }

        }
    }
}
