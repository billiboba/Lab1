using Lab2;
using Lab2.Models;
using Lab2.PossibleActions;
using Lab2.Аppearance;

public class Program
{
    public static void Main()
    {
        string filePath = "C:\\Users\\Roman\\Desktop\\valera_state.json";

        Valera valera = Valera.LoadFromFile(filePath);
        IAction goWork = new GoWork();
        IAction lookNature = new LookNature();
        IAction chillHouse = new ChillHouse();
        IAction goBar = new GoBar();
        IAction drinkWithMarginals = new DrinkWithMarginals();
        IAction singInMetro = new SingInMetro();
        IAction sleep = new Sleep();

        bool running = true;
        do
        {
            Display.ViewMenu();
            Display.Centre("Введите число, чтобы продолжить...");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Clear();
                    valera.ViewParametres();
                    Console.Clear();
                    break;
                case "2":
                    bool runningTask2 = true;
                    do
                    {
                        Console.Clear();
                        Display.ViewTasks();
                        string input2 = Console.ReadLine();
                        switch (input2)
                        {
                            case "1":
                                Console.Clear();
                                goWork.PerformAction(valera);
                                break;
                            case "2":
                                Console.Clear();
                                lookNature.PerformAction(valera);
                                break;
                            case "3":
                                Console.Clear();
                                chillHouse.PerformAction(valera);
                                break;
                            case "4":
                                Console.Clear();
                                goBar.PerformAction(valera);
                                break;
                            case "5":
                                Console.Clear();
                                drinkWithMarginals.PerformAction(valera);
                                break;
                            case "6":
                                Console.Clear();
                                singInMetro.PerformAction(valera);
                                break;
                            case "7":
                                Console.Clear();
                                sleep.PerformAction(valera);
                                break;
                            case "8":
                                runningTask2 = false;
                                break;
                        }
                    } while (runningTask2);
                    break;
                case "3":
                    valera.SaveToFile(filePath);
                    Console.WriteLine("Персонаж Валера сохранён!");
                    break;
                case "4":
                    valera = new Valera();
                    Console.WriteLine("Новый персонаж Валера создан!");
                    break;
                case "5":
                    running = false;
                    break;
            }
        }
        while (running);
    }
}
//C:\Users\Roman\Desktop