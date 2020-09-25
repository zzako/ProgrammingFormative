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
    public sealed partial class Boksburg : Page
    {
        public Boksburg()
        {
            this.InitializeComponent();
            RoutedEventHandler MyMapBoksburg_Loaded = null;
            MyMapBoksburg.Loaded += MyMapBoksburg_Loaded;
        }
        private async void MyMapBoksburg_Loaded(object sender, RoutedEventArgs e)
        {
            // center on Notre Dame Cathedral       
            var center =
                new Geopoint(new BasicGeoposition()
                {
                    Latitude = -26.1011179,
                    Longitude = 28.061614100000043

                });

            // retrieve map
            await MyMapBoksburg.TrySetSceneAsync(Windows.UI.Xaml.Controls.Maps.MapScene.CreateFromLocationAndRadius(center, 3000));
        }
      

        private void btnMapBoksburg_Click(object sender, RoutedEventArgs e)
        {
            Geopoint geoPosition = new Geopoint(new BasicGeoposition()
            {
                Latitude = -26.1011179,
                Longitude = 28.061614100000043
            });
        }

        private void btnBackBok_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Campuses));
        }
    }
}
