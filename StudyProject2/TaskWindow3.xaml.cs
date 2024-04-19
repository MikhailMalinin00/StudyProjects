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

namespace StudyProject2
{
    /// <summary>
    /// Логика взаимодействия для TaskWindow3.xaml
    /// </summary>
    public partial class TaskWindow3 : Window
    {
        public TaskWindow3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int r1 = Convert.ToInt32(text1.Text);
                int r2 = Convert.ToInt32(text2.Text);
                int h = Convert.ToInt32(text3.Text);
                if ((r1 <= 0) || (r2 <= 0) || (h <= 0))
                {
                    MessageBox.Show("Введите корректные данные");
                    Close();
                }

                double l = Math.Sqrt((r1 - r2) * (r1 - r2) + h * h);
                double s_bok = 3.14 * l * (r1 + r2);
                double s1 = 3.14 * r1 * r1;
                double s2 = 3.14 * r2 * r2;
                double v = 1.04 * h * (r1 * r1 + r1 * r2 + r2 * r2);
                text4.Text = s1.ToString();
                text5.Text = s2.ToString();
                text6.Text = s_bok.ToString();
                text7.Text = v.ToString();
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
