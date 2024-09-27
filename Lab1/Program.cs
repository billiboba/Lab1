using Lab1;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        do
        {
            Console.WriteLine("Введите название задания: ");
            string task = Console.ReadLine();
            Console.WriteLine("END чтобы закончить");
            switch (task)
            {
                case "Task1":
                    double degree = Task1.GetValidDoubleInput("Введите градусы: ");
                    string scale = Task1.GetValidScaleInput("Введите шкалу(C,K,F): ");
                    string scale_second = Task1.GetValidScaleInput("Введите шкалу2(C,K,F): ");

                    Console.WriteLine(Task1.Convertor(degree, scale, scale_second));
                    break;
                case "Task2":
                    Console.WriteLine("Введите слово: ");
                    string word = Console.ReadLine();
                    bool res = Task2.Polindrom(word);
                    Console.WriteLine(res);
                    break;
                case "Task3":
                    Console.WriteLine("Введите количество месяцев: ");
                    int month = int.Parse(Console.ReadLine());
                    Console.WriteLine(Task3.CountOfRabbits(month));
                    break;
                case "Task4":
                    string filePath = @"C:\Users\info\Desktop\Popul_1897+.csv";

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
        while (true);
    }
}