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
            bool ok = true;
            if (valera.Mood + 1 > 10)
            {
                Console.WriteLine("Будет максимальное настроение!");
            }
            else if (valera.Mana + 60 > 100)
            {
                Console.WriteLine("Нельзя идти в бар, будешь слишком пьян!");
            }
            else if (valera.Fatigue + 40 > 100)
            {
                Console.WriteLine("Я устал, надо отдохнуть!");
            }
            else if (valera.Health - 10 < 0)
            {
                Console.WriteLine("Нельзя идти в бар, будет отрицательное здоровье!");
            }
            else if (valera.Money - 100 < 0)
            {
                Console.WriteLine("Нельзя идти в бар, у тебя не будет денег!");
            }
            else if(ok == true) {
                valera.Mood += 1;
                valera.Mana += 60;
                valera.Fatigue += 40;
                valera.Health -= 10;
                valera.Money -= 100;
                Console.WriteLine("Я сходил в бар!");
            }
        }
    }
}
