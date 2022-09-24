using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace BestFriendsApp.ViewModels
{
    public class Page1ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!(object.Equals(field, newValue)))
            {
                field = (newValue);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }

        private string text;

        public string Text { get => text; set => SetProperty(ref text, value); }

        private Command buttonCommand;

        public ICommand ButtonCommand
        {
            get
            {
                if (buttonCommand == null)
                {
                    buttonCommand = new Command(Button);
                }

                return buttonCommand;
            }
        }

        private void Button()
        {
        }
    }
}