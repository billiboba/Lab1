using ClosedXML.Excel;
using System.Globalization;
using System.Text.RegularExpressions;

class Task4
{
    public static List<double> ReadExcelFile(string filePath)
    {
        List<double> data = new();

        try
        {
            // Открываем Excel-файл с помощью библиотеки ClosedXML
            using var workbook = new XLWorkbook(filePath);
            var worksheet = workbook.Worksheet(1); // Открываем первый лист

            // Перебираем все строки на листе
            foreach (var row in worksheet.RowsUsed())
            {
                // Пропускаем первую строку, если это заголовок
                if (row.RowNumber() == 1) continue;

                foreach (var cell in row.CellsUsed())
                {
                    // Преобразуем значение ячейки в строку
                    string value = cell.GetString().Replace(",", ".");

                    // Пробуем преобразовать значение в double
                    if (double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out double result))
                    {
                        data.Add(result);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при чтении Excel файла: {ex.Message}");
        }

        return data;
    }

    // Метод для записи данных в CSV формат
    public static void ConvertToCsv(string excelFilePath, string csvFilePath)
    {
        try
        {
            List<double> data = ReadExcelFile(excelFilePath);

            if (data.Count > 0)
            {
                using StreamWriter writer = new StreamWriter(csvFilePath);

                foreach (double value in data)
                {
                    writer.WriteLine(value.ToString(CultureInfo.InvariantCulture));
                }

                Console.WriteLine("Файл успешно сконвертирован в CSV.");
            }
            else
            {
                Console.WriteLine("Нет данных для записи в CSV.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при конвертации в CSV: {ex.Message}");
        }
    }

    public static double CalculateCorrectedVariance(List<double> data)
    {
        double mean = data.Average();
        double sumOfSquares = data.Sum(x => Math.Pow(x - mean, 2));
        return sumOfSquares / (data.Count - 1);
    }
}