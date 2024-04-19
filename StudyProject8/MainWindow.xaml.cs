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

namespace StudyProject8
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
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.Cancel)
                e.Cancel = true;
            base.OnClosing(e);
        }
        private void erasing(object sender, RoutedEventArgs e)
        {
            string str = input.Text;
            if (str == "")
            {
                MessageBox.Show("Нет данных");
            }
            input.Clear();
        }

        private void root(object sender, RoutedEventArgs e)
        {
            string str = input.Text;
            int str1;
            bool a = int.TryParse(str, out str1);
            if (a)
            {
                double k = Math.Sqrt(str1);
                input.Text = k.ToString();
            }
        }

        private void square(object sender, RoutedEventArgs e)
        {
            string str = input.Text;
            int str1;
            bool a = int.TryParse(str, out str1);
            if (a)
            {
                double k = Math.Pow(str1, 2);
                input.Text = k.ToString();
            }
        }

        private void cube(object sender, RoutedEventArgs e)
        {
            string str = input.Text;
            int str1;
            bool a = int.TryParse(str, out str1);
            if (a)
            {
                double k = Math.Pow(str1, 3);
                input.Text = k.ToString();
            }
        }

        private void seven(object sender, RoutedEventArgs e)
        {
            int a = 7;
            input.Text += a.ToString();
        }

        private void four(object sender, RoutedEventArgs e)
        {
            int a = 4;
            input.Text += a.ToString();
        }

        private void one(object sender, RoutedEventArgs e)
        {
            int a = 1;
            input.Text += a.ToString();
        }

        private void zero(object sender, RoutedEventArgs e)
        {
            int a = 0;
            input.Text += a.ToString();
        }

        private void eight(object sender, RoutedEventArgs e)
        {
            int a = 8;
            input.Text += a.ToString();
        }

        private void five(object sender, RoutedEventArgs e)
        {
            int a = 5;
            input.Text += a.ToString();
        }

        private void two(object sender, RoutedEventArgs e)
        {
            int a = 2;
            input.Text += a.ToString();
        }

        private void nine(object sender, RoutedEventArgs e)
        {
            int a = 9;
            input.Text += a.ToString();
        }

        private void six(object sender, RoutedEventArgs e)
        {
            int a = 6;
            input.Text += a.ToString();
        }

        private void three(object sender, RoutedEventArgs e)
        {
            int a = 3;
            input.Text += a.ToString();
        }

        private void division(object sender, RoutedEventArgs e)
        {
            string str1 = "÷";
            input.Text += str1;
        }

        private void multiple(object sender, RoutedEventArgs e)
        {
            string str1 = "x";
            input.Text += str1;
        }

        private void minus(object sender, RoutedEventArgs e)
        {
            string str1 = "-";
            input.Text += str1;
        }

        private void plus(object sender, RoutedEventArgs e)
        {
            string str1 = "+";
            input.Text += str1;
        }

        private void equals(object sender, RoutedEventArgs e)
        {
            int iOp = 0;
            if (input.Text.Contains("+"))
            {
                iOp = input.Text.IndexOf("+");
            }
            else if (input.Text.Contains("-"))
            {
                iOp = input.Text.IndexOf("-");
            }
            else if (input.Text.Contains("x"))
            {
                iOp = input.Text.IndexOf("x");
            }
            else if (input.Text.Contains("*"))
            {
                iOp = input.Text.IndexOf("*");
            }
            else if (input.Text.Contains("÷"))
            {
                iOp = input.Text.IndexOf("÷");
            }
            else if (input.Text.Contains("/"))
            {
                iOp = input.Text.IndexOf("/");
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
            double a = Convert.ToDouble(input.Text.Substring(0, iOp));
            double b = Convert.ToDouble(input.Text.Substring(iOp + 1, input.Text.Length - iOp - 1));

            if (input.Text.Contains("÷"))
            {
                input.Text += "=" + (a / b);
            }
            else if (input.Text.Contains("+"))
            {
                input.Text += "=" + (a + b);
            }
            else if (input.Text.Contains("-"))
            {
                input.Text += "=" + (a - b);
            }
            else if (input.Text.Contains("x"))
            {
                input.Text += "=" + (a * b);
            }
            else if (input.Text.Contains("*"))
            {
                input.Text += "=" + (a * b);
            }
            else if (input.Text.Contains("/"))
            {
                input.Text += "=" + (a / b);
            }
        }

        private void input_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
