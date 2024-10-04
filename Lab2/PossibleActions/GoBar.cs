using Lab2.Models;
using Lab2.Аppearance;

namespace Lab2.PossibleActions
{
    public class GoBar : IAction
    {
        public void PerformAction(Valera valera, string filePath)
        {
            LoadAction loadParameters = new LoadAction();
            ActionParameters parameters = loadParameters.LoadActionParameters(filePath, "GoBar");
            if (parameters == null)
            {
                Console.WriteLine("Не удалось загрузить параметры для GoBar.");
                return;
            }
            bool ok = true;
            if (valera.Mana + parameters.ManaChange > valera.MaxMana)
            {
                Console.WriteLine("Нельзя идти в бар, будешь слишком пьян!");
            }
            if (valera.Fatigue + parameters.FatigueChange > valera.MaxFatigue)
            {
                Console.WriteLine("Я устал, надо отдохнуть!");
            }
            if (valera.Health - parameters.HealthChange < valera.MinHealth)
            {
                Console.WriteLine("Нельзя идти в бар, будет отрицательное здоровье!");
            }
            if (valera.Money + parameters.MoneyChange < valera.MinMoney)
            {
                Console.WriteLine("Нельзя идти в бар, у тебя не будет денег!");
            }
            else if (ok == true) {
                valera.Mood += parameters.MoodChange;
                valera.Mana += parameters.ManaChange;
                valera.Fatigue += parameters.FatigueChange;
                valera.Health += parameters.HealthChange;
                valera.Money += parameters.MoneyChange;
                valera.Validate();
                Console.WriteLine("Я сходил в бар!");
                string imagePath = @"C:\Users\info\Desktop\drinking-beer.jpg";

                if (File.Exists(imagePath))
                {
                    Display.DrawImageInConsole(imagePath);
                }
                else
                {
                    Console.WriteLine("Файл не найден!");
                }
            }
        }
    }
}
