using Dentistry.Entities;
using Microsoft.Win32;
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
    /// Interaction logic for PersonalAreaPage.xaml
    /// </summary>
    public partial class PersonalAreaPage : Page
    {
        private byte[] _previewData;
        private User _currentUser;
        private List<ClientToothCollection> _currCollection;
        public PersonalAreaPage(Entities.User selectedUser)
        {
            InitializeComponent();
            LoadAndUpdateData();

           


        }

        private void LoadAndUpdateData()
        {
            int userId = Properties.Settings.Default.UserID;
            if (userId > 0)
            {
                var currentUser = AppData.Context.Users.ToList().FirstOrDefault(p => p.IdUser == userId);
                var currentClient = AppData.Context.Clients.ToList().FirstOrDefault(p => p.IdClient == userId);
                _currCollection = AppData.Context.ClientToothCollections.ToList().Where(p => p.IdClient == userId).ToList();

                if (currentUser != null && currentClient != null && _currCollection != null)
                {


                    this.DataContext = currentUser;

                }

                var a = CanvasTeeth.Children.Count;
                foreach (var toothImage in CanvasTeeth.Children)
                {
                    if (toothImage is UserControls.ToothStatusUserControl currentToothImage)
                    {
                        LoadToothImage(currentToothImage);
                    }
                }

            }

        }

        private void LoadToothImage(UserControls.ToothStatusUserControl currentImage)
        {
            var currentTooth = _currCollection.FirstOrDefault(p => p.IdTooth.ToString() == currentImage.Tag.ToString());
            if (currentTooth != null)
            {
                currentImage.DataContext = null;
                currentImage.DataContext = currentTooth;

            }
        }

        private void Tooth_MouseEnter(object sender, MouseEventArgs e)
        {
           


        }

        private void Radio_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Tooth_MouseLeave(object sender, MouseEventArgs e)
        {
        }

        private void NavigateUser(Entities.User currentUser)
        {
            switch (currentUser.IdPosition)
            {

                case 2:
                    NavigationService.Navigate(new Pages.MedicalCouponPage());
                    break;

                case 3:
                    NavigationService.Navigate(new Pages.MedicalCouponPage());
                    break;

                default:
                    break;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var UserId = Properties.Settings.Default.UserID;
            if (UserId > 0)
            {

                var currentUser = AppData.Context.Users.ToList().FirstOrDefault(p => p.IdUser == UserId);

            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            var UserId = Properties.Settings.Default.UserID;
            var currentUser = AppData.Context.Users.ToList().FirstOrDefault(p => p.IdUser == UserId);
            if (currentUser != null)
            {
                NavigateUser(currentUser);
            };
        }



        private void HLinkPersonalInfo_Click(object sender, RoutedEventArgs e)
        {
            GridCanvas.Visibility = Visibility.Collapsed;
            GridEditInfo.Visibility = Visibility.Visible;
            CanvasTeeth.Visibility = Visibility.Collapsed;
            GridEditInfo.DataContext = AppData.CurrentUser;
        }

        private void HLinkTeethCard_Click(object sender, RoutedEventArgs e)
        {
            GridEditInfo.Visibility = Visibility.Collapsed;
            GridCanvas.Visibility = Visibility.Visible;
            CanvasTeeth.Visibility = Visibility.Visible;
        }

        private void BtnChooseImg_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images | *.jpg;*.png;*.jpeg";
            if (ofd.ShowDialog() == true)
            {
                _previewData = File.ReadAllBytes(ofd.FileName);
            }

            ImgPreview.DataContext = _previewData;
        }

        private void OnConfPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PBoxPass.Password.Length > 0)
                TBlockPass.Visibility = Visibility.Collapsed;
            else
                TBlockPass.Visibility = Visibility.Visible;
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PBoxPass.Password.Length > 0)
                TBlockPass.Visibility = Visibility.Collapsed;
            else
                TBlockPass.Visibility = Visibility.Visible;
        }

        private void BtnEditInfo_Click(object sender, RoutedEventArgs e)
        {
            if (_currentUser != null)
            {
                _currentUser.NameUser = TBoxName.Text;
                _currentUser.LastNameUser = TBoxLastName.Text;
                _currentUser.PatronymicUser = TBoxPatronymic.Text;
                _currentUser.DateOfBirthUser = DtpBirthDate.SelectedDate;
                _currentUser.LoginUser = TBoxLogin.Text;
                _currentUser.PasswordUser = PBoxPass.Password;
                _currentUser.Client.SeriesOfPassportClient = TBoxSerie.Text;
                _currentUser.Client.NumberOfPassportClient = TBoxNumber.Text;
                _currentUser.Client.PhoneNumberClient = TBoxPhoneNumber.Text;
                if (_previewData != null)
                    _currentUser.PreviewUser = _previewData;

                
                
            }
            AppData.Context.SaveChanges();
            AppData.Context.Users.ToList();
            MessageBox.Show("Успешно", "Информация", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

    }
}
