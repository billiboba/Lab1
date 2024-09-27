using Lab2.Аppearance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Valera
    {
        public int Health {  get; set; }
        public int Mana { get; set; }
        public int Mood {  get; set; }
        public int Fatigue {  get; set; }
        public double Money { get; set; }

        public Valera()
        {
            Health = 100;
            Mana = 0;
            Mood = 0;
            Fatigue = 0;
            Money = 0;
        }

        public void ViewParametres()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string welcome = "Добро пожаловать! Ты маргинал Валера!";
            Display.Centre(welcome);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            string parametrs = "Твои параметры:";
            Display.Centre(parametrs);
            string parametrs2 = $"Здоровье - {Health}";
            Display.Centre(parametrs2);
            string parametrs3 = $"Мана - {Mana}";
            Display.Centre(parametrs3);
            string parametrs4 = $"Жизнерадостность - {Mood}";
            Display.Centre(parametrs4);
            string parametrs5 = $"Усталость - {Fatigue}";
            Display.Centre(parametrs5);
            string parametrs6 = $"Деньги - {Money}";
            Display.Centre(parametrs6);
            Console.WriteLine("Нажмите пробел, чтобы продолжить...");
            Console.ReadKey();
        }
    }
}
