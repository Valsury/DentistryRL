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


                UpdateItems();



            }

        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateItems();
        }

        private void UpdateItems()
        {

            var allReceptions = AppData.Context.Receptions.ToList().Where(p=>p.IdDoctor == AppData.CurrentUser.IdDoctor);
            switch (ComboFilter.SelectedIndex)
            {
                case 0:
                    allReceptions = allReceptions.OrderBy(p => p.DateReception).ToList();
                    break;

                case 1:
                    allReceptions = allReceptions.OrderBy(p => p.Doctor.FullNameDoctor).ToList();
                    break;

                case 2:
                    allReceptions = allReceptions.OrderBy(p => p.Client.FullNameClient).ToList();
                    break;

                case 3:
                    allReceptions = allReceptions.OrderBy(p => p.Service.NameService).ToList();
                    break;

                case 4:
                    allReceptions = allReceptions.OrderBy(p => p.DiagnosisReception).ToList();
                    break;

                case 5:
                    allReceptions = allReceptions.OrderBy(p => p.Service.PriceService).ToList();
                    break;

                default:
                    allReceptions = allReceptions.OrderBy(p => p.IdReception).ToList();
                    break;
            }
         

            string keyWord = TBoxSearch.Text.ToLower();
            allReceptions = allReceptions
                .Where(p =>
                p.Client.FullNameClient.ToLower().Contains(keyWord) ||
                p.Doctor.FullNameDoctor.ToLower().Contains(keyWord) ||
                p.DiagnosisReception.ToLower().Contains(keyWord) ||
                p.DateReception.ToString().Contains(keyWord) ||
                p.Service.NameService.ToLower().Contains(keyWord) ||
                p.Service.PriceService.ToString().Contains(keyWord)
                ).ToList();
                DGridReceptions.ItemsSource = allReceptions;
        }

        private void ComboFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateItems();
        }
       

        private void BtnAddData_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddReceptionPage(null));
        }

        private void BtnChangeData_Click(object sender, RoutedEventArgs e)
        {
            if (DGridReceptions.SelectedItem is Entities.Reception currentReception)
                NavigationService.Navigate(new AddReceptionPage(currentReception));
        }

        private void BtnDeleteData_Click(object sender, RoutedEventArgs e)
        {
            if (DGridReceptions.SelectedItem is Entities.Reception currentReception)
            {

                if (MessageBox.Show("Вы действительно хотите удалить данные?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {


                    AppData.Context.Receptions.Remove(currentReception);
                    AppData.Context.SaveChanges();
                    UpdateItems();
                 


                }
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateItems();
        }



        private void HLinkFullInfo_Click(object sender, RoutedEventArgs e)
        {
            if(DGridReceptions.SelectedItem is Entities.Reception currentReception)
            {
                NavigationService.Navigate(new ReceptionCouponPage(currentReception));
            }
        }
    }
}
