using System.Windows;

namespace WpfApp1
{
    public partial class InputDialog : Window
    {
        public event EventHandler<string>? DataSubmittedEvent;

        public InputDialog()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(InputTextBox?.Text))
            {
                DataSubmittedEvent?.Invoke(this, InputTextBox.Text);
            }
        }
    }
}