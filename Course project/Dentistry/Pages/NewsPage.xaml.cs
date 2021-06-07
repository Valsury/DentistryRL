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

namespace Dentistry.Pages
{
    /// <summary>
    /// Interaction logic for NewsPage.xaml
    /// </summary>
    public partial class NewsPage : Page
    {
        public NewsPage()
        {
            InitializeComponent();
            var currentAuthors = AppData.Context.Authors.ToList();
            currentAuthors.Insert(0, new Entities.Author
            {
                IdAuthor = 0,
                NameAuthor = "Все авторы"
            });
            ComboAuthors.ItemsSource = currentAuthors;
            UpdateItems();

        }
        private void UpdateItems()
        {
            var allNews = AppData.Context.News.ToList();
            if (ComboAuthors.SelectedIndex > 0)
            {
                allNews = allNews.Where(p => p.Author == ComboAuthors.SelectedItem as Entities.Author).ToList();
            }
            switch (ComboSort.SelectedIndex)
            {
                case 0:
                    allNews = allNews.OrderBy(p => p.CreationDateNews).ToList();
                    break;
                case 1:
                    allNews = allNews.OrderBy(p => p.HeaderNews).ToList();
                    break;
                case 2:
                    allNews = allNews.OrderBy(p => p.TextNews).ToList();
                    break;
                default:
                    allNews = allNews.OrderBy(p => p.Author.NameAuthor).ThenBy(p => p.CreationDateNews).ToList();
                    break;

            }
            if (LViewNews != null)
                LViewNews.ItemsSource = allNews;

            //var currentAuthor = ComboAuthors.SelectedItem as Entities.Author;
            //if(currentAuthor!= null)
            //{
            //    LViewNews.ItemsSource = AppData.Context.News.ToList()
            //        .Where(p=>p.Author==currentAuthor).ToList();
            //}
            //else
            //{
            //    LViewNews.ItemsSource = AppData.Context.News.ToList();
            //}
        }

        private void ComboAuthors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateItems();
        }

        private void ComboSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateItems();
        }

        private void BtnExport_Click(object sender, RoutedEventArgs e)
        {
            if (RbXLSX.IsChecked == true)
            {
                ExportToXLSX();
            }
            if (RbCSV.IsChecked == true)
            {
               ExportToCSV();

            }


        }

        private void ExportToXLSX()
        {
            Microsoft.Office.Interop.Excel.Application application =
                new Microsoft.Office.Interop.Excel.Application();
            application.Workbooks.Add();
            //application.Visible = true;
            Microsoft.Office.Interop.Excel.Worksheet worksheet =
                application.ActiveSheet;

            worksheet.Cells[1, 1] = "id";
            worksheet.Cells[1, 2] = "Header";
            worksheet.Cells[1, 3] = "Text";
            worksheet.Cells[1, 4] = "Creation date";
            worksheet.Cells[1, 5] = "Author";

            var allnews = AppData.Context.News.ToList()
                .OrderBy(p => p.CreationDateNews).ToList();

            for (int i = 0; i < allnews.Count(); i++)
            {
                var currentnews = allnews[i];

                worksheet.Cells[i + 2, 1] = currentnews.IdNews;
                worksheet.Cells[i + 2, 2] = currentnews.HeaderNews;
                worksheet.Cells[i + 2, 3] = currentnews.CreationDateNews.ToString("dd.MM.yyyy HH:mm");
                worksheet.Cells[i + 2, 4] = currentnews.TextNews;
                worksheet.Cells[i + 2, 5] = currentnews.Author.NameAuthor;
            }

            CheckExportDirectory();

            worksheet.SaveAs($"{AppDomain.CurrentDomain.BaseDirectory}Export\\Экспортированные данные XLSX {DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}.xlsx");
            application.Quit();
            MessageBox.Show("Успешно", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ExportToCSV()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Id, Header, Text, Creation date, Author");

            var allnews = AppData.Context.News.ToList()
              .OrderBy(p => p.CreationDateNews).ToList();

            foreach( var News in allnews)
            {
                sb.AppendLine($"{News.IdNews}, {CheckTextForCSV(News.HeaderNews)}, {CheckTextForCSV(News.TextNews)}, " +
                    $"{News.CreationDateNews.ToString("dd.MM.yyyy HH.mm")}, {CheckTextForCSV(News.Author.NameAuthor)}");
            }

            CheckExportDirectory();
            File.WriteAllText($"{AppDomain.CurrentDomain.BaseDirectory}Export\\" +
                $"Экспортированные данные CSV {DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}.csv",sb.ToString(), Encoding.UTF8);

            MessageBox.Show("Успешно", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private static void CheckExportDirectory()
        {
            var directory = new DirectoryInfo("Export");
            if (directory.Exists == false)
                directory.Create();
        }

        private string CheckTextForCSV (string text)
        {
            if (text.Contains(","))

                return $"\"{text}\"";

            else 

                return text;
        }


    }
}
