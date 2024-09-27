using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Аppearance
{
    public class Display
    {
        public static void Centre(string line)
        {
            int windowWidth = Console.WindowWidth;
            int textPosition = (windowWidth - line.Length) / 2;
            Console.SetCursorPosition(textPosition, Console.CursorTop);
            Console.WriteLine(line);
        }
        public static void ViewTasks()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Возможности Валеры: ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Пойти на работу - 1 \nСозерцать природу - 2 \nПить вино и смотреть сериал - 3 \nСходить в бар - 4" +
                "\nВыпить с маргиналами - 5 \nПеть в метро - 6 \nСпать - 7 \nВернуться назад - 8");
        }
        public static void ViewMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Centre("1. Просмотреть параметры Валеры");
            Centre("2. Выполнить событие");
            Centre("3. Сохранить состояние");
            Centre("4. Создать нового персонажа");
            Centre("5. Выйти из игры");
        }
    }
}
