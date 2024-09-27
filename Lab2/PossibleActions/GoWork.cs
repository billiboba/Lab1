using Lab2.Models;

namespace Lab2.PossibleActions
{
    public class GoWork : IAction
    {
        public void PerformAction(Valera valera)
        {
            if (valera.Mana < 50 & valera.Fatigue < 10)
            {
                valera.Mood -= 5;
                valera.Mana -= 30;
                valera.Money += 100;
                valera.Fatigue += 70;
                Console.Clear();
                Console.WriteLine($"Валера пошел на работу!");
            }
            else if (valera.Mana > 50)
            {
                Console.Clear();
                Console.WriteLine("Я пьяный!");
            }
            else if(valera.Fatigue > 10) 
            {
                Console.Clear();
                Console.WriteLine("Я устал!");
            }
        }
    }
}
