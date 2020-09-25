using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProgrammingFormative
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Campuses : Page
    {
        public Campuses()
        {
            this.InitializeComponent();
        }

        private void btnAucklandPark_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AucklandPark));
            
        }

       
                private void btnSandton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Sandton));
        }

        private void btnRoodepoort_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Roodepoort));
        }

        private void btnBoksburg_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Boksburg));
        }

        private void btnVereeniging_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Vereeniging));
        }

        private void btnPretoria_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Pretoria));
        }

        private void btnBackHome_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
