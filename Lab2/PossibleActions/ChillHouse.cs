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
        public void PerformAction(Valera valera)
        {
            valera.Mood -= 1;
            valera.Mana += 30;
            valera.Fatigue -= 10;
            valera.Health -= 5;
            valera.Money -= 20;
            Console.WriteLine("Валера пьёт вино и смотрит сериал!");
        }
        
    }
}
