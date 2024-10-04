using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Models;
using Lab2.Аppearance;

namespace Lab2.PossibleActions
{
    public class DrinkWithMarginals : IAction
    {
        public void PerformAction(Valera valera, string filePath)
        {
            LoadAction loadParameters = new LoadAction();
            ActionParameters parameters = loadParameters.LoadActionParameters(filePath, "DrinkWithMarginals");
            if (parameters == null)
            {
                Console.WriteLine("Не удалось загрузить параметры для DrinkWithMarginals.");
                return;
            }
            bool ok = true;
            if (valera.Health - parameters.HealthChange < valera.MinHealth)
            {
                Console.WriteLine("Нельзя идти пить с маргиналами, будет отрицательное здоровье!");
            }
            else if (valera.Mana + parameters.ManaChange > valera.MaxMana)
            {
                Console.WriteLine("Нельзя идти пить с маргиналами, будешь слишком пьян!");
            }
            else if (valera.Fatigue + parameters.FatigueChange > valera.MaxFatigue)
            {
                Console.WriteLine("Нельзя идти пить с маргиналами, будет сильная усталость!");
            }
            else if (valera.Money + parameters.MoneyChange < valera.MinMoney)
            {
                Console.WriteLine("Нельзя идти пить с маргиналами, у тебя не будет денег!");
            }
            else if (ok == true)
            {
                valera.Mood += parameters.MoodChange;
                valera.Health += parameters.HealthChange;
                valera.Mana += parameters.ManaChange;
                valera.Fatigue += parameters.FatigueChange;
                valera.Money += parameters.MoneyChange;
                valera.Validate();
                Console.WriteLine("Я выпил с маргиналами!");
                string imagePath = @"C:\Users\info\Desktop\маргиналы.jpg";

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
