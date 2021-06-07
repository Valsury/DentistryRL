using Dentistry.Entities;
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
    /// Interaction logic for DoctorPage.xaml
    /// </summary>
    public partial class DoctorPage : Page
    {
        private ClientToothCollection _currTooth;
        private List<ClientToothCollection> _currCollection;
        private UserControls.ToothStatusUserControl _currImage;
        private Reception currentReception;
        public int currentStatus = 0;

        public DoctorPage()
        {
            InitializeComponent();

            var currentClients = AppData.Context.Users.ToList().Where(p => p.IdPosition == 2);
            ComboClients.ItemsSource = currentClients;
            comboService.ItemsSource = AppData.Context.Services.ToList();


        }
        private void Element_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            LoadAndUpdateData();
        }

        private void ComboClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
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


            if (ComboClients.SelectedIndex > -1)
            {
                var currentClient = (ComboClients.SelectedItem as Entities.User).Client;
                _currCollection = currentClient.ClientToothCollections.ToList();





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
                popUpStatus.IsOpen = true;
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

        private void Tooth_MouseLeave(object sender, MouseEventArgs e)
        {
            popUpStatus.IsOpen = false;
        }

        private void Tooth11_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            _currImage = sender as UserControls.ToothStatusUserControl;


            GridAddTooth.Visibility = Visibility.Visible;


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

            var currentClient = (ComboClients.SelectedItem as Entities.User).Client;
            _currTooth = new Entities.ClientToothCollection
            {
                IdClientToothCollection = AppData.Context.ClientToothCollections.Max(p => p.IdClientToothCollection) + 1,
                IdClient = currentClient.IdClient,
                IdUser = currentClient.IdClient,
                IdTooth = Int32.Parse(TboxIdTooth.Text),
                IdToothStatus = currentStatus
            };
            AppData.Context.ClientToothCollections.Add(_currTooth);
            AppData.Context.ClientToothCollections.ToList();

            var currentDoctor = AppData.Context.Doctors.ToList().FirstOrDefault(p => p.IdDoctor == Properties.Settings.Default.UserID);
            currentReception = new Entities.Reception
            {
                IdReception = AppData.Context.Receptions.Max(p => p.IdReception) + 1,
                DateReception = DateTime.Now,
                IdClient = currentClient.IdClient,
                IdDoctor = currentDoctor.IdDoctor,
                IdService = (comboService.SelectedItem as Entities.Service).IdService,
                DiagnosisReception = TBoxDiagnosis.Text
            };

            AppData.Context.Receptions.Add(currentReception);
            AppData.Context.Receptions.ToList();

            AppData.Context.SaveChanges();

            if (MessageBox.Show("Информация добавлена!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
            {
                CanvasTeeth.Visibility = Visibility.Hidden;
                CanvasTeeth.Visibility = Visibility.Visible;


            }

        }




        private void BtnDocotrReceptions_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CurrentReceptionsPage());
        }

        private void comboService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(comboService.SelectedIndex >-1)
            {
                var currentService = (comboService.SelectedItem as Entities.Service).NameService;
            }
        }
    }
}
