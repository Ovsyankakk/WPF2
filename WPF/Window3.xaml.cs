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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        private void CheckNumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputNumber.Text, out int number))
            {
                if (number >= 0 && number <= 14)
                {
                    ResultTextBlock.Text = "Число в промежутке [0 - 14]";
                }
                else if (number >= 15 && number <= 35)
                {
                    ResultTextBlock.Text = "Число в промежутке [15 - 35]";
                }
                else if (number >= 36 && number <= 50)
                {
                    ResultTextBlock.Text = "Число в промежутке [36 - 50]";
                }
                else if (number >= 51 && number <= 100)
                {
                    ResultTextBlock.Text = "Число в промежутке [51 - 100]";
                }
                else
                {
                    ResultTextBlock.Text = "Число вне диапазона [0 - 100]";
                }
            }
            else
            {
                ResultTextBlock.Text = "Введите корректное число.";
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }
    }
}
