using System.Windows;

namespace CryptoDecrypt
{
    public partial class KeyWindow : Window
    {
        public string Key { get; set; }

        public KeyWindow(Window parent)
        {
            Owner = parent;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            Key = tbKey.Text;
            Close();
        }

        private void tbKey_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbKey.Text))
            {
                btnOK.IsEnabled = true;
            }
        }
    }
}
