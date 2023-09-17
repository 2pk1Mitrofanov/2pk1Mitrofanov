namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число i (1 < i < 365): ");
            int i = int.Parse(Console.ReadLine());

            if (i >= 1 && i < 365)
            {
                int DayOfWeek = (i - 1) % 7;

                switch (DayOfWeek)
                {
                    case 0:
                        Console.WriteLine("Понедельник");
                        break;
                    case 1:
                        Console.WriteLine("Вторник");
                        break;
                    case 2:
                        Console.WriteLine("Среда");
                        break;
                    case 3:
                        Console.WriteLine("Четверг");
                        break;
                    case 4:
                        Console.WriteLine("Пятница");
                        break;
                    case 5:
                        Console.WriteLine("Суббота");
                        break;
                    case 6:
                        Console.WriteLine("Воскресенье");
                        break;
                    default:
                        Console.WriteLine("Некорректное значение i.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Значение i должно быть в диапазоне от 2 до 364");
            }
        }
    }
}