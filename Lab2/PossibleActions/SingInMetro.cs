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
            valera.Mood += 1;
            valera.Mana += 10;
            valera.Money += 10;
            if ((valera.Mana < 40) || (valera.Mana > 70))
            {
                valera.Money += 60;
            }
            valera.Fatigue += 20;
        }
    }
}
