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

namespace Dentistry.Pages
{
    /// <summary>
    /// Interaction logic for InfoAboutCurrentClientReceptionsPage.xaml
    /// </summary>
    public partial class InfoAboutCurrentClientReceptionsPage : Page
    {
        public InfoAboutCurrentClientReceptionsPage()
        {
            InitializeComponent();
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string keyWord = TBoxSearch.Text.ToLower();
            DGridReceptions.ItemsSource = AppData.Context.Receptions.ToList().Where(p => p.IdClient == Properties.Settings.Default.UserID)
                .Where(p =>
                p.Doctor.FullNameDoctor.ToLower().Contains(keyWord) ||
                p.DiagnosisReception.ToLower().Contains(keyWord) ||
                p.DateReception.ToString().Contains(keyWord) ||
                p.Service.NameService.ToLower().Contains(keyWord) ||
                p.Service.PriceService.ToString().Contains(keyWord)
                ).ToList();
        }

        private void UpdateItems()
        {
            var allReceptions = AppData.Context.Receptions.ToList().Where(p=>p.IdClient==Properties.Settings.Default.UserID);
            switch (ComboFilter.SelectedIndex)
            {
                case 0:
                    allReceptions = allReceptions.OrderBy(p => p.DateReception).ToList();
                    break;

                case 1:
                    allReceptions = allReceptions.OrderBy(p => p.Doctor.FullNameDoctor).ToList();
                    break;

                case 2:
                    allReceptions = allReceptions.OrderBy(p => p.Service.NameService).ToList();
                    break;

                case 3:
                    allReceptions = allReceptions.OrderBy(p => p.DiagnosisReception).ToList();
                    break;

                case 4:
                    allReceptions = allReceptions.OrderBy(p => p.Service.PriceService).ToList();
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
    }
}
