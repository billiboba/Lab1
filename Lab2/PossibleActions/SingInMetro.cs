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
            bool ok = true;
            if (valera.Mood + 1 > 10)
            {
                Console.WriteLine("Будет максимальное настроение!");
            }
            else if (valera.Mana + 10 > 100)
            {
                Console.WriteLine("Нельзя идти петь в метро, будешь слишком пьян!");
            }
            else if(ok == true)
            {
                valera.Mood += 1;
                valera.Mana += 10;
                valera.Money += 10;
                if ((valera.Mana < 40) || (valera.Mana > 70))
                {
                    valera.Money += 50;
                }
                valera.Fatigue += 20;
                Console.WriteLine("Ты спел в метро!");
            }
            
        }
    }
}
