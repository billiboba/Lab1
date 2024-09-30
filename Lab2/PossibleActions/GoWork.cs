using Lab2.Models;

namespace Lab2.PossibleActions
{
    public class GoWork : IAction
    {
        public void PerformAction(Valera valera)
        {
            string filePath = @"D:\\VisualProects\\Lab1\\Lab2\\PossibleActions\\JsonParametresForActions\\ParametresForActions.json";
            LoadAction loadParameters = new LoadAction();
            ActionParameters parameters = loadParameters.LoadActionParameters(filePath, "GoWork");
            if (parameters == null)
            {
                Console.WriteLine("Не удалось загрузить параметры для GoWork.");
                return;
            }
            bool ok = true;
            if (valera.Mood - parameters.MoodChange < valera.MinMood)
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
            if (valera.Mana < 50 & valera.Fatigue < 10 & ok == true)
            {
                
                valera.Mood -= parameters.MoodChange;
                valera.Mana -= parameters.ManaChange;
                valera.Money += parameters.MoneyChange;
                valera.Fatigue += parameters.FatigueChange;
                Console.Clear();
                Console.WriteLine($"Валера пошел на работу!");
            }
        }
    }
}
