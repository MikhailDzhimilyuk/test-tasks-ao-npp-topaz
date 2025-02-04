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

        public ICommand GetDataCommand => new RelayCommand(async () =>
        {
            var ds = new SomeSource();
            ds.DataSubmittedEvent += (sender, data) => { Data = data; };

            await ds.GetData();
        });
    }
}