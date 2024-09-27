using Lab1;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        bool running = true;

        do
        {
            
            Console.WriteLine("\nTask1 - 1\nTask2 - 2\nTask3 - 3\nTask4 - 4\nEnd - чтобы закончить");
            Console.Write("\nВведите название задания: ");
            string task = Console.ReadLine();

            switch (task.ToLower())
            {
                case "1":
                    double degree = Task1.GetValidDoubleInput("Введите градусы: ");
                    string scale = Task1.GetValidScaleInput("Введите шкалу (C,K,F): ");
                    string scale_second = Task1.GetValidScaleInput("Введите шкалу 2 (C,K,F): ");

                    Console.WriteLine(Task1.Convertor(degree, scale, scale_second));
                    break;
                case "2":
                    Console.WriteLine("Введите слово: ");
                    string word = Console.ReadLine();
                    bool res = Task2.Polindrom(word);
                    Console.WriteLine(res);
                    break;
                case "3":
                    int month = 0;
                    bool isValidInput = false;
                    while (!isValidInput)
                    {
                        Console.WriteLine("Введите количество месяцев (число): ");
                        string input = Console.ReadLine();
                        if (int.TryParse(input, out month) && month >= 0)
                        {
                            isValidInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: введите число");
                        }
                    }
                    Console.WriteLine(Task3.CountOfRabbits(month));
                    break;
                case "4":
                    string filePath = @"C:\Users\Roman\Desktop\Popul_1897+.xlsx";

                    List<double> data = Task4.ReadExcelFile(filePath);

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
                case "end":  // Условие для завершения программы
                    running = false;
                    break;
                default:
                    Console.WriteLine("Неверный ввод. Попробуйте снова.");
                    break;
            }
        }
        while (running);

    }
}