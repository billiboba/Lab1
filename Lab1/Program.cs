using System;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Lab1;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите название задания: ");
        string task = Console.ReadLine();
        switch (task)
        {
            case "Task1":
                Console.WriteLine("Введите градусы: ");
                double degree = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите шкалу(C,K,F): ");
                string scale = Console.ReadLine();
                Console.WriteLine("Введите шкалу2(C,K,F): ");
                string scale_second = Console.ReadLine();
                Console.WriteLine(Task1.Convertor(degree, scale, scale_second));
                break;
            case "Task2":
                string word = Console.ReadLine();
                bool res = Task2.Polindrom(word);
                Console.WriteLine(res);
                break;
            case "Task3":
                int month = int.Parse(Console.ReadLine());
                Console.WriteLine(Task3.CountOfRabbits(month));
                break;
            case "Task4":
                    string filePath = @"C:\Users\Roman\Desktop\Popul_1897+.csv";
                
                List<double> data = Task4.ReadCsvFile(filePath);

                if (data.Count == 0)
                {
                    Console.WriteLine("Нет данных для анализа.");
                    return;
                }
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("a. Максимум");
                Console.WriteLine("b. Минимум");
                Console.WriteLine("c. Среднее значение");
                Console.WriteLine("d. Исправленная выборочная дисперсия");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "a":
                        double max = data.Max();
                        Console.WriteLine($"Максимум: {max}");
                        break;
                    case "b":
                        double min = data.Min();
                        Console.WriteLine($"Минимум: {min}");
                        break;
                    case "c":
                        double average = data.Average();
                        Console.WriteLine($"Среднее значение: {average}");
                        break;
                    case "d":
                        double variance = Task4.CalculateCorrectedVariance(data);
                        Console.WriteLine($"Исправленная выборочная дисперсия: {variance}");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            break;
        }
    }
}
