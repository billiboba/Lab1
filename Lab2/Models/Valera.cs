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
        // Границы для параметров
        public int MinHealth { get; set; }
        public int MaxHealth { get; set; }
        public int MinMana { get; set; }
        public int MaxMana { get; set; }
        public int MinMood { get; set; }
        public int MaxMood { get; set; }
        public int MinFatigue { get; set; }
        public int MaxFatigue { get; set; }

        // Параметры Валеры
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Mood { get; set; }
        public int Fatigue { get; set; }
        public double Money { get; set; }

        public void Validate()
        {
            Health = Math.Clamp(Health, MinHealth, MaxHealth);
            Mana = Math.Clamp(Mana, MinMana, MaxMana);
            Mood = Math.Clamp(Mood, MinMood, MaxMood);
            Fatigue = Math.Clamp(Fatigue, MinFatigue, MaxFatigue);
        }
        public Valera()
        {
        }

        public void ViewParametres()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Display.Centre("Добро пожаловать! Ты маргинал Валера!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Display.Centre("Твои параметры:");
            Display.Centre($"Здоровье - {Health}");
            Display.Centre($"Мана - {Mana}");
            Display.Centre($"Жизнерадостность - {Mood}");
            Display.Centre($"Усталость - {Fatigue}");
            Display.Centre($"Деньги - {Money}");
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
                Valera valera = JsonSerializer.Deserialize<Valera>(json);

                valera.Validate();

                Console.WriteLine("Состояние Валеры загружено из файла.");
                return valera;
            }
            else
            {
                Console.WriteLine("Файл состояния не найден. Создан новый персонаж.");
                return new Valera();
            }
        }
    }
}
