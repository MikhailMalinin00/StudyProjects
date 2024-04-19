using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using Word = Microsoft.Office.Interop.Word;

namespace StudyProject12
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
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

            MenuItem menuItem = (MenuItem)sender;
            string fileText = TextBox1.Text;

            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Text Files(*.txt)|*.txt|All(*.*)|*"
            };

            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, fileText);
            }
        }

        private void MenuItem_Click2(object sender, RoutedEventArgs e)
        {
            string str = TextBox1.Text;
            byte[] tmp = Encoding.Unicode.GetBytes(str);
            string outStr = BitConverter.ToString(tmp);
            MessageBox.Show(outStr);
        }
        private void MenuItem_Click3(object sender, RoutedEventArgs e)
        {

            string string_Data = TextBox1.Text;
            var win1251 = CodePagesEncodingProvider.Instance.GetEncoding(1251);
            byte[] data = win1251.GetBytes(string_Data);
            string vivod = BitConverter.ToString(data);
            MessageBox.Show(vivod);

        }
        private void MenuItem_Click4(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

            winword.Visible = false;

            object missing = System.Reflection.Missing.Value;

            //Создание нового документа
            Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            //Добавление текста в документ
            document.Content.SetRange(0, 0);
            document.Content.Text = TextBox1.Text + Environment.NewLine;

            winword.Visible = true;

        }
        private void MenuItem_Click6(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            string fileText = TextBox1.Text;

            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Bin Files(*.bin)|*.bin|All(*.*)|*"
            };

            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, fileText);
            }
        }
        private void MenuItem_Click5(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;


            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Bin Files(*.bin)|*.bin|All(*.*)|*"
            };

            if (dialog.ShowDialog() == true)
                TextBox1.Text = File.ReadAllText(dialog.FileName);
        }
        private void MenuItem_Click7(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(TextBox1, "Печать");
            }
        }
    }
}
