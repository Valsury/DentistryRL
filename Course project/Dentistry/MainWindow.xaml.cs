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

namespace Dentistry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //var cuurentTooth = AppData.Context.Teeth.ToList()[31];
            //cuurentTooth.PhotoTooth = File.ReadAllBytes(@"C:\Users\valsu\OneDrive\Desktop\Teeth\48.png");
            MainFrame.Navigate(new LoginPage());
            AppData.Context.SaveChanges();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {

            var page = MainFrame.Content as Page;

            if (page is AdminMenuPage || page is Pages.PersonalAreaPage || page is Pages.DoctorPage)
            {
                Properties.Settings.Default.UserID = 0;
                Properties.Settings.Default.Save();
            }

            if (MainFrame.CanGoBack)
                MainFrame.GoBack();


        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            var page = (sender as Frame).Content as Page;

            if (page is LoginPage)
            {
                BtnBack.Visibility = Visibility.Collapsed;
                BtnExit.Visibility = Visibility.Visible;
            }
            else
            {
                BtnBack.Visibility = Visibility.Visible;
                BtnExit.Visibility = Visibility.Collapsed;
            }

            if (page is LoginPage)
            {
                ImgLogo.Visibility = Visibility.Visible;
                TBlockTitle.HorizontalAlignment = HorizontalAlignment.Center;
            }
            else
            {
                ImgLogo.Visibility = Visibility.Collapsed;
                TBlockTitle.HorizontalAlignment = HorizontalAlignment.Left;
            }

        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch { }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
