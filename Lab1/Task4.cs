using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Task4
{
    public static List<double> ReadCsvFile(string filePath)
    {
        List<double> data = new List<double>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isFirstRow = true;
                Regex regex = new Regex(@"\d+([.,]\d+)?");

                while ((line = reader.ReadLine()) != null)
                {
                    if (isFirstRow)
                    {
                        isFirstRow = false;
                        continue;
                    }
                    MatchCollection matches = regex.Matches(line);

                    foreach (Match match in matches)
                    {
                        string value = match.Value.Replace(",", ".");

                        if (double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out double result))
                        {
                            data.Add(result);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
        }

        return data;
    }
    public static double CalculateCorrectedVariance(List<double> data)
    {
        double mean = data.Average();
        double sumOfSquares = data.Sum(x => Math.Pow(x - mean, 2));
        return sumOfSquares / (data.Count - 1); // n-1 для исправленной выборочной дисперсии
    }
}