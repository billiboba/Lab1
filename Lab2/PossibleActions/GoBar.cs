using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Models;

namespace Lab2.PossibleActions
{
    public class GoBar : IAction
    {
        public void PerformAction(Valera valera)
        {
            string filePath = @"D:\\VisualProects\\Lab1\\Lab2\\PossibleActions\\JsonParametresForActions\\ParametresForActions.json";
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
            else if (valera.Fatigue + parameters.FatigueChange > valera.MaxFatigue)
            {
                Console.WriteLine("Я устал, надо отдохнуть!");
            }
            else if (valera.Health - parameters.HealthChange < valera.MinHealth)
            {
                Console.WriteLine("Нельзя идти в бар, будет отрицательное здоровье!");
            }
            else if (valera.Money - parameters.MoneyChange < 0)
            {
                Console.WriteLine("Нельзя идти в бар, у тебя не будет денег!");
            }
            else if(ok == true) {
                valera.Mood += parameters.MoodChange;
                valera.Mana += parameters.ManaChange;
                valera.Fatigue += parameters.FatigueChange;
                valera.Health -= parameters.HealthChange;
                valera.Money -= parameters.MoneyChange;
                Console.WriteLine("Я сходил в бар!");
            }
        }
    }
}
