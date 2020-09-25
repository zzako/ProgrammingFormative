using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProgrammingFormative
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Roodepoort : Page
    {
        public Roodepoort()
        {
            this.InitializeComponent();
            RoutedEventHandler MyMapRoodepoort_Loaded = null;
            MyMapRoodepoort.Loaded += MyMapRoodepoort_Loaded;
        }

        private async void MyMap_Loaded(object sender, RoutedEventArgs e)
        {

            var center =
                new Geopoint(new BasicGeoposition()
                {
                    Latitude = -26.1424795,
                    Longitude = 27.869068200000015

                });

            // retrieve map
            await MyMapRoodepoort.TrySetSceneAsync(Windows.UI.Xaml.Controls.Maps.MapScene.CreateFromLocationAndRadius(center, 3000));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       

        private void btnMapRoodepoort_Click(object sender, RoutedEventArgs e)
        {
            Geopoint geoPosition = new Geopoint(new BasicGeoposition()
            {
                Latitude = -26.1424795,
                Longitude = 27.869068200000015
            });
        }

        private void btnBackRood_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Campuses));
        }
    }
    
}
