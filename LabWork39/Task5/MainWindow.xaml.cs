using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            DrawChessField(8, 8, 100);
        }

        private void DrawChessField(int xCount, int yCount, int side)
        {
            for (var i = 0; i < xCount; i++)
            {
                for (var j = 0; j < yCount; j++)
                {
                    Brush cellColor;

                    if ((j & 1) == 0)
                    {
                        cellColor = (i & 1) == 0
                            ? Brushes.Black
                            : Brushes.White;
                    }
                    else
                    {
                        cellColor = (i & 1) == 1
                            ? Brushes.Black
                            : Brushes.White;
                    }

                    var cell = new Border
                    {
                        Width = side,
                        Height = side,
                        Background = cellColor,
                        Margin = new Thickness
                        {
                            Top = side * j,
                            Left = side * i
                        }
                    };
                    ChessFieldCanvas.Children.Add(cell);
                }
            }
        }
    }
}
