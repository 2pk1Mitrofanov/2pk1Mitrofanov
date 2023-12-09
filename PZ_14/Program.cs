using System;
using System.IO;

namespace PZ_14;
class Program
{
    static void Main()
    {
        string file1Path = "C:\\Users\\1\\Desktop\\f1.txt";
        string file2Path = "C:\\Users\\1\\Desktop\\f2.txt";
        string TempFilePath = "C:\\Users\\1\\Documents\\swap_file.txt";

        try
        {
            SwapFiles(file1Path, file2Path, TempFilePath);
            Console.WriteLine("Содержимые файлов успешно поменяны местами");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
        Console.ReadLine();
    }
    static void SwapFiles(string filePath1, string filePath2, string TempfilePath)
    {
        Console.WriteLine("Начало обмена содержимым 2 файлов...");  // Вывод информации о начале процесса

        if (!File.Exists(filePath1)) // Проверка существования файлов
        {
            throw new FileNotFoundException($"Файл {filePath1} не существует.");
        }

        if (!File.Exists(filePath2))
        {
            throw new FileNotFoundException($"Файл {filePath2} не существует.");
        }

        // Чтение содержимого файла1 и запись во временный файл
        using (StreamReader reader = new StreamReader(filePath1))
        using (StreamWriter tempWriter = new StreamWriter(TempfilePath))
        {
            tempWriter.Write(reader.ReadToEnd());
        }

        // Чтение содержимого файла2 и запись в файл1
        using (StreamReader reader = new StreamReader(filePath2))
        using (StreamWriter writer = new StreamWriter(filePath1))
        {
            writer.Write(reader.ReadToEnd());
        }

        // Чтение временного файла и запись в файл2
        using (StreamReader reader = new StreamReader(TempfilePath))
        using (StreamWriter writer = new StreamWriter(filePath2))
        {
            writer.Write(reader.ReadToEnd());
        }

        // Удаление временного файла
        File.Delete(TempfilePath);

        // Вывод информации об успешном завершении процесса
        Console.WriteLine("Обмен успешен");
    }
} 

