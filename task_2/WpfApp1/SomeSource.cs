using System.Windows;

namespace WpfApp1
{
    public class SomeSource
    {
        public event EventHandler<string>? DataSubmittedEvent;

        public async Task<string> GetData()
        {
            var inputDialog = new InputDialog();

            inputDialog.DataSubmittedEvent += (sender, data) =>
            {
                DataSubmittedEvent?.Invoke(this, data);
                inputDialog.Close();
            };

            inputDialog.Show();

            while (inputDialog.IsVisible)
            {
                await Task.Delay(100);
            }

            return string.Empty;
        }
    }
}