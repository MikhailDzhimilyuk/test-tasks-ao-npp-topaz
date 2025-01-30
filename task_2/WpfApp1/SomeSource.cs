using System.Windows;

namespace WpfApp1
{
    public class SomeSource
    {
        public string GetData()
        {
            var inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                return inputDialog.InputValue;
            }
            return string.Empty;
        }
    }
}