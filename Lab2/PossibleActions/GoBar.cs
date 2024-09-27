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
            valera.Mood += 1;
            valera.Mana += 60;
            valera.Fatigue += 40;
            valera.Health -= 10;
            valera.Money -= 100;
            Console.WriteLine("Я сходил в бар!");
        }
    }
}
