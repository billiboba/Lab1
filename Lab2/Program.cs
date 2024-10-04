using Lab2;
using Lab2.Models;
using Lab2.PossibleActions;
using Lab2.Аppearance;

public class Program
{
    public static void Main()
    {
        string filePath = @"C:\Users\info\source\repos\billiboba\Lab1\Lab2\Models\ParametersValera\Valera_Par.json";

        Valera valera = Valera.LoadFromFile(filePath);
        if (valera != null)
        {
            Console.WriteLine($"Здоровье: {valera.Health}");
            Console.WriteLine($"Мана: {valera.Mana}");
            Console.WriteLine($"Жизнерадостность: {valera.Mood}");
            Console.WriteLine($"Усталость: {valera.Fatigue}");
            Console.WriteLine($"Деньги: {valera.Money}");
        }

        IAction goWork = new GoWork();
        IAction lookNature = new LookNature();
        IAction chillHouse = new ChillHouse();
        IAction goBar = new GoBar();
        IAction drinkWithMarginals = new DrinkWithMarginals();
        IAction singInMetro = new SingInMetro();
        IAction sleep = new Sleep();

        string[] mainMenuOptions = { "Показать параметры Валеры", "Выполнить событие", "Сохранить Валеру", "Создать нового Валеру", "Загрузить Валеру", "Выйти из игры" };
        int selectedOption = 0;

        bool running = true;
        do
        {
            Console.Clear();
            for (int i = 0; i < mainMenuOptions.Length; i++)
            {
                if (i == selectedOption)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Display.Centre("> " + mainMenuOptions[i]);
                    Console.ResetColor();
                }
                else
                {
                    Display.Centre("  " + mainMenuOptions[i]);
                }
            }
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (selectedOption > 0)
                        selectedOption--;
                    break;
                case ConsoleKey.DownArrow:
                    if (selectedOption < mainMenuOptions.Length - 1)
                        selectedOption++;
                    break;
                case ConsoleKey.Enter:
                    switch (selectedOption)
                    {
                        case 0:
                            Console.Clear();
                            valera.ViewParametres();
                            Console.ReadKey();
                            break;
                        case 1:
                            Display.ExecuteTaskMenu(valera, goWork, lookNature, chillHouse, goBar, drinkWithMarginals, singInMetro, sleep);
                            break;
                        case 2:
                            valera.SaveToFile(filePath);
                            Console.WriteLine("Персонаж Валера сохранён!");
                            Console.ReadKey();
                            break;
                        case 3:
                            valera = new Valera();
                            Console.WriteLine("Новый персонаж Валера создан!");
                            Console.ReadKey();
                            break;
                        case 4:
                            Display.SelectAndLoadValera(ref valera);
                            break;
                        case 5:
                            running = false;
                            break;
                    }
                    break;
            }
        } while (running);
    }
}
