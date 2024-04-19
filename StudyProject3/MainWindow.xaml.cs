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

namespace StudyProject3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Numbers
        {
            public Numbers() { Random rand = new Random(); for (int i = 0; i < 10; i++) { mas[i] = rand.Next(1, 100); } }
            public Numbers(int a0, int a1, int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9) { mas[0] = a0; mas[1] = a1; mas[2] = a2; mas[3] = a3; mas[4] = a4; mas[5] = a5; mas[6] = a6; mas[7] = a7; mas[8] = a8; mas[9] = a9; }
            public int[] mas = new int[10];
            public int[] MAS { get { return mas; } set { mas = value; } }
            public int N0 { get { return mas[0]; } set { mas[0] = value; } }
            public int N1 { get { return mas[1]; } set { mas[1] = value; } }
            public int N2 { get { return mas[2]; } set { mas[2] = value; } }
            public int N3 { get { return mas[3]; } set { mas[3] = value; } }
            public int N4 { get { return mas[4]; } set { mas[4] = value; } }
            public int N5 { get { return mas[5]; } set { mas[5] = value; } }
            public int N6 { get { return mas[6]; } set { mas[6] = value; } }
            public int N7 { get { return mas[7]; } set { mas[7] = value; } }
            public int N8 { get { return mas[8]; } set { mas[8] = value; } }
            public int N9 { get { return mas[9]; } set { mas[9] = value; } }

        }
        public int RandomInt()
        {
            Random rand = new Random();
            return rand.Next(1, 100);
        }
        public MainWindow()
        {
            InitializeComponent();
            ButtonUpdate.Background = Brushes.LightBlue;
            Random rand = new Random();
            List<Numbers> Array = new List<Numbers>();
            for (int i = 0; i < 10; i++) { Array.Add(new Numbers(rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100))); }
            datagrid.ItemsSource = Array;
            FuncOfFuncs(Array);
        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            List<Numbers> Array = new List<Numbers>();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                Array.Add(new Numbers(rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100)));
            }
            datagrid.ItemsSource = Array;
            FuncOfFuncs(Array);
        }
        private void FuncOfFuncs(List<Numbers> Array)
        {
            GlDigFunc(Array);
            PobDigFunc(Array);
            TopTregFunc(Array);
            LeftTregFunc(Array);
            BottomTregFunc(Array);
            RightTregFunc(Array);
        }

        private void GlDigFunc(List<Numbers> Array)
        {
            var ArrayDeystv = new List<int>();
            for (int i = 0; i < 10; i++) { ArrayDeystv.Add(Array[i].mas[i]); }
            GlDigTXTsum.Text = "Сумма элементов: " + ArrayDeystv.Sum().ToString();
            GlDigTXTmin.Text = "Минимальный элемент: " + ArrayDeystv.Min().ToString();
            GlDigTXTmax.Text = "Максимальный элемент: " + ArrayDeystv.Max().ToString();
        }
        private void PobDigFunc(List<Numbers> Array)
        {
            var ArrayDeystv = new List<int>();
            for (int i = 0; i < 10; i++) { ArrayDeystv.Add(Array[i].mas[9 - i]); }
            PobDigTXTsum.Text = "Сумма элементов: " + ArrayDeystv.Sum().ToString();
            PobDigTXTmin.Text = "Минимальный элемент: " + ArrayDeystv.Min().ToString();
            PobDigTXTmax.Text = "Максимальный элемент: " + ArrayDeystv.Max().ToString();
        }
        private void TopTregFunc(List<Numbers> Array)
        {
            var ArrayDeystv = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                for (int a = i + 1; a < 9 - i; a++) { ArrayDeystv.Add(Array[i].mas[a]); }
            }

            TopTregTXTsum.Text = "Сумма элементов: " + ArrayDeystv.Sum().ToString();
            TopTregTXTmin.Text = "Минимальный элемент: " + ArrayDeystv.Min().ToString();
            TopTregTXTmax.Text = "Максимальный элемент: " + ArrayDeystv.Max().ToString();
        }
        private void BottomTregFunc(List<Numbers> Array)
        {
            var ArrayDeystv = new List<int>();
            for (int i = 9; i > 5; i--)
            {
                for (int a = i - 1; a > 9 - i; a--) { ArrayDeystv.Add(Array[i].mas[a]); }
            }

            BottomTregTXTsum.Text = "Сумма элементов: " + ArrayDeystv.Sum().ToString();
            BottomTregTXTmin.Text = "Минимальный элемент: " + ArrayDeystv.Min().ToString();
            BottomTregTXTmax.Text = "Максимальный элемент: " + ArrayDeystv.Max().ToString();
        }
        private void LeftTregFunc(List<Numbers> Array)
        {
            var ArrayDeystv = new List<int>();
            for (int i = 4; i > 0; i--)
            {
                for (int a = 0; a < i; a++) { ArrayDeystv.Add(Array[i].mas[a]); ArrayDeystv.Add(Array[9 - i].mas[a]); }
            }

            LeftTregTXTsum.Text = "Сумма элементов: " + ArrayDeystv.Sum().ToString();
            LeftTregTXTmin.Text = "Минимальный элемент: " + ArrayDeystv.Min().ToString();
            LeftTregTXTmax.Text = "Максимальный элемент: " + ArrayDeystv.Max().ToString();
        }
        private void RightTregFunc(List<Numbers> Array)
        {
            var ArrayDeystv = new List<int>();
            for (int i = 4; i > 0; i--)
            {
                for (int a = 0; a < i; a++) { ArrayDeystv.Add(Array[i].mas[9 - a]); ArrayDeystv.Add(Array[9 - i].mas[9 - a]); }
            }

            RightTregTXTsum.Text = "Сумма элементов: " + ArrayDeystv.Sum().ToString();
            RightTregTXTmin.Text = "Минимальный элемент: " + ArrayDeystv.Min().ToString();
            RightTregTXTmax.Text = "Максимальный элемент: " + ArrayDeystv.Max().ToString();
        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.Cancel)
                e.Cancel = true;
            base.OnClosing(e);
        }
    }
}
