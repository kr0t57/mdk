using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Task1
{
    public partial class MainWindow : Window
    {
        private List<Game> _games;

        public MainWindow()
        {
            InitializeComponent();
            _games = new List<Game>()
            {
                new Game() { Id= 1, Name="CS:GO", Site = "https://CSGO.com", Category="Shooter", Price=999.502 },
                new Game() { Id= 2, Name="Rust", Site = "https://Rust.com", Category="Survival Simulator", Price=2999.99 },
                new Game() { Id= 3, Name="Fortnite", Site = "https://Fortnite.com", Category="Battle Royale", Price=499.99 },
                new Game() { Id= 4, Name="Valorant", Site = "https://Valorant.com", Category="Shooter", Price=999.99 },
                new Game() { Id= 5, Name="GTAV", Site = "https://GTAV.com", Category="Action Adventure", Price=3999.99 },
            };
            DataContext = this;
            column.ItemsSource = Categories;
        }

        public IEnumerable<Game> Games => _games;
        public IEnumerable<string> Categories => _games.Select(x => x.Category).Distinct();

        private void MoreButton_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show($"{String.Join("\n", Categories)}");


            var game = ((Button)sender).DataContext as Game;
            
            if (game != null)
            {
                MessageBox.Show($"Id: {game.Id}\nName: {game.Name}\nSite: {game.Site}\nCategory: {game.Category}\nPrice: {game.Price.ToString("0.00")}");
            }
        }
    }
}
