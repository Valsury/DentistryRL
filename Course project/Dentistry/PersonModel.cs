using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dentistry
{
    public class PersonModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Login { get; set; } = "";
        public string Password { get; set; } = "";

        private string _errorText;


        public void CheckError(string text)
        {
            string error = String.Empty;
            switch (text)
            {
                case "Login":
                    if (Login.Length > 5)
                    {
                        error = "Логин не больше 5 символов";
                    }
                    break;
                case "Password":

                    break;
                case "navigate":

                    break;
            }
            ErrorText = error;
        }

        public string ErrorText
        {
            get { return _errorText; }
            set
            {
                _errorText = value;
                OnPropertyChanged();
            }
        }

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}