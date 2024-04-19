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
    /// Логика взаимодействия для TaskWindow2.xaml
    /// </summary>
    public partial class TaskWindow2 : Window
    {
        public TaskWindow2()
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
                double s_bok = 2 * 3.14 * r * h;
                double s_pol = s_osn * 2 + s_bok;
                double v = 3.14 * r * r * h;
                text3.Text = s_osn.ToString();
                text4.Text = s_bok.ToString();
                text5.Text = s_pol.ToString();
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
