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
    public sealed partial class AucklandPark : Page
    {
        public AucklandPark()
        {
            this.InitializeComponent();
            RoutedEventHandler MyMap_Loaded = null;
            MyMap.Loaded += MyMap_Loaded;
        }

        private async void MyMap_Loaded(object sender, RoutedEventArgs e)
        {
            // center on Notre Dame Cathedral       
            var center =
                new Geopoint(new BasicGeoposition()
                {
                    Latitude = -26.18263,
                    Longitude = 28.00396999999998

                });

            // retrieve map
            await MyMap.TrySetSceneAsync(Windows.UI.Xaml.Controls.Maps.MapScene.CreateFromLocationAndRadius(center, 3000));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnMap_Click(object sender, RoutedEventArgs e)
        {
            Geopoint geoPosition = new Geopoint(new BasicGeoposition()
            {
                Latitude = -26.18263,
                Longitude = 28.00396999999998
            });
        }
        private void btnBackAuck_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Campuses));
        }


    }
}
