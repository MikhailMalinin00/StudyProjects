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
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;

namespace StudyProject10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
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
            Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

            winword.Visible = false;

            //Заголовок документа
            winword.Documents.Application.Caption = "Практическая работа №9";

            object missing = System.Reflection.Missing.Value;

            //Создание нового документа
            Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);


            //Добавление текста в документ
            document.Content.SetRange(0, 0);
            document.Content.Text = "Практическая работа №9" + Environment.NewLine;

            //Добавление текста со стилем Заголовок 1
            Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
            object styleHeading1 = "Заголовок 1";
            para1.Range.set_Style(styleHeading1);
            para1.Range.Text = "Команды";
            para1.Range.InsertParagraphAfter();

            //Создание таблицы 6х2
            Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para1.Range, 6, 2, ref missing, ref missing);


            firstTable.Borders.Enable = 1;
            foreach (Row row in firstTable.Rows)
            {
                foreach (Cell cell in row.Cells)
                {
                    //Заголовок таблицы
                    if (cell.RowIndex == 1)
                    {
                        cell.Range.Text = "Команда " + cell.ColumnIndex.ToString();
                        cell.Range.Font.Bold = 1;
                        //Задаем шрифт и размер текста
                        cell.Range.Font.Name = "Times New Roman";
                        cell.Range.Font.Size = 12;
                        cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25; //Заливка шапки
                        //Выравнивание текста в заголовках столбцов по центру
                        cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                    //Значения ячеек
                    else
                    {

                        Microsoft.Office.Interop.Word.Range cellRange;

                        cellRange = firstTable.Cell(2, 1).Range;
                        cellRange.Text = "Потапов Даниил";
                        cellRange = firstTable.Cell(2, 2).Range;
                        cellRange.Text = "Седов Кирилл";

                        cellRange = firstTable.Cell(3, 1).Range;
                        cellRange.Text = "Власов Анатолий";
                        cellRange = firstTable.Cell(3, 2).Range;
                        cellRange.Text = "Пименов Денис";

                        cellRange = firstTable.Cell(4, 1).Range;
                        cellRange.Text = "Титов Алексей";
                        cellRange = firstTable.Cell(4, 2).Range;
                        cellRange.Text = "Федоров Кирилл";

                        cellRange = firstTable.Cell(5, 1).Range;
                        cellRange.Text = "Платонов Марк";
                        cellRange = firstTable.Cell(5, 2).Range;
                        cellRange.Text = "Ларионов Арсений";

                        cellRange = firstTable.Cell(6, 1).Range;
                        cellRange.Text = "Федоров Илья";
                        cellRange = firstTable.Cell(6, 2).Range;
                        cellRange.Text = "Левин Леонид";
                    }
                }
            }
            // Добавляем текст в конец документа
            Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
            para2.Range.Text = "Конец документа";
            para2.Range.Font.Bold = 1;
            para2.Format.SpaceAfter = 16; // установили 16 пт шрифт
            winword.Visible = true;
        }
    }
}
