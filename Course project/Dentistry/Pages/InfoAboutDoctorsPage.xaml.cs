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
    /// Interaction logic for InfoAboutDoctorsPage.xaml
    /// </summary>
    public partial class InfoAboutDoctorsPage : Page
    {
        public InfoAboutDoctorsPage()
        {
            InitializeComponent();
            {



                DGridUsers.ItemsSource = AppData.Context.Users.ToList().Where(p => p.IdPosition == 3);





            }

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            DGridUsers.ItemsSource = AppData.Context.Users.ToList().Where(p => p.IdPosition == 3);
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string keyWord = TBoxSearch.Text.ToLower();

            DGridUsers.ItemsSource = AppData.Context.Users.ToList().Where(p => p.IdPosition == 3)
           .Where(p =>
           p.NameUser.ToLower().Contains(keyWord) ||
           p.LastNameUser.ToLower().Contains(keyWord) ||
           p.PatronymicUser.ToLower().Contains(keyWord) ||
           p.Doctor.Department.NameDepartment.ToLower().Contains(keyWord) ||
           p.Doctor.PhoneNumberDoctor.ToLower().Contains(keyWord) ||
           p.Doctor.WorkExperienceDoctor.ToLower().Contains(keyWord) ||
           p.DateOfBirthUser.ToString().Contains(keyWord)).ToList();


        }

        private void UpdateItems()
        {

            var allUsers = AppData.Context.Users.ToList().Where(p => p.IdPosition == 3);
            var allDoctors = AppData.Context.Doctors.ToList();
            switch (ComboFilter.SelectedIndex)
            {
                case 0:
                    allUsers = allUsers.OrderBy(p => p.NameUser).ToList();
                    break;

                case 1:
                    allUsers = allUsers.OrderBy(p => p.LastNameUser).ToList();
                    break;

                case 2:
                    allUsers = allUsers.OrderBy(p => p.PatronymicUser).ToList();
                    break;

                case 3:
                    allUsers = allUsers.OrderBy(p => p.DateOfBirthUser).ToList();
                    break;

                case 4:
                    allDoctors = allDoctors.OrderBy(p => p.Department.NameDepartment).ToList();
                    break;

                case 5:
                    allDoctors = allDoctors.OrderBy(p => p.WorkExperienceDoctor).ToList();
                    break;

                case 6:
                    allDoctors = allDoctors.OrderBy(p => p.PhoneNumberDoctor).ToList();
                    break;

                default:
                    allUsers = allUsers.OrderBy(p => p.IdDoctor).ToList();
                    break;
            }
            if (DGridUsers != null)
            {
                DGridUsers.ItemsSource = allDoctors;
                DGridUsers.ItemsSource = allUsers;
            }
        }

        private void ComboFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateItems();
        }

        private void BtnChangeData_Click(object sender, RoutedEventArgs e)
        {
            if (DGridUsers.SelectedItem is Entities.User currentUser)
            {
                NavigationService.Navigate(new EditDoctorPage(currentUser));


            }

            else
            {
                MessageBox.Show("Выберите данные для редактирования!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnAddData_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditDoctorPage(null));
        }

        private void BtnDeleteData_Click(object sender, RoutedEventArgs e)
        {
            if (DGridUsers.SelectedItem is Entities.User currentUser)
            {
                if (MessageBox.Show("Вы действительно хотите удалить данные?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {  

                    


                    AppData.Context.Users.Remove(currentUser);
                    AppData.Context.SaveChanges();
                    AppData.Context.Users.ToList();
                    AppData.Context.Clients.ToList();
                    if(MessageBox.Show("Успешно", "Информация", MessageBoxButton.OK, MessageBoxImage.Asterisk)==MessageBoxResult.OK)
                    {
                        DGridUsers.Visibility = Visibility.Hidden;
                        DGridUsers.Visibility = Visibility.Visible;
                    }
                        

                }
            }
        }

        private void BtnReportData_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReportDoctorPage());
        }

        private void DGridUsers_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            DGridUsers.DataContext = null;
            DGridUsers.ItemsSource = AppData.Context.Users.ToList().Where(p => p.IdPosition == 3);
            AppData.Context.Doctors.ToList();
             AppData.Context.Users.ToList();
        }
    }
}

