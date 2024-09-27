using Lab2.Models;
using Lab2.PossibleActions;
using Lab2.Аppearance;

public class Program
{
    public static void Main()
    {
        Valera valera = new();
        IAction goWork = new GoWork();
        IAction lookNature = new LookNature();
        IAction chillHouse = new ChillHouse();
        IAction goBar = new GoBar();
        IAction drinkWithMarginals = new DrinkWithMarginals();
        IAction singInMetro = new SingInMetro();
        IAction sleep = new Sleep();

        valera.ViewParametres();
        Console.Clear();
        bool running = true;
        do
        {
            Display.ViewTasks();
            string input = Console.ReadLine();
            switch (input)
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
                    Console.Clear();
                    valera.ViewParametres();
                    Console.Clear ();
                    break;
                case "9":
                    running = false;
                    break;
            }

        }
        while (running);
    }
}
