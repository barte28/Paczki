using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double cena = 0;
            if (postcard_RadioButton.IsChecked == true)
            {
                cena = 1;
                imagemodyfikowany_Image.Source = new BitmapImage(new Uri("postcard.png", UriKind.Relative));
                cena_TextBlock.Text = "Cena: " + cena + "zł";
            }
            if (letter_RadioButton.IsChecked == true)
            {
                cena = 1.5;
                imagemodyfikowany_Image.Source = new BitmapImage(new Uri("letter.png", UriKind.Relative));
                cena_TextBlock.Text = "Cena: " + cena + "zł";
            }
            if (box_RadioButton.IsChecked == true)
            {
                cena = 10;
                imagemodyfikowany_Image.Source = new BitmapImage(new Uri("box.png", UriKind.Relative));
                cena_TextBlock.Text = "Cena: " + cena + "zł";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string kodPocztowy = kodPocztowy_TextBOx.Text;
            int kodPocztowyInt;

            if (int.TryParse(kodPocztowy, out kodPocztowyInt))
            {
                if (kodPocztowy.Length == 5)
                {
                    MessageBox.Show("Dane przesyłki zostały wprowadzone");
                }
                else
                {
                    MessageBox.Show("Kod pocztowy musi zawierać 5 cyfr");
                }
            }
            else
            {
                MessageBox.Show("Kod pocztowy musi być liczbą");
            }
        }
    }
}