using System.ComponentModel;

namespace MauiApp1.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        string text;
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged(nameof(Text));
                // nameof grabs the name of the variable/class/input. It does not give values.
                // eg. string cat = "meow"; nameof(cat) -> "cat" not "meow".
            }
        }

        public event PropertyChangedEventHandler PropertyChanged; // Its a field that needs to be implemented from INotifyPropertyChanged.
        // PropertyChangedEventHandler is an event handler object
        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
