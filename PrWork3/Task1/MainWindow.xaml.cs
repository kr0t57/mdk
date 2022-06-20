using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using Word = Microsoft.Office.Interop.Word;

namespace Task1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            var word = new Word.Application();
            word.Visible = true;


            var path = System.IO.Path.Combine(Environment.CurrentDirectory, @"..\..\template.docx");
            var document = word.Documents.Add(path);

            ReplaceText(document, "%номер", numberTextBox.Text);
            ReplaceText(document, "%название", titleTextBox.Text);
            ReplaceText(document, "%текстЗадания", textTextBox.Text);

            int.TryParse(countOfOptionsTextBox.Text, out var optionsCount);

            var table = document.Tables[1];

            for (var i = 1; i <= optionsCount; i++)
            {
                table.Rows.Add();
                table.Rows[i + 1].Cells[1].Range.Text = i.ToString();
            }

            var saveFileDailog = new SaveFileDialog();
            saveFileDailog.Filter = "Word | *.docx | PDF | *.pdf";
            saveFileDailog.ShowDialog();

            var selectedpath = saveFileDailog.FileName;
            var extension = selectedpath.Split('.').Last();
            var format = extension == "pdf" ? Word.WdSaveFormat.wdFormatPDF : Word.WdSaveFormat.wdFormatDocument;

            if (string.IsNullOrEmpty(selectedpath))
            {
                MessageBox.Show("Некорректный путь");
                return;
            }

            document.SaveAs2(selectedpath, format);
        }

        private void CreateNewButton_Click(object sender, RoutedEventArgs e)
        {
            var word = new Word.Application();
            word.Visible = true;

            var document = word.Documents.Add();
            var paragraphForImage = document.Paragraphs.Add();
            var imageRange = paragraphForImage.Range;

            var paragraphForHeader = document.Paragraphs.Add();
            var headerRange = paragraphForHeader.Range;
            headerRange.Text = new StringBuilder()
                .AppendLine($"Практическая работа №{numberTextBox.Text}")
                .AppendLine($"{titleTextBox.Text}\n")
                .ToString();
            var paragraphForText = document.Paragraphs.Add();
            var textRange = paragraphForText.Range;
            textRange.Text = new StringBuilder()
                .AppendLine($"Задание:\n{textTextBox.Text}\n")
                .AppendLine("Требуется выполнить задание по вариантам в таблице 1.\n")
                .AppendLine("Таблица 1 — Варианты задания")
                .ToString();

            //Настройка оформления
            headerRange.Font.Name = "Times New Roman";
            headerRange.Font.Size = 16;
            headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            textRange.Font.Name = "Times New Roman";
            textRange.Font.Size = 14;

            //Добавление таблицы
            var paragraphForTable = document.Paragraphs.Add();
            var tableRange = paragraphForTable.Range;
            var countOfOptions = int.Parse(countOfOptionsTextBox.Text);

            var table = tableRange.Tables.Add(tableRange, countOfOptions + 1, 2);
            table.Borders.Enable = 1;
            table.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            var numberCellHeaderRange = table.Cell(1, 1).Range;
            var taskCellHeaderRange = table.Cell(1, 2).Range;

            numberCellHeaderRange.Text = "№";
            numberCellHeaderRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            taskCellHeaderRange.Text = "Описание варианта";
            taskCellHeaderRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            for (int i = 1; i <= table.Columns.Count; i++)
            {
                for (int j = 2; j <= table.Rows.Count; j++)
                {
                    var cell = table.Cell(j, i);

                    if (i == 1)
                    {
                        cell.Range.Text = $"{j - 1}";
                    }
                }
            }

            var paragraphForDate = document.Paragraphs.Add();
            paragraphForDate.Range.InsertDateTime();

            //Создание картинки
            var imagePath = System.IO.Path.Combine(Environment.CurrentDirectory, @"..\..\image.png");
            imageRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            var imageShape = imageRange.InlineShapes.AddPicture(imagePath);
            imageShape.Height = 50;
            imageShape.Width = 50;
        }

        private void ReplaceText(Word.Document document, string textForReplace, string text)
        {
            const int size = 200;
            var countOfEntries = Convert.ToInt32(Math.Ceiling((double)text.Length / size));
            for (var i = 0; i < countOfEntries; i++)
            {
                var entry = new string(text.Replace("\n", string.Empty).Skip(i * size).Take(size).ToArray());
                var replaceWith = entry.Length == size ? entry + textForReplace : entry;
                document.Content.Find.Execute(FindText: textForReplace, ReplaceWith: replaceWith, Replace: Word.WdReplace.wdReplaceOne);
            }
        }
    }
}
