using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Dentistry.UserControls
{
    /// <summary>
    /// Interaction logic for ToothStatusUserControl.xaml
    /// </summary>
    public partial class ToothStatusUserControl : UserControl
    {
        private ImageSource _source;

        public ImageSource Source
        {
            get
            {
                return _source;
            }
            set
            {
                _source = value;
                OnPropertyChanged("Source");
                ImageTooth.Source = value;
            }
        }

        public ToothStatusUserControl()
        {
            InitializeComponent();
           
        }

        private void UserControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            LoadToothmage();
        }

        private void LoadToothmage()
        {
            //if (DataContext is Entities.ClientToothCollection currentTooth)
            //{
            //    BlockStatus.Text = currentTooth.ToothStatu.NameToothStatus;

            //    switch (currentTooth.IdToothStatus)
            //    {
            //        case 1:
            //            ImageSource imageHealth = new BitmapImage(new Uri(@"E:\Teeth\11.png", UriKind.RelativeOrAbsolute));
            //            Source = imageHealth;
            //            break;

            //        case 2:
            //            ImageSource imageBroke = new BitmapImage(new Uri(@"E:\Teeth\11-red.png", UriKind.RelativeOrAbsolute));
            //            Source = imageBroke;
            //            break;

            //        case 3:
            //            ImageSource imageCured = new BitmapImage(new Uri(@"E:\Teeth\22-green.png", UriKind.RelativeOrAbsolute));
            //            Source = imageCured;
            //            break;

            //        case 4:
            //            ImageSource imageBrokeDied = new BitmapImage(new Uri(@"E:\Teeth\44-skyblue.png", UriKind.RelativeOrAbsolute));
            //            Source = imageBrokeDied;
            //            break;

            //        case 5:
            //            ImageSource imageBrokenImp = new BitmapImage(new Uri(@"E:\Teeth\44-skyblue.png", UriKind.RelativeOrAbsolute));
            //            Source = imageBrokenImp;
            //            break;
            //    }
            //    //ImageTooth.Source = Source;
            //    //if (currentTooth.Tooth.IdTooth == )
            //}
        }

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
