namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a: "); //Ввод переменной а
            double a = Convert.ToDouble(Console.ReadLine()); //Сохранение значения a
            double b = Math.PI / 2;
            Console.WriteLine("Введите c: "); //Ввод переменной c
            double c = Convert.ToDouble(Console.ReadLine()); //Сохранение значения c



            double result1 = Math.Sqrt(a * b * c / 2.4); //Вычисление первого корня
            double result2 = (0.7 * a * b * c / Math.Sin(b)); //Вычисление второго корня
            double result3 = Math.Pow(10, 4) * Math.Pow(Math.Sqrt(Math.Abs(Math.Cos(b))), 5); //Вычисление следующего выражения
            double result4 = (Math.Abs(b - a) / 7.5); // Вычисление следующей дроби
            double result = result1 - result2 + result3 - result4; // Вычисление итогового ответа
            Console.WriteLine("Итоговый результат:" + result); //Ответ
        }
    }
}