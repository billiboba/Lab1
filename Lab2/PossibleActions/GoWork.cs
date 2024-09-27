using Lab2.Models;

namespace Lab2.PossibleActions
{
    public class GoWork : IAction
    {
        public void PerformAction(Valera valera)
        {
            bool ok = true;
            if (valera.Mood - 5 < 10)
            {
                Console.WriteLine("Настроение будет отрицательное!");
            }
            else if (valera.Mana > 50)
            {
                Console.WriteLine("Я пьяный!");
            }
            else if (valera.Fatigue > 10)
            {
                Console.WriteLine("Я устал, надо отдохнуть!");
            }
            if (ok == true & valera.Mana < 50 & valera.Fatigue < 10)
            {
                valera.Mood -= 5;
                valera.Mana -= 30;
                valera.Money += 100;
                valera.Fatigue += 70;
                Console.Clear();
                Console.WriteLine($"Валера пошел на работу!");
            }
            
        }
    }
}
