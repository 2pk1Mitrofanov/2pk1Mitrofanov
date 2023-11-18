namespace PZ_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string maxString = "";

            Console.WriteLine("Введите строки. 'stop' для завершения");

            while (true)
            {
                Console.WriteLine("Введите строку: ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "stop")
                    break;

                if (userInput.Length > maxString.Length)
                    maxString = userInput;
            }

            if (!string.IsNullOrEmpty(maxString))
                Console.WriteLine($"Строка max длинны: {maxString}");
            else
                Console.WriteLine("Ни одной строки не введено");
        }
    }
}