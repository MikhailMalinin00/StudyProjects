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
    /// Логика взаимодействия для TaskWindow1.xaml
    /// </summary>
    public partial class TaskWindow1 : Window
    {
        public TaskWindow1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int r = Convert.ToInt32(text1.Text);
                int h = Convert.ToInt32(text2.Text);
                if ((r <= 0) || (h <= 0))
                {
                    MessageBox.Show("Введите корректные данные");
                    Close();
                }
                double s_osn = 3.14 * r * r;
                double l = Math.Sqrt(r * r + h * h);
                double s_bok = 3.14 * r * l;
                double s_poln = s_bok + s_osn;
                double v = (3.14 * r * r * h) / 3;
                text3.Text = s_osn.ToString();
                text4.Text = s_bok.ToString();
                text5.Text = s_poln.ToString();
                text6.Text = v.ToString();
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
