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

namespace rezervacka
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


        private void btnReservation_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem selectedFilm = (ComboBoxItem)cmbFilms.SelectedItem;
            if (selectedFilm == null)
            {
                MessageBox.Show("Please select a film.");
                return;
            }

            string filmName = selectedFilm.Content.ToString();
            string seatType = "";
            /*
            if (rbPremium.IsChecked == true)
            {

            }
            else
            {

            }
            */

            seatType = rbPremium.IsChecked == true ? "premium" : "standard";

            //doplňky
        }
    }
}