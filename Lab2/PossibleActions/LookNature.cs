using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Models;

namespace Lab2.PossibleActions
{
    public class LookNature : IAction
    {
        public void PerformAction(Valera valera)
        {
            valera.Mood += 1;
            valera.Mana -= 10;
            valera.Fatigue += 10;
            Console.WriteLine("Валера пошёл созерцать природу!");
        }
    }
}
