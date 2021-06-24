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
    /// Interaction logic for InfoAboutAppointmentsPage.xaml
    /// </summary>
    public partial class InfoAboutAppointmentsPage : Page
    {

        public InfoAboutAppointmentsPage()
        {
            InitializeComponent();
            DGridAppointments.ItemsSource = AppData.Context.Appointments.ToList().Where(p => p.IdDoctor == Properties.Settings.Default.UserID);
        }

       

        private void DGridAppointments_Loaded(object sender, RoutedEventArgs e)
        {
            
        }


        private void DGridAppointments_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }


        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            DGridAppointments.ItemsSource = AppData.Context.Appointments.ToList().Where(p => p.IdDoctor == Properties.Settings.Default.UserID);
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string keyWord = TBoxSearch.Text.ToLower();
            DGridAppointments.ItemsSource = AppData.Context.Appointments.ToList().Where(p => p.IdDoctor == Properties.Settings.Default.UserID)
           .Where(p =>
           p.Client.FullNameClient.ToLower().Contains(keyWord) ||
           p.ComplaintAppointment.ToLower().Contains(keyWord) ||
           p.DateAppointment.ToString().Contains(keyWord)).ToList();
        }

        private void HLinkFullInfo_Click(object sender, RoutedEventArgs e)
        {
            if (DGridAppointments.SelectedItem is Entities.Appointment currentAppointment)
            {
                NavigationService.Navigate(new DoctorPage(currentAppointment));
            }
        }

        private void BtnDeleteData_Click(object sender, RoutedEventArgs e)
        {
            if (DGridAppointments.SelectedItem is Entities.Appointment currentAppointment)
            {

                if (MessageBox.Show("Вы действительно хотите удалить данные?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {


                    AppData.Context.Appointments.Remove(currentAppointment);
                    AppData.Context.SaveChanges();
                    DGridAppointments.ItemsSource = AppData.Context.Appointments.ToList().Where(p => p.IdDoctor == Properties.Settings.Default.UserID);


                }
            }
        }
    }
}

