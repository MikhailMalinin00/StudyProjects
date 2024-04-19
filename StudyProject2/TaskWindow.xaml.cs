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
    /// Логика взаимодействия для TaskWindow.xaml
    /// </summary>
    public partial class TaskWindow : Window
    {
        public TaskWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(text1.Text);
                double v = 1.25 * 3.14 * a * a * a;
                double s = 4 * 3.14 * a * a;
                text2.Text = v.ToString();
                text3.Text = s.ToString();
            }

            catch
            {
                MessageBox.Show("Введите корректные данные");
            }
        }
    }
}
