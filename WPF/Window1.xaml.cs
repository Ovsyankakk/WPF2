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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    double operand1 = Convert.ToDouble(operand1TextBox.Text);
                    double operand2 = Convert.ToDouble(operand2TextBox.Text);
                    string sign = operationTextBox.Text;

                    double result = 0;
                    switch (sign)
                    {
                        case "+":
                            result = operand1 + operand2;
                            break;
                        case "-":
                            result = operand1 - operand2;
                            break;
                        case "*":
                            result = operand1 * operand2;
                            break;
                        case "/":
                            if (operand2 == 0)
                            {
                                MessageBox.Show("Ошибка: Деление на ноль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                                return;
                            }
                            result = operand1 / operand2;
                            break;
                        default:
                            MessageBox.Show("Ошибка: Неверный знак операции!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                    }
                    resultTextBlock.Text = $"Результат: {result}";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ошибка: Неверный формат числа!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}

