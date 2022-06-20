using System.Drawing;
using System.Windows;
using Excel = Microsoft.Office.Interop.Excel;

namespace Task1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var excel = new Excel.Application();
            excel.Visible = true;

            var workbook = excel.Workbooks.Add();
            var worksheet = workbook.Worksheets[1];
            worksheet.Name = "Умножение";

            int xOffset = 3, yOffset = 9;

            //Создание таблицы
            for (int i = 1; i <= 9; i++)a
            {
                for (int j = 1; j <= 9; j++)
                {
                    worksheet.Cells[i + yOffset, j + xOffset].Value = i * j;
                }
            }
            var cell = $"{(char)('A' + xOffset)}{yOffset + 1}";
            worksheet.Range($"{cell}:{cell}").Clear();

            //Настройка шрифта
            var tableHeader = worksheet.range[worksheet.Cells[xOffset + 1][yOffset], worksheet.Cells[xOffset + 9][yOffset]];
            tableHeader.Merge();

            var tableHeaderCell = worksheet.Cells[yOffset, xOffset + 1];
            tableHeaderCell.Value = "Таблица умножения";
            tableHeaderCell.Font.Italic = true;
            tableHeaderCell.Font.Bold = true;
            tableHeaderCell.Font.Size = 20;
            tableHeaderCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            var table = worksheet.range[worksheet.Cells[xOffset + 1][yOffset + 1], worksheet.Cells[xOffset + 9][yOffset + 9]];
            table.Font.Size = 15;

            //Настройка цвета
            var multipliersRowRange = worksheet.range[worksheet.Cells[xOffset + 2][yOffset + 1], worksheet.Cells[xOffset + 9][yOffset]];
            var multipliersColumnRange = worksheet.range[worksheet.Cells[xOffset + 1][yOffset + 2], worksheet.Cells[xOffset + 1][yOffset + 9]];

            var foregroundColor = ColorTranslator.ToOle(Color.Snow);
            var backgroundColor = ColorTranslator.ToOle(Color.MediumBlue);

            multipliersRowRange.Font.Color = foregroundColor;
            multipliersRowRange.Interior.Color = backgroundColor;
            multipliersColumnRange.Font.Color = foregroundColor;
            multipliersColumnRange.Interior.Color = backgroundColor;

            //Настройка границ
            table.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
        }
    }
}
