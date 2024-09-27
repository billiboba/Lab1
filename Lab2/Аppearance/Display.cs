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
                "\nВыпить с маргиналами - 5 \nПеть в метро - 6 \nСпать - 7 \nПросмотреть параметры - 8 \nЗакончить - 9");
        }
    }
}
