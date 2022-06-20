using System.IO;
using System.Windows;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Task4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveCatalogDataButton_Click(object sender, RoutedEventArgs e)
        {
            var excel = new Excel.Application();
            excel.Visible = true;

            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();

            var path = folderBrowserDialog.SelectedPath;

            if (!Directory.Exists(path))
            {
                System.Windows.MessageBox.Show("Неверный путь");
                return;
            }

            var directoryInfo = new DirectoryInfo(path);
            var files = directoryInfo.GetFiles("*", SearchOption.TopDirectoryOnly);

            var workbook = excel.Workbooks.Add();

            //Заполнение 1 листа
            var worksheet = workbook.Worksheets[1];
            worksheet.Name = "Файлы";

            worksheet.Cells[1, 1].Value = "Номер файла";
            worksheet.Cells[1, 2].Value = "Имя файла";
            worksheet.Cells[1, 3].Value = "Размер файла (КБ)";

            for (int i = 0; i < files.Length; i++)
            {
                worksheet.Cells[i + 2, 1].Value = i + 1;
                worksheet.Cells[i + 2, 2].Value = files[i].Name;
                worksheet.Cells[i + 2, 3].Value = files[i].Length / 1024;
            }

            worksheet.Cells[files.Length + 3, 1] = $"Общий размер (МБ): ";
            worksheet.Cells[files.Length + 3, 2] = $"=SUM(C2:C{files.Length + 1}) / 1024";

            worksheet.Columns.AutoFit();

            //Заполнение 2 листа
            var worksheet2 = workbook.Worksheets.Add(After: worksheet);
            worksheet2.Name = "Подпапки";

            worksheet2.Cells[1, 1].Value = "Номер подпапки";
            worksheet2.Cells[1, 2].Value = "Имя подпапки";

            var folders = directoryInfo.GetDirectories("*", SearchOption.TopDirectoryOnly);

            for (int i = 0; i < folders.Length; i++)
            {
                worksheet2.Cells[i + 2, 1].Value = i + 1;
                worksheet2.Cells[i + 2, 2].Value = folders[i].Name;
            }

            worksheet2.Columns.AutoFit();

        }
    }
}
