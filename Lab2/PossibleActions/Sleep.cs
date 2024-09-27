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
            bool ok = true;
            if(ok == true) 
            {
                if (valera.Mana < 30)
                {
                    valera.Health += 90;
                }
                if (valera.Mana > 70)
                {
                    valera.Mood -= 3;
                }
                valera.Mana -= 50;
                valera.Fatigue -= 70;
                Console.WriteLine("Ты выспался!");
            }
            
        }
    }
}
