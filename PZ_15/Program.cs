using System;
using System.IO;
using System.Text.RegularExpressions;

namespace PZ_15;

class Program
{
    static void Main()
    {
        Console.Write("Введите полный путь к каталогу: ");
        string directoryPath = Console.ReadLine();

        try
        {
            ListFilesWithLatinNames(directoryPath);
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }

        Console.ReadLine();
    }

    static void ListFilesWithLatinNames(string directoryPath)
    {
        if (!Directory.Exists(directoryPath))
        {
            throw new DirectoryNotFoundException($"Каталог {directoryPath} не существует.");
        }

        Console.WriteLine($"Файлы в каталоге {directoryPath}, имена которых написаны латиницей:");


        string[] files = Directory.GetFiles(directoryPath);


        foreach (string filePath in files)
        {


            try
            {
                string fileName = Path.GetFileName(filePath);


                // Проверка, содержит ли имя файла только латинские символы
                if (IsLatinName(fileName))
                {
                    Console.WriteLine(fileName);
                }
            }


            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при обработке файла: {ex.Message}");
            }
        }
    }

    static bool IsLatinName(string fileName)
    {

        // Регулярное выражение для проверки, содержит ли строка только латинские символы
        Regex regex = new Regex("^[a-zA-Z]+$");

        if (!regex.IsMatch(fileName))
        {
            throw new Exception($"Имя файла {fileName} содержит нелатинские символы.");
        }

        return true;
    }
}
