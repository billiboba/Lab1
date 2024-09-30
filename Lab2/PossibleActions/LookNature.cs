using Lab2.Models;

namespace Lab2.PossibleActions
{
    public class LookNature : IAction
    {
        public void PerformAction(Valera valera)
        {
            string filePath = @"D:\\VisualProects\\Lab1\\Lab2\\PossibleActions\\JsonParametresForActions\\ParametresForActions.json";
            LoadAction loadParameters = new LoadAction();
            ActionParameters parameters = loadParameters.LoadActionParameters(filePath, "LookNature");
            if (parameters == null)
            {
                Console.WriteLine("Не удалось загрузить параметры для LookNature.");
                return;
            }
            bool ok = true;
            if (valera.Fatigue + parameters.FatigueChange > valera.MaxFatigue)
            {
                Console.WriteLine("Усталость максимальная, отдохни!");
            }
            else if (ok == true)
            {
                valera.Mood += parameters.MoodChange;
                valera.Mana -= parameters.ManaChange;
                valera.Fatigue += parameters.FatigueChange;
                Console.WriteLine("Валера пошёл созерцать природу!");
            }
            
        }
    }
}
