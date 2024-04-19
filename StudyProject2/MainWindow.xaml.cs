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

namespace StudyProject2
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
            TaskWindow taskWindow = new TaskWindow();
            taskWindow.Show();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            TaskWindow1 taskWindow = new TaskWindow1();
            taskWindow.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            TaskWindow2 taskWindow = new TaskWindow2();
            taskWindow.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            TaskWindow3 taskWindow = new TaskWindow3();
            taskWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
