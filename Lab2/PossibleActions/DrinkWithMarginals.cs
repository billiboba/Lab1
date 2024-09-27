using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Models;

namespace Lab2.PossibleActions
{
    public class DrinkWithMarginals : IAction
    {
        public void PerformAction(Valera valera)
        {
            valera.Mood += 5;
            valera.Health -= 80;
            valera.Mana += 90;
            valera.Fatigue += 80;
            valera.Money -= 150;
            Console.WriteLine("Я выпил с маргиналами!");
        }
    }
}
