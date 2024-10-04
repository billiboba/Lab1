using Lab2.Models;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using static System.Net.Mime.MediaTypeNames;
using Image = SixLabors.ImageSharp.Image;
namespace Lab2.Аppearance
{
    public class Display
    {
        public static void Centre(string line)
        {
            int windowWidth = Console.WindowWidth;
            int textPosition = (windowWidth - line.Length) / 2;
            Console.SetCursorPosition(textPosition, Console.CursorTop);
            Console.WriteLine(line);
        }
        public static void ViewTasks()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Возможности Валеры: ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Пойти на работу - 1 \nСозерцать природу - 2 \nПить вино и смотреть сериал - 3 \nСходить в бар - 4" +
                "\nВыпить с маргиналами - 5 \nПеть в метро - 6 \nСпать - 7 \nВернуться назад - 8");
        }
        public static void ViewMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Centre("1. Просмотреть параметры Валеры");
            Centre("2. Выполнить событие");
            Centre("3. Сохранить состояние");
            Centre("4. Создать нового персонажа");
            Centre("5. Выйти из игры");
        }
        public static void ExecuteTaskMenu(Valera valera, IAction goWork, IAction lookNature, IAction chillHouse, IAction goBar, IAction drinkWithMarginals, IAction singInMetro, IAction sleep)
        {
            string filePath = @"C:\Users\info\source\repos\billiboba\Lab1\Lab2\PossibleActions\JsonParametresForActions\ParametresForActions.json";
            LoadAction loadParameters = new LoadAction();
            string[] taskMenuOptions = { "Пойти на работу",
                                 "Созерцать природу",
                                 "Пить вино и смотреть сериал",
                                 "Сходить в бар",
                                 "Выпить с маргиналами",
                                 "Петь в метро",
                                 "Спать",
                                 "Вернуться назад" };
            int selectedTaskOption = 0;

            bool runningTask2 = true;
            do
            {
                Console.Clear();
                for (int i = 0; i < taskMenuOptions.Length; i++)
                {
                    if (i == selectedTaskOption)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Centre("> " + taskMenuOptions[i]);
                        switch(i)
                        {
                            case 0:
                                ActionParameters parameters = loadParameters.LoadActionParameters(filePath, "GoWork");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Centre($"Алкоголь - {parameters.ManaChange}");
                                Centre($"Настроение - {parameters.MoodChange}");
                                Centre($"Деньги - {parameters.MoneyChange}");
                                Centre($"Усталость - {parameters.FatigueChange}");
                                break;
                            case 1:
                                ActionParameters parameters2 = loadParameters.LoadActionParameters(filePath, "LookNature");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Centre($"Алкоголь - {parameters2.ManaChange}");
                                Centre($"Настроение - {parameters2.MoodChange}");
                                Centre($"Усталость - {parameters2.FatigueChange}");
                                break;
                            case 2:
                                ActionParameters parameters3 = loadParameters.LoadActionParameters(filePath, "ChillHouse");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Centre($"Алкоголь - {parameters3.ManaChange}");
                                Centre($"Настроение - {parameters3.MoodChange}");
                                Centre($"Деньги - {parameters3.MoneyChange}");
                                Centre($"Усталость - {parameters3.FatigueChange}");
                                Centre($"Здоровье - {parameters3.HealthChange}");
                                break;
                            case 3:
                                ActionParameters parameters4 = loadParameters.LoadActionParameters(filePath, "GoBar");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Centre($"Алкоголь - {parameters4.ManaChange}");
                                Centre($"Настроение - {parameters4.MoodChange}");
                                Centre($"Деньги - {parameters4.MoneyChange}");
                                Centre($"Здоровье - {parameters4.HealthChange}");
                                Centre($"Усталость - {parameters4.FatigueChange}");
                                break;
                            case 4:
                                ActionParameters parameters5 = loadParameters.LoadActionParameters(filePath, "DrinkWithMarginals");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Centre($"Алкоголь - {parameters5.ManaChange}");
                                Centre($"Настроение - {parameters5.MoodChange}");
                                Centre($"Деньги - {parameters5.MoneyChange}");
                                Centre($"Здоровье - {parameters5.HealthChange}");
                                Centre($"Усталость - {parameters5.FatigueChange}");
                                break;
                            case 5:
                                ActionParameters parameters6 = loadParameters.LoadActionParameters(filePath, "SingInMetro");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Centre($"Алкоголь - {parameters6.ManaChange}");
                                Centre($"Настроение - {parameters6.MoodChange}");
                                Centre($"Деньги - {parameters6.MoneyChange}");
                                Centre($"Усталость - {parameters6.FatigueChange}");
                                break;
                            case 6:
                                ActionParameters parameters7 = loadParameters.LoadActionParameters(filePath, "Sleep");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Centre($"Алкоголь - {parameters7.ManaChange}");
                                Centre($"Настроение - {parameters7.MoodChange}");
                                Centre($"Здоровье - {parameters7.HealthChange}");
                                Centre($"Усталость - {parameters7.FatigueChange}");
                                break;
                        }
                        Console.ResetColor();
                    }
                    else
                    {
                        Centre("  " + taskMenuOptions[i]);
                    }
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (selectedTaskOption > 0)
                            selectedTaskOption--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (selectedTaskOption < taskMenuOptions.Length - 1)
                            selectedTaskOption++;
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch (selectedTaskOption)
                        {
                            case 0:
                                goWork.PerformAction(valera);
                                break;
                            case 1:
                                lookNature.PerformAction(valera);
                                break;
                            case 2:
                                chillHouse.PerformAction(valera);
                                break;
                            case 3:
                                goBar.PerformAction(valera);
                                break;
                            case 4:
                                drinkWithMarginals.PerformAction(valera);
                                break;
                            case 5:
                                singInMetro.PerformAction(valera);
                                break;
                            case 6:
                                sleep.PerformAction(valera);
                                break;
                            case 7:
                                runningTask2 = false;
                                break;
                        }
                        Centre("\nНажмите Enter, чтобы продолжить...");
                        Console.ReadKey(true);
                        break;
                }

            } while (runningTask2);
        }
        public static void SelectAndLoadValera(ref Valera valera)
        {
            string directoryPath = @"C:\Users\info\source\repos\billiboba\Lab1\Lab2\Models\ParametersValera";
            string[] files = Directory.GetFiles(directoryPath, "*.json");

            if (files.Length == 0)
            {
                Console.WriteLine("Файлы не найдены в директории.");
                Console.ReadKey();
                return;
            }
            
            int selectedFileIndex = 0;
            bool selecting = true;

            while (selecting)
            {
                Console.Clear();
                Console.WriteLine("Выберите файл для загрузки Валеры:");

                for (int i = 0; i < files.Length; i++)
                {
                    string fileName = Path.GetFileName(files[i]);
                    if (i == selectedFileIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Display.Centre("> " + fileName);
                        Console.ResetColor();
                    }
                    else
                    {
                        Display.Centre("  " + fileName);
                    }
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (selectedFileIndex > 0)
                            selectedFileIndex--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (selectedFileIndex < files.Length - 1)
                            selectedFileIndex++;
                        break;
                    case ConsoleKey.Enter:
                        string selectedFilePath = files[selectedFileIndex];
                        valera = Valera.LoadFromFile(selectedFilePath);
                        if (valera != null)
                        {
                            Console.WriteLine("Персонаж Валера загружен.");
                            Console.WriteLine($"Здоровье: {valera.Health}");
                            Console.WriteLine($"Мана: {valera.Mana}");
                            Console.WriteLine($"Жизнерадостность: {valera.Mood}");
                            Console.WriteLine($"Усталость: {valera.Fatigue}");
                            Console.WriteLine($"Деньги: {valera.Money}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка при загрузке персонажа.");
                        }
                        Console.ReadKey();
                        selecting = false;
                        break;
                    case ConsoleKey.Escape: 
                        selecting = false;
                        break;
                }
            }
        }
        public static void DrawImageInConsole(string path)
        {
            char[] asciiChars = { '#', 'A', '@', '%', 'S', '+', '<', '*', ':', ',', '.' };

            using (Image<Rgba32> image = Image.Load<Rgba32>(path))
            {

                int width = 50;
                int height = (int)(image.Height * (50.0 / image.Width)) / 2;

                image.Mutate(x => x.Resize(width, height));


                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {

                        Rgba32 pixelColor = image[x, y];


                        int grayValue = (int)((pixelColor.R * 0.3) + (pixelColor.G * 0.59) + (pixelColor.B * 0.11));


                        int charIndex = grayValue * (asciiChars.Length - 1) / 255;
                        Console.Write(asciiChars[charIndex]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
