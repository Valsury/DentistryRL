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
    /// Interaction logic for Admin_sReceptionsPage.xaml
    /// </summary>
    public partial class Admin_sReceptionsPage : Page
    {
        public Admin_sReceptionsPage()
        {
            InitializeComponent();
            UpdateItems();
        }

        private void UpdateItems()
        {
            var allReceptions = AppData.Context.Receptions.ToList();
            DGridReceptions.ItemsSource = allReceptions;



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

                case 6:
                    allReceptions = allReceptions.OrderBy(p => p.PaymentStatus).ToList();
                    break;

                case 7:
                    allReceptions = allReceptions.OrderBy(p => p.Appointment.ComplaintAppointment).ToList();
                    break;

                default:
                    allReceptions = allReceptions.OrderBy(p => p.IdReception).ToList();
                    break;
            }


            string keyWord = TBoxSearch.Text.ToLower();
            DGridReceptions.ItemsSource = AppData.Context.Receptions.ToList()
                .Where(p =>
                p.Client.FullNameClient.ToLower().Contains(keyWord) ||
                p.Doctor.FullNameDoctor.ToLower().Contains(keyWord) ||
                p.DiagnosisReception.ToLower().Contains(keyWord) ||
                p.DateReception.ToString().Contains(keyWord) ||
                p.Appointment.ComplaintAppointment.ToLower().Contains(keyWord)||
                p.Service.NameService.ToLower().Contains(keyWord) ||  
                p.Service.PriceService.ToString().Contains(keyWord) ||
                p.PaymentStatus.ToLower().Contains(keyWord)
                ).ToList();
           
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateItems();
        }

        private void ComboFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateItems();
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

        private void BtnChangeData_Click(object sender, RoutedEventArgs e)
        {
            if (DGridReceptions.SelectedItem is Entities.Reception currentReception)
                NavigationService.Navigate(new AddReceptionPage(currentReception));
        }

        private void BtnAddData_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddReceptionPage(null));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateItems();
        }
    }
}
