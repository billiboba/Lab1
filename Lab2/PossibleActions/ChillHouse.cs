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
            bool ok = true;
            if (valera.Mood - 1 < 10)
            {
                Console.WriteLine("Нельзя идти пить вино и смотреть сериал, будет отрицательное настроение!");
            }
            else if (valera.Mana + 30 > 100)
            {
                Console.WriteLine("Нельзя идти пить вино и смотреть сериал, будешь слишком пьян!");
            }
            else if (valera.Health - 5 < 0)
            {
                Console.WriteLine("Нельзя идти пить вино и смотреть сериал, будет отрицательное здоровье!");
            }
            else if (valera.Money - 20 < 0)
            {
                Console.WriteLine("Нельзя идти пить вино и смотреть сериал, у тебя не будет денег!");
            }
            else if(ok == true) 
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
}
