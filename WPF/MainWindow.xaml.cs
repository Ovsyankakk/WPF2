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

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Trans_Click(object sender, RoutedEventArgs e)
        {
            Window2 Window2 = new Window2();
            Window2.Show();
            this.Close();
        }

        private void Opr_Click(object sender, RoutedEventArgs e)
        {
            Window3 Window3 = new Window3();
            Window3.Show();
            this.Close();
        }

        private void Password_Click(object sender, RoutedEventArgs e)
        {
            Window4 Window4 = new Window4();
            Window4.Show();
            this.Close();
        }

        private void Caculator_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window1 = new Window1();
            Window1.Show();
            this.Close();

        }
    }
}
