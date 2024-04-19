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
using xl = Microsoft.Office.Interop.Excel;

namespace StudyProject11
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
            Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            xl.Application XL1 = new xl.Application();
            //Создаем документ
            xl.Application ObjExcel = new xl.Application();
            xl.Workbook ObjWorkBook;
            xl.Worksheet ObjWorkSheet;
            ObjWorkBook = ObjExcel.Workbooks.Add(System.Reflection.Missing.Value);
            ObjWorkSheet = (xl.Worksheet)ObjWorkBook.Sheets[1];
            ObjWorkSheet.StandardWidth = 30; //Задали определенную ширину столбцов для корректного вывода данных

            //Заполняем таблицу
            ObjExcel.ActiveSheet.Range("A1").Value = "Наименование";
            ObjExcel.ActiveSheet.Range("A2").Value = "Колбаса";
            ObjExcel.ActiveSheet.Range("A3").Value = "Сыр";
            ObjExcel.ActiveSheet.Range("A4").Value = "Молоко";
            ObjExcel.ActiveSheet.Range("A5").Value = "Масло";
            ObjExcel.ActiveSheet.Range("A6").Value = "Хлеб";

            ObjExcel.ActiveSheet.Range("B1").Value = "Стоимость";
            ObjExcel.ActiveSheet.Range("B2").Value = 350;
            ObjExcel.ActiveSheet.Range("B3").Value = 450;
            ObjExcel.ActiveSheet.Range("B4").Value = 100;
            ObjExcel.ActiveSheet.Range("B5").Value = 180;
            ObjExcel.ActiveSheet.Range("B6").Value = 60;

            //Создаем столбчатую диаграмму
            ObjExcel.Charts.Add();
            ObjExcel.ActiveChart.ChartType = xl.XlChartType.xlColumnClustered;
            ObjExcel.ActiveChart.HasLegend = false;
            ObjExcel.ActiveChart.HasTitle = true;
            ObjExcel.ActiveChart.ChartTitle.Characters.Text = "Стоимость товаров";

            //Создаем подписи осей
            ObjExcel.ActiveChart.Axes(xl.XlAxisType.xlValue).HasTitle = true;
            ObjExcel.ActiveChart.Axes(xl.XlAxisType.xlValue).AxisTitle.Characters.Text = "Стоимость";

            ObjExcel.ActiveChart.Axes(xl.XlAxisType.xlCategory).HasTitle = true;
            ObjExcel.ActiveChart.Axes(xl.XlAxisType.xlCategory).AxisTitle.Characters.Text = "Наименования";

            ObjExcel.Visible = true;
        }
    }
}
