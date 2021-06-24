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
    /// Interaction logic for DoctorPage.xaml
    /// </summary>
    public partial class DoctorPage : Page
    {
        private ClientToothCollection _currTooth;
        private List<ClientToothCollection> _currCollection;
        private UserControls.ToothStatusUserControl _currImage;
        private Reception currentReception;
        private Entities.Appointment _currentAppointment;
        private byte[] _previewData;
        private XrayReception _currXray;
        public int currentStatus = 0;

        public DoctorPage(Entities.Appointment selectedAppointment)
        {
            InitializeComponent();


            comboToothStatus.ItemsSource = AppData.Context.ToothStatus.ToList();
            comboService.ItemsSource = AppData.Context.Services.ToList();

            if (selectedAppointment != null)
            {
                _currentAppointment = selectedAppointment;

                foreach (var toothImage in CanvasTeeth.Children)
                {
                    if (toothImage is UserControls.ToothStatusUserControl currentToothImage)
                        currentToothImage.DataContext = null;

                }

                var currentClient = _currentAppointment.Client;
                _currCollection = currentClient.ClientToothCollections.ToList();

                foreach (var toothImage in CanvasTeeth.Children)
                {
                    if (toothImage is UserControls.ToothStatusUserControl currentToothImage)
                    {
                        LoadToothImage(currentToothImage);
                    }
                }

                DGridReceptions.ItemsSource = AppData.Context.Receptions.ToList().Where(p => p.IdClient == selectedAppointment.IdClient);

                TBlockFullName.Text = _currentAppointment.Client.FullNameClient;
                TBlockPhoneNumber.Text = _currentAppointment.Client.PhoneNumberClient;
                TBlockAddress.Text = _currentAppointment.Client.AddressClient;
                BorderPhoto.DataContext = _currentAppointment.User.PreviewUser;
                TBoxchronicDiseases.Text = _currentAppointment.Client.ChronicDiseases;
                TBoxPastDiseases.Text = _currentAppointment.Client.PastDiseases;
                TBoxCurrentDiseases.Text = _currentAppointment.Client.CurrentDiseases;
                TBoxBadHabit.Text = _currentAppointment.Client.BadHabit;

                var lastDateOfReception = AppData.Context.Appointments.ToList().Last(p => p.IdClient == _currentAppointment.Client.IdClient);
                if(lastDateOfReception != null)
                {
                    TBlockLastReception.Text = lastDateOfReception.DateAppointment.ToString();

                }
                else
                {
                    TBlockLastReception.Text = "-";
                }


                if (LViewXrays != null)
                    LViewXrays.ItemsSource = AppData.Context.XrayReceptions.ToList().Where(p => p.IdClient == _currentAppointment.IdClient);

                ComboTeeth.ItemsSource = AppData.Context.Teeth.ToList();


            }

        }
        private void Element_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            LoadAndUpdateData();
        }




        private void LoadAndUpdateData()
        {
            foreach (var toothImage in CanvasTeeth.Children)
            {
                if (toothImage is UserControls.ToothStatusUserControl currentToothImage)
                    currentToothImage.DataContext = null;
            }

            var currentClient = _currentAppointment.Client;
            _currCollection = currentClient.ClientToothCollections.ToList();





            foreach (var toothImage in CanvasTeeth.Children)
            {
                if (toothImage is UserControls.ToothStatusUserControl currentToothImage)
                {
                    LoadToothImage(currentToothImage);
                }
            }

            if (LViewXrays != null)
                LViewXrays.ItemsSource = AppData.Context.XrayReceptions.ToList().Where(p => p.IdClient == _currentAppointment.IdClient);

            DGridReceptions.ItemsSource = AppData.Context.Receptions.ToList().Where(p => p.IdClient == _currentAppointment.IdClient);

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
            popUpStatus.IsOpen = true;
            try
            {
                _currImage = sender as UserControls.ToothStatusUserControl;
                _currTooth = _currImage.DataContext as ClientToothCollection;

                switch (_currTooth.IdToothStatus)
                {
                    case 1:
                        RadioHelth.IsChecked = true;
                        break;

                    case 2:
                        RadioNeedTreatment.IsChecked = true;
                        break;

                    case 3:
                        RadioCured.IsChecked = true;
                        break;

                    case 4:
                        RadioImplant.IsChecked = true;
                        break;

                    case 5:
                        RadioRemoved.IsChecked = true;
                        break;
                }
                
            }
            catch
            {

            }
        }

    

        private void Radio_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.IsChecked == true)
            {
                var status = AppData.Context.ToothStatus.ToList().FirstOrDefault(p => p.NameToothStatus == radioButton.Tag.ToString());
                _currTooth.IdToothStatus = status.IdToothStatus;
                AppData.Context.SaveChanges();
                LoadToothImage(_currImage);
            }
        }


        private void Tooth_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var currentTag = sender as UserControls.ToothStatusUserControl;
            GridAddTooth.Visibility = Visibility.Visible;
            TboxIdTooth.Text = currentTag.Tag.ToString();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (comboToothStatus.SelectedIndex)
            {
                case 0:
                    currentStatus = 1;
                    break;
                case 1:
                    currentStatus = 2;
                    break;
                case 2:
                    currentStatus = 3;
                    break;
                case 3:
                    currentStatus = 4;
                    break;
                case 4:
                    currentStatus = 5;
                    break;

            }

            //var currentClient = (ComboClients.SelectedItem as Entities.User).Client;

            if(TBoxDiagnosis.Text!="")
            {
                var currentDoctor = AppData.Context.Doctors.ToList().FirstOrDefault(p => p.IdDoctor == Properties.Settings.Default.UserID);
                currentReception = new Entities.Reception
                {
                    IdReception = AppData.Context.Receptions.Max(p => p.IdReception) + 1,
                    DateReception = DateTime.Now,
                    IdClient = _currentAppointment.IdClient,
                    IdDoctor = currentDoctor.IdDoctor,
                    IdService = (comboService.SelectedItem as Entities.Service).IdService,
                    IdAppointment = _currentAppointment.IdAppointment,
                    DiagnosisReception = TBoxDiagnosis.Text
                };

                AppData.Context.Receptions.Add(currentReception);
                AppData.Context.Receptions.ToList();

                AppData.Context.SaveChanges();
                MessageBox.Show("Прием завершен!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);

                NavigationService.Navigate(new ReceptionCouponPage(currentReception));
            }
            else
            {
                MessageBox.Show("Укажите диагноз!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);

            }




        }





        private void comboService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboService.SelectedIndex > -1)
            {
                var currentService = (comboService.SelectedItem as Entities.Service).NameService;
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(TboxIdTooth.Text != "")
            {
                _currTooth = new Entities.ClientToothCollection
                {
                    IdClientToothCollection = AppData.Context.ClientToothCollections.Max(p => p.IdClientToothCollection) + 1,
                    IdClient = _currentAppointment.IdClient,
                    IdUser = _currentAppointment.IdClient,
                    IdTooth = Int32.Parse(TboxIdTooth.Text),
                    IdToothStatus = (comboToothStatus.SelectedItem as Entities.ToothStatu).IdToothStatus
                };
                AppData.Context.ClientToothCollections.Add(_currTooth);
                AppData.Context.ClientToothCollections.ToList();
                AppData.Context.SaveChanges();
                if (MessageBox.Show("Информация добавлена!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                {
                    CanvasTeeth.Visibility = Visibility.Hidden;
                    CanvasTeeth.Visibility = Visibility.Visible;


                }
            }
            else
            {
                MessageBox.Show("Укажите зуб для добавления!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
            }
          
        }

        private void HLinkAllReceptions_Click(object sender, RoutedEventArgs e)
        {
            GridProfile.Visibility = Visibility.Collapsed;
            GridAddTooth.Visibility = Visibility.Collapsed;
            GridReceptions.Visibility = Visibility.Visible;
        }

        private void HLinkTeethCard_Click(object sender, RoutedEventArgs e)
        {
            GridProfile.Visibility = Visibility.Collapsed;
            GridReceptions.Visibility = Visibility.Collapsed;
            GridAddTooth.Visibility = Visibility.Visible;
        }

        private void HLinkPersonalInfo_Click(object sender, RoutedEventArgs e)
        {
            GridProfile.Visibility = Visibility.Visible;
            GridReceptions.Visibility = Visibility.Collapsed;
            GridAddTooth.Visibility = Visibility.Collapsed;
        }

        private void BtnEditAdditionalInfo_Click(object sender, RoutedEventArgs e)
        {
            if(_currentAppointment!=null)
            {
                 _currentAppointment.Client.ChronicDiseases = TBoxchronicDiseases.Text;
                 _currentAppointment.Client.PastDiseases = TBoxPastDiseases.Text;
                 _currentAppointment.Client.CurrentDiseases = TBoxCurrentDiseases.Text;
                _currentAppointment.Client.BadHabit = TBoxBadHabit.Text;
                AppData.Context.SaveChanges();
                AppData.Context.Appointments.ToList();
                MessageBox.Show("Успешно", "Информация", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
        }

        private void BtnAddDental_Click(object sender, RoutedEventArgs e)
        {
            if(ComboTeeth.SelectedIndex>-1)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Images | *.jpg;*.png;*.jpeg";
                if (ofd.ShowDialog() == true)
                {
                    _previewData = File.ReadAllBytes(ofd.FileName);
                }

                PreviewXray.DataContext = _previewData;

                _currXray = new Entities.XrayReception
                {
                    IdXrayReception = AppData.Context.XrayReceptions.ToList().Max(p => p.IdXrayReception) + 1,
                    IdClient = _currentAppointment.IdClient,
                    IdDoctor = _currentAppointment.IdDoctor,
                    IdTooth = (ComboTeeth.SelectedItem as Entities.Tooth).IdTooth,
                    DateOfXray = DateTime.Now
                    
                };
                if (_previewData != null)
                    _currXray.PreviewXray = _previewData;

                AppData.Context.XrayReceptions.Add(_currXray);
                AppData.Context.SaveChanges();
               if( MessageBox.Show("Успешно", "Внимание", MessageBoxButton.OK, MessageBoxImage.Asterisk)==MessageBoxResult.OK)
                {

                    GridFullInfo.Visibility = Visibility.Hidden;
                    GridFullInfo.Visibility = Visibility.Visible;
                }
            }
            else
            {
                MessageBox.Show("Выберите конкретный зуб", "Внимание", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
        }

        private void ButtonAdditionalInfo_Click(object sender, RoutedEventArgs e)
        {
            GridAdditionalInfo.Visibility = Visibility.Visible;
            GridDental_Xrays.Visibility = Visibility.Collapsed;
        }

        private void ButtonXRays_Click(object sender, RoutedEventArgs e)
        {
            GridDental_Xrays.Visibility = Visibility.Visible;
            GridAdditionalInfo.Visibility = Visibility.Collapsed;
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string keyWord = TBoxSearch.Text.ToLower();
            DGridReceptions.ItemsSource = AppData.Context.Receptions.ToList().Where(p => p.IdClient == _currentAppointment.IdClient)
                        .Where(p =>
                        p.Doctor.FullNameDoctor.ToLower().Contains(keyWord) ||
                        p.DiagnosisReception.ToLower().Contains(keyWord) ||
                        p.DateReception.ToString().Contains(keyWord) ||
                        p.Appointment.ComplaintAppointment.ToLower().Contains(keyWord)||
                        p.Service.NameService.ToLower().Contains(keyWord) ||
                        p.Service.PriceService.ToString().Contains(keyWord)
                        ).ToList();
        }
    }
}
