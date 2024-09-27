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
            bool ok = true;
            if (valera.Mood + 5 > 10)
            {
                Console.WriteLine("Настроение выше некуда!");
            }
            else if (valera.Health - 80 < 0)
            {
                Console.WriteLine("Нельзя идти пить с маргиналами, будет отрицательное здоровье!");
            }
            else if (valera.Mana + 90 > 100)
            {
                Console.WriteLine("Нельзя идти пить с маргиналами, будешь слишком пьян!");
            }
            else if (valera.Fatigue + 80 > 100)
            {
                Console.WriteLine("Нельзя идти пить с маргиналами, будет сильная усталость!");
            }
            else if (valera.Money - 150 < 0)
            {
                Console.WriteLine("Нельзя идти пить с маргиналами, у тебя не будет денег!");
            }
            else if (ok == true)
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
}
