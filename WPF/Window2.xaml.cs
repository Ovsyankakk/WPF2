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
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> translations = new Dictionary<string, string>
        {
            { "солнце", "sun" },
            { "дождь", "rain" },
            { "ветер", "wind" },
            { "снег", "snow" },
            { "облако", "cloud" },
            { "туман", "fog" },
            { "град", "hail" },
            { "погода", "weather" },
            { "температура", "temperature" },
            { "влажность", "humidity" }
        };

        private void TranslateButton_Click(object sender, RoutedEventArgs e)
        {
            string input = InputWord.Text.ToLower();
            if (translations.TryGetValue(input, out string translation))
            {
                ResultTextBlock.Text = translation;
            }
            else
            {
                ResultTextBlock.Text = "Такого слова нет.";
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Закрываем текущее окно
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }
    }
}

