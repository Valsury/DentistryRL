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
using Word = Microsoft.Office.Interop.Word;

namespace Dentistry.Pages
{
    /// <summary>
    /// Interaction logic for InfoAboutReceptionsPage.xaml
    /// </summary>
    public partial class InfoAboutReceptionsPage : Page
    {
        public InfoAboutReceptionsPage()
        {
            InitializeComponent();
            {
                DGridReceptions.ItemsSource = AppData.Context.Receptions.ToList();
                    
            }

        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string keyWord = TBoxSearch.Text.ToLower();
            DGridReceptions.ItemsSource = AppData.Context.Receptions.ToList()
                .Where(p =>
                p.DateReception.ToString().Contains(keyWord) ||
                p.IdClient.ToString().Contains(keyWord) ||
                p.IdDoctor.ToString().Contains(keyWord) ||
                p.IdService.ToString().Contains(keyWord)).ToList();
        }

        private void UpdateItems()
        {
            var allReceptions = AppData.Context.Receptions.ToList();
            switch (ComboFilter.SelectedIndex)
            {
                case 0:
                    allReceptions = allReceptions.OrderBy(p => p.DateReception).ToList();
                    break;

                case 1:
                    allReceptions = allReceptions.OrderBy(p => p.IdClient).ToList();
                    break;

                case 3:
                    allReceptions = allReceptions.OrderBy(p => p.IdDoctor).ToList();
                    break;

                case 4:
                    allReceptions = allReceptions.OrderBy(p => p.IdService).ToList();
                    break;

                default:
                    allReceptions = allReceptions.OrderBy(p => p.IdReception).ToList();
                    break;
            }
            if (DGridReceptions != null)
            {
                DGridReceptions.ItemsSource = allReceptions;
            }
        }

        private void ComboFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateItems();
        }
        private void BtnExportWord_Click(object sender, RoutedEventArgs e)
        {
            var allReceptions = AppData.Context.Receptions.ToList();

            var application = new Word.Application();
            Word.Document document = application.Documents.Add();

            foreach(var reception in allReceptions)
            {
                Word.Paragraph receptionParagraph = document.Paragraphs.Add();
                Word.Range receptionRange = receptionParagraph.Range;
                receptionRange.Text = DateTime.Now.ToString();
                receptionParagraph.set_Style("Title");
                receptionRange.InsertParagraphAfter();

                Word.Paragraph tablePAragraph = document.Paragraphs.Add();
                Word.Range tableRange = tablePAragraph.Range;
                Word.Table paymentsTable = document.Tables.Add(tableRange, allReceptions.Count() + 1, 3);
                paymentsTable.Borders.InsideLineStyle = paymentsTable.Borders.OutsideLineStyle
                    = Word.WdLineStyle.wdLineStyleSingle;
                paymentsTable.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;


                Word.Range cellRange;

                cellRange = paymentsTable.Cell(1, 1).Range;
                cellRange.Text = "Дата приема";
                cellRange = paymentsTable.Cell(1, 2).Range;
                cellRange.Text = "Код врача";
                cellRange = paymentsTable.Cell(1, 3).Range;
                cellRange.Text = "Код пациента";      
       
                paymentsTable.Rows[1].Range.Bold = 1;
                paymentsTable.Rows[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;


                for(int i =0; i<allReceptions.Count();i++)
                {
                    var currentReception = allReceptions[i];


                    cellRange = paymentsTable.Cell(i + 2, 1).Range;
                    cellRange.Text = currentReception.DateReception.ToString();

                    cellRange = paymentsTable.Cell(i + 2, 2).Range;
                    cellRange.Text = currentReception.IdDoctor.ToString();

                    cellRange = paymentsTable.Cell(i + 2, 3).Range;
                    cellRange.Text = currentReception.IdClient.ToString();

                }

                if (reception != allReceptions.LastOrDefault())
                    document.Words.Last.InsertBreak(Word.WdBreakType.wdPageBreak);

            }

            application.Visible = true;

            document.SaveAs2(@"D:\Test.docx");
            document.SaveAs2(@"D:\Test.pdf",Word.WdExportFormat.wdExportFormatPDF);
        }
    }
}
