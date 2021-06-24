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
    /// Interaction logic for ReceptionCouponPage.xaml
    /// </summary>
    public partial class ReceptionCouponPage : Page
    {
        private Entities.Reception _curentReception;
        private ClientToothCollection _currTooth;
        private List<ClientToothCollection> _currCollection;
        private UserControls.ToothStatusUserControl _currImage;
        public ReceptionCouponPage(Entities.Reception selectedReception)
        {
            InitializeComponent();
            if (selectedReception != null)
            {
                _curentReception = selectedReception;

                foreach (var toothImage in CanvasCoupon.Children)
                {
                    if (toothImage is UserControls.ToothStatusUserControl currentToothImage)
                        currentToothImage.DataContext = null;

                }

                var currentClient = _curentReception.Client;
                _currCollection = currentClient.ClientToothCollections.ToList();

                foreach (var toothImage in CanvasCoupon.Children)
                {
                    if (toothImage is UserControls.ToothStatusUserControl currentToothImage)
                    {
                        LoadToothImage(currentToothImage);
                    }
                }

                TBlockDiagnosis.Text = _curentReception.DiagnosisReception;
                TBlockComplaint.Text = _curentReception.Appointment.ComplaintAppointment;
                TBlockNameClient.Text = _curentReception.Client.FullNameClient;
                TBlockCurrent.Text = _curentReception.Client.CurrentDiseases;
                TBlockBefore.Text = _curentReception.Client.PastDiseases;
                
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

        private void TBoxNumber_Loaded(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int CardValue = rnd.Next(0, 1000);
            TBlockNumber.Text = CardValue.ToString();
        }

        private void TBlockDate_Loaded(object sender, RoutedEventArgs e)
        {
            TBlockDate.Text = DateTime.Now.ToString("g");
        }

        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                GridCanvas.Visibility = Visibility.Hidden;

                printDialog.PrintVisual(CanvasCoupon, "Распечатываем элемент Canvas");

                GridCanvas.LayoutTransform = null;
                GridCanvas.Visibility = Visibility.Visible;
            }
            NavigationService.GoBack();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            TBlockRecomendations.Text = TBoxCurrentRecomendations.Text;
        }
    }
}

