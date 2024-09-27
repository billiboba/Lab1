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
            bool ok = true;
            if(valera.Mood + 1 > 10)
            {
                Console.WriteLine("Настроение максимальное!");
            }
            else if (valera.Mana - 10 < 0)
            {
                Console.WriteLine("Ты протрезвел!");
            }
            else if (valera.Fatigue + 10 > 100)
            {
                Console.WriteLine("Усталость максимальная, отдохни!");
            }
            else if (ok == true)
            {
                valera.Mood += 1;
                valera.Mana -= 10;
                valera.Fatigue += 10;
                Console.WriteLine("Валера пошёл созерцать природу!");
            }
            
        }
    }
}
