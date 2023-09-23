namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        { //Начало первого задания

            int start = 10; // Начальное значение диапазона
            int end = 90;   // Конечное значение диапазона
            int step = 3;   // Шаг

            for (int i = start; i <= end; i += step)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            Console.Write("#################################"); //Конец первого задания

            //Начало второго задания

            Console.WriteLine();
            Console.WriteLine();

            char startChar = 'Б'; // Начальный символ (русская 'Б')
            int n2 = 6;           // Количество символов

            for (int i = 0; i < n2; i++)
            {
                char currentChar = (char)(startChar + i);
                Console.Write(currentChar);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("#################################"); //Конец второго задания

            //Начало третьего задания

            Console.WriteLine();
            Console.WriteLine();

            int n3 = 5; // Количество символов '#' в каждой строке
            int m = 7; // Количество строк

            for (int i = 0; i < m; i++)
            {
                for (int j3 = 0; j3 < n3; j3++)
                {
                    Console.Write("#");
                }
                Console.WriteLine(); // Переход на следующую строку после каждой строки символов
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("#################################"); //Конец третьего задания

            //Начало четвёртого задания

            Console.WriteLine();
            Console.WriteLine();

            int minValue = -50; // Начальное значение диапазона
            int maxValue = 50;  // Конечное значение диапазона
            int divisor = 8;   // Значение, кратные которому нужно вывести
            int count = 0;     // Счетчик кратных чисел

            Console.WriteLine($"Диапазон: {minValue}...{maxValue}");
            Console.WriteLine($"Значение, кратное: {divisor}");
            Console.Write("Кратные числа: ");

            for (int i = minValue; i <= maxValue; i++)
            {
                if (i % divisor == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
            }

            Console.WriteLine($"\nКоличество кратных чисел: {count}");

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("#################################"); //Конец четвёртого задания

            //Начало пятого задания

            Console.WriteLine();
            Console.WriteLine();

            int i5 = 3;       // Начальное значение переменной i
            int j5 = 60;      // Начальное значение переменной j
            int targetDiff = 13;  // Целевая разница между i и j

            Console.WriteLine($"Начальное значение i: {i5}");
            Console.WriteLine($"Начальное значение j: {j5}");
            Console.WriteLine($"Целевая разница: {targetDiff}");
            Console.WriteLine("Шаги:");

            // Используем цикл while для изменения i и j до достижения целевой разницы
            while (Math.Abs(i5 - j5) >= targetDiff)
            {
                Console.WriteLine($"i: {i5}, j5: {j5}");
                if (i5 < j5)
                {
                    i5++;
                    j5--;
                }
                else
                {
                    i5--;
                    j5++;
                }
            }

            Console.WriteLine($"Финальные значения: i5: {i5}, j5: {j5}");
            Console.ReadKey(); // Чтобы консольное окно не закрывалось сразу после вывода

            
        }
    }
}