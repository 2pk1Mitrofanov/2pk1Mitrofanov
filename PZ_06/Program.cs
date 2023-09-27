using System;
using System.Linq;

namespace PZ_06
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[10];
            Random random = new Random();

            // Заполняем массив случайными числами в интервале [0..50]
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(51); // Генерируем случайное число от 0 до 50
            }

            // Сортируем первую половину массива по возрастанию
            Array.Sort(array, 0, array.Length / 2);

            // Сортируем вторую половину массива по убыванию
            Array.Sort(array, array.Length / 2, array.Length / 2, Comparer<int>.Create((x, y) => y.CompareTo(x)));

            // Выводим отсортированный массив
            Console.WriteLine("Отсортированный массив:");
            Console.WriteLine(string.Join(" ", array));

            Console.ReadLine();
        }
    }
}
