using System.ComponentModel;

namespace FindMyValueConverter.App
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _on;

        public bool On
        {
            get { return _on; }
            set
            {
                _on = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("On"));
            }
        }
    }
}
