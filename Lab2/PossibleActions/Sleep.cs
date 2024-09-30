using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Models;

namespace Lab2.PossibleActions
{
    public class Sleep : IAction
    {
        public void PerformAction(Valera valera)
        {
            string filePath = @"D:\\VisualProects\\Lab1\\Lab2\\PossibleActions\\JsonParametresForActions\\ParametresForActions.json";
            LoadAction loadParameters = new LoadAction();
            ActionParameters parameters = loadParameters.LoadActionParameters(filePath, "Sleep");
            if (parameters == null)
            {
                Console.WriteLine("Не удалось загрузить параметры для Sleep.");
                return;
            }
            bool ok = true;
            if(ok == true) 
            {
                if (valera.Mana < 30)
                {
                    valera.Health += parameters.HealthChange;
                }
                if (valera.Mana > 70)
                {
                    valera.Mood -= parameters.MoodChange;
                }
                valera.Mana -= parameters.ManaChange;
                valera.Fatigue -= parameters.FatigueChange;
                Console.WriteLine("Ты выспался!");
            }
            
        }
    }
}
