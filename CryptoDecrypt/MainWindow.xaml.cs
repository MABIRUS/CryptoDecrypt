using System.Windows;
using System.Windows.Controls;

namespace CryptoDecrypt
{

    public partial class MainWindow : Window
    {
         
        List<string> cipherList = new List<string>()
        {"Morse Cipher", "Caesar Cipher", "Vigenère Cipher", "Playfair Cipher", "Hill Cipher"};

        public MainWindow()
        {
            InitializeComponent();
            cbCipher.ItemsSource = cipherList;
        }

        private void btnEncrypt_Click(object sender, RoutedEventArgs e) => tbCrypted.Text = cipherChoice(tbSource.Text);

        private void btnDecrypt_Click(object sender, RoutedEventArgs e) => tbSource.Text = cipherChoice(tbCrypted.Text);

        private void cbCipher_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!btnEncrypt.IsEnabled)
                btnEncrypt.IsEnabled = true;
                btnDecrypt.IsEnabled = true;
        }


        private string cipherChoice(string inputText)
        {
            Cipher cipher = new Cipher(inputText);

            string outputText = string.Empty;

            switch (cbCipher.SelectedIndex)
            {
                case 0:
                    cipher.MorseCipher();
                    outputText = cipher.Text;
                    break;
                case 1:

                    int key;
                    KeyWindow keyWindow = new KeyWindow(this);

                    Opacity = 0.7;
                    keyWindow.ShowDialog();
                    Opacity = 1;

                    if (int.TryParse(keyWindow.Key, out key))
                    {
                        cipher.CaesarCipher(key);
                        outputText = cipher.Text;
                    }
                    else MessageBox.Show( "The key must be a number.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);

                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }

            return outputText;
        }
    }
}