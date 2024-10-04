using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Models;
namespace Lab2.PossibleActions
{
    public class ChillHouse : IAction
    {
        public void PerformAction(Valera valera,string filePath)
        {
            LoadAction loadParameters = new LoadAction();
            ActionParameters parameters = loadParameters.LoadActionParameters(filePath, "ChillHouse");
            if (parameters == null)
            {
                Console.WriteLine("Не удалось загрузить параметры для ChillHouse.");
                return;
            }
            bool ok = true;
            if (valera.Mood + parameters.MoodChange < valera.MinMood)
            {
                Console.WriteLine("Нельзя идти пить вино и смотреть сериал, будет отрицательное настроение!");
            }
            else if (valera.Mana + parameters.ManaChange > valera.MaxMana)
            {
                Console.WriteLine("Нельзя идти пить вино и смотреть сериал, будешь слишком пьян!");
            }
            else if (valera.Health + parameters.HealthChange < valera.MinHealth)
            {
                Console.WriteLine("Нельзя идти пить вино и смотреть сериал, будет отрицательное здоровье!");
            }
            else if (valera.Money + parameters.MoneyChange < valera.MinMoney)
            {
                Console.WriteLine("Нельзя идти пить вино и смотреть сериал, у тебя не будет денег!");
            }
            else if (ok == true)
            {
                valera.Mood += parameters.MoodChange;
                valera.Mana += parameters.ManaChange;
                valera.Fatigue += parameters.FatigueChange;
                valera.Health += parameters.HealthChange;
                valera.Money += parameters.MoneyChange;
                valera.Validate();
                Console.WriteLine("Валера пьёт вино и смотрит сериал!");
            }
        }
    }
}
