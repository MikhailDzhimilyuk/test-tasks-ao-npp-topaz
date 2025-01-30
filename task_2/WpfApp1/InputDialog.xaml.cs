using System.Windows;

namespace WpfApp1
{
    public partial class InputDialog : Window
    {
        public string InputValue { get; private set; } = string.Empty;

        public InputDialog()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(InputTextBox?.Text))
            {
                InputValue = InputTextBox.Text;
                DialogResult = true;
                Close();
            }
        }
    }
}