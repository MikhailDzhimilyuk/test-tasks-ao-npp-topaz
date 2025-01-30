using System.Windows.Input;

namespace WpfApp1
{
    public class SomeViewModel : ViewModelBase
    {
        private string data = string.Empty;

        public string Data
        {
            get => data;
            set
            {
                data = value;
                OnPropertyChanged(nameof(Data));
            }
        }

        public ICommand GetDataCommand => new RelayCommand(() =>
        {
            var ds = new SomeSource();
            Data = ds.GetData();
        });
    }
}