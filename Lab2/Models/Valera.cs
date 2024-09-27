using Lab2.Аppearance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Valera
    {
        private int health;
        private int mana;
        private int mood;
        private int fatigue;

        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                    health = 0;
                else if (value >= 100)
                    health = 100;
                else
                    health = value;
            }
        }

        public int Mana
        {
            get { return mana; }
            set
            {
                if (value <= 0)
                    mana = 0;
                else if (value >= 100)
                    mana = 100;
                else
                    mana = value;
            }
        }

        public int Mood
        {
            get { return mood; }
            set
            {
                if (value <= -10)
                    mood = -10;
                else if (value >= 10)
                    mood = 10;
                else
                    mood = value;
            }
        }

        public int Fatigue
        {
            get { return fatigue; }
            set
            {
                if (value <= 0) fatigue = 0;
                else if (value >= 100) fatigue = 100;
                else fatigue = value;
            }
        }
        public double Money { get; set; }

        public Valera()
        {
            Health = 100;
            Mana = 0;
            Mood = 0;
            Fatigue = 0;
            Money = 150;
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
        public void SaveToFile(string filePath)
        {
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText(filePath, json);
            Console.WriteLine("Состояние Валеры сохранено.");
        }
        public static Valera LoadFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                Console.WriteLine("Состояние Валеры загружено.");
                return JsonSerializer.Deserialize<Valera>(json);
            }
            else
            {
                Console.WriteLine("Файл состояния не найден. Создан новый персонаж.");
                return new Valera();
            }
        }
    }
}
