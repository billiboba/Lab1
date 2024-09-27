using System.Text.RegularExpressions;

namespace Lab1
{
    public class Task1
    {
        public static double Convertor(double degree, string scale, string scale_second)
        {
            switch (scale)
            {
                case "C":
                    if (scale == scale_second)
                    {
                        return degree;
                    }
                    else if (scale_second == "K")
                    {
                        return degree + 273.15;
                    }
                    else if (scale_second == "F")
                    {
                        return degree * 9 / 5 + 32;
                    }
                    break;
                case "K":
                    if (scale == scale_second)
                    {
                        return degree;
                    }
                    else if (scale_second == "C")
                    {
                        return degree - 273.15;
                    }
                    else if (scale_second == "F")
                    {
                        return degree * 9 / 5 - 459.67;
                    }
                    break;
                case "F":
                    if (scale == scale_second)
                    {
                        return degree;
                    }
                    else if (scale_second == "C")
                    {
                        return (degree - 32) * 5 / 9;
                    }
                    else if (scale_second == "K")
                    {
                        return (degree + 459.67) * 5 / 9;
                    }
                    break;
            }
            return 0;
        }
        public static double GetValidDoubleInput(string message)
        {
            double result = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (double.TryParse(input, out result))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Ошибка: введите числовое значение.");
                }
            }

            return result;
        }

        public static string GetValidScaleInput(string message)
        {
            string result = null;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.WriteLine(message);
                result = Console.ReadLine().ToUpper();

                if (Regex.IsMatch(result, @"\d"))
                {
                    Console.WriteLine("Ошибка: введите значения C,K,F");
                    switch(result)
                    {
                        case "C":
                            continue;
                        case "K":
                            continue;
                        case "F":
                        default:
                            break;
                    }
                }
                else
                {
                    isValidInput = true;
                }
            }

            return result;
        }
    }
}
