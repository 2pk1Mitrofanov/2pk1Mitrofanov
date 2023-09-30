namespace PZ_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Random random = new Random();

                // Генерация случайной длины второго измерения в диапазоне от 6 до 15
                int length2 = random.Next(6, 16);

                // Создание ступенчатого массива символов
                char[][] charArray = new char[5][];

                // Заполнение массива случайными буквами английского алфавита
                for (int i = 0; i < 5; i++)
                {
                    charArray[i] = new char[length2];
                    for (int j = 0; j < length2; j++)
                    {
                        // Генерация случайной буквы английского алфавита
                        char randomChar = (char)('A' + random.Next(0, 26));
                        charArray[i][j] = randomChar;
                    }
                }

                // Вывод ступенчатого массива
                Console.WriteLine("Ступенчатый массив символов:");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(string.Join(" ", charArray[i]));
                }

                // Создание одномерного массива и запись последних элементов каждой строки
                char[] lastElements = new char[5];
                for (int i = 0; i < 5; i++)
                {
                    lastElements[i] = charArray[i][charArray[i].Length - 1];
                }

                // Вывод одномерного массива
                Console.WriteLine("Последние элементы каждой строки:");
                Console.WriteLine(string.Join(" ", lastElements));

                // Нахождение и вывод максимальных элементов в каждой строке
                char[] maxElements = new char[5];
                for (int i = 0; i < 5; i++)
                {
                    char maxChar = charArray[i][0];
                    for (int j = 1; j < length2; j++)
                    {
                        if (charArray[i][j] > maxChar)
                        {
                            maxChar = charArray[i][j];
                        }
                    }
                    maxElements[i] = maxChar;
                }

                // Вывод массива максимальных элементов
                Console.WriteLine("Максимальные элементы в каждой строке:");
                Console.WriteLine(string.Join(" ", maxElements));

                // Обновление массива: замена первого элемента и максимального элемента в строке
                for (int i = 0; i < 5; i++)
                {
                    char temp = charArray[i][0];
                    charArray[i][0] = maxElements[i];
                    charArray[i][Array.IndexOf(charArray[i], maxElements[i])] = temp;
                }

                // Вывод обновленного ступенчатого массива
                Console.WriteLine("Обновленный массив после замены элементов:");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(string.Join(" ", charArray[i]));
                }

                // Реверс каждой строки ступенчатого массива
                for (int i = 0; i < 5; i++)
                {
                    Array.Reverse(charArray[i]);
                }

                // Вывод реверсированного ступенчатого массива
                Console.WriteLine("Реверсированный массив:");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(string.Join(" ", charArray[i]));
                }

                // Поиск и вывод наиболее встречающихся символов в каждой строке
                Console.WriteLine("Наиболее встречающиеся символы в каждой строке:");
                for (int i = 0; i < 5; i++)
                {
                    char mostFrequent = charArray[i]
                                            .GroupBy(c => c)
                                            .OrderByDescending(c => c.Count())
                                            .First()
                                            .Key;
                    Console.WriteLine($"Строка {i + 1}: {mostFrequent}");
                }
        }

    }
}

