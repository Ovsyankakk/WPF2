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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        private const string CorrectPassword = "Program1786ProMaster_19";
        public Window4()
        {
            InitializeComponent();
        }
        private void CheckPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            if (InputPassword.Text == CorrectPassword)
            {
                ResultTextBlock.Text = "Секретное сообщение: Успех!";
            }
            else
            {
                ResultTextBlock.Text = "Неверный пароль. Попробуйте еще раз.";
                InputPassword.Clear();
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
