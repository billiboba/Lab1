using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Models;

namespace Lab2.PossibleActions
{
    public class SingInMetro : IAction
    {
        public void PerformAction(Valera valera)
        {
            string filePath = @"D:\\VisualProects\\Lab1\\Lab2\\PossibleActions\\JsonParametresForActions\\ParametresForActions.json";
            LoadAction loadParameters = new LoadAction();
            ActionParameters parameters = loadParameters.LoadActionParameters(filePath, "SingInMetro");
            if (parameters == null)
            {
                Console.WriteLine("Не удалось загрузить параметры для SingInMetro.");
                return;
            }
            bool ok = true;
            if (valera.Mana + parameters.ManaChange > valera.MaxMana)
            {
                Console.WriteLine("Нельзя идти петь в метро, будешь слишком пьян!");
            }
            else if(ok == true)
            {
                valera.Mood += parameters.MoodChange;
                valera.Mana += parameters.ManaChange;
                valera.Money += parameters.MoneyChange;
                if ((valera.Mana < 40) || (valera.Mana > 70))
                {
                    valera.Money += parameters.MoneyChange;
                }
                valera.Fatigue += parameters.FatigueChange;
                Console.WriteLine("Ты спел в метро!");
            }
        }
    }
}
