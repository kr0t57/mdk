using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Documents;

namespace Task1
{
    public partial class MainWindow : Window
    {
        private string _path = @"C:\";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые документы|*txt|Текст в формате rtf|*rtf|Все файлы|*.*";
            openFileDialog.ShowDialog();

            if (String.IsNullOrWhiteSpace(openFileDialog.FileName))
            {
                return;
            }

            var format = GetFormat(openFileDialog.FileName);

            using (var fs = File.Open(openFileDialog.FileName, FileMode.Open))
            {
                var textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                textRange.Load(fs, format);
            }
        }

        private void SaveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = _path;
            saveFileDialog.Filter = "Текстовые документы|*txt|Текст в формате rtf|*rtf";
            saveFileDialog.ShowDialog();

            if (String.IsNullOrWhiteSpace(saveFileDialog.FileName))
            {
                return;
            }

            var format = GetFormat(saveFileDialog.FileName);

            using (var fs = File.Open(saveFileDialog.FileName, FileMode.Create))
            {
                var textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                textRange.Save(fs, format);
            }
        }

        private void ColorMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var colorDialog = new ColorDialog(richTextBox.SelectionBrush);
            colorDialog.ShowDialog();
            var textRange = new TextRange(richTextBox.Selection.Start, richTextBox.Selection.End);
            textRange.ApplyPropertyValue(TextElement.ForegroundProperty, colorDialog.SelectedColor);
        }

        private void FontMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var fontDialog = new QIQI.WpfFontPicker.FontDialog();
            fontDialog.ShowDialog();
            var fontInfo = fontDialog.SelectedFontInfo;
            richTextBox.FontStyle = fontInfo.Style;
            richTextBox.FontFamily = fontInfo.Family;
            richTextBox.FontSize = fontInfo.Size;
            richTextBox.FontWeight = fontInfo.Weight;
            richTextBox.FontStretch = fontInfo.Stretch;
        }

        private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var aboutProgramm = new AboutProgramm();
            aboutProgramm.ShowDialog();
        }

        private void DefaultFolderMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            folderBrowserDialog.Description = "Выберите папку для сохранения файлов по умолчанию";
            folderBrowserDialog.ShowDialog();

            if (!String.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
            {
                _path = folderBrowserDialog.SelectedPath;
            }

        }

        private string? GetFormat(string fileName)
        {
            return new FileInfo(fileName).Extension switch
            {
                ".rtf" => DataFormats.Rtf,
                _ => DataFormats.Text
            };
        }
    }
}
