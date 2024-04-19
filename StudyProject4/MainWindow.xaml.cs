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

namespace StudyProject4
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s1 = box1.Text;
            string s2 = box2.Text;
            bool b = s1.Contains(s2);

            if (b)
            {
                box3.Text = s2 + " Встречается в строке: " + " раз(а)";
            }
            else
            {
                box3.Text = "Нет такого символа или строки";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string s3 = box4.Text;
            string s4 = box5.Text;

            string s5 = string.Concat(s3, s4);

            box6.Text = s5;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string s6 = box7.Text;
            string s7 = box8.Text;
            if (s6.EndsWith(s7))

            {
                box9.Text = "Заканчивается";
            }
            else
            {
                box9.Text = "Не заканчивается";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            string s8 = box10.Text;
            string s9 = box11.Text;
            int s10 = s8.IndexOf(s9);
            box12.Text = Convert.ToString(s10);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string s8 = box10.Text;
            string s9 = box11.Text;
            int s10 = s8.LastIndexOf(s9);
            box12.Text = Convert.ToString(s10);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(box15.Text);
            string text = box13.Text + " ";
            string substring = box14.Text + " ";
            text = text.Insert(n, substring);
            box16.Text = text;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string s5 = box17.Text;
            string s6 = box18.Text;
            string s7 = box19.Text;
            string[] values = new string[] { s5, s6, s7 };

            string s10 = string.Join(" ", values);
            box20.Text = s10;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            string text = box21.Text;
            string nazameny = box22.Text;
            string zamena = box23.Text;

            text = text.Replace(nazameny, zamena);
            box24.Text = text;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            string text = box25.Text;
            string[] tekst = text.Split(' ');
            foreach (var s in tekst)
            {
                box26.Text += s.ToString() + "\r\n";
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(box29.Text);
            string text = box28.Text;
            text = text.Substring(n);
            box30.Text = text;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            string hello = box31.Text;

            box33.Text = hello.ToLower();
            box32.Text = hello.ToUpper();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            string text = box34.Text;
            text = text.Trim();
            box37.Text = text;
        }
    }
}
