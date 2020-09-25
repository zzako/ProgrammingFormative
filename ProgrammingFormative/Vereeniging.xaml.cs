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
    public sealed partial class Vereeniging : Page
    {
        public Vereeniging()
        {
            this.InitializeComponent();
            RoutedEventHandler MyMapVereeniging_Loaded = null;
            MyMapVereeniging.Loaded += MyMapVereeniging_Loaded;
        }
        private async void MyMapVereeniging_Loaded(object sender, RoutedEventArgs e)
        {
                
            var center =
                new Geopoint(new BasicGeoposition()
                {
                    Latitude = -26.6615635,
                    Longitude = 27.976229699999976

                });

            // retrieve map
            await MyMapVereeniging.TrySetSceneAsync(Windows.UI.Xaml.Controls.Maps.MapScene.CreateFromLocationAndRadius(center, 3000));
        }
        private void btnMapVereeniging_Click(object sender, RoutedEventArgs e)
        {
            Geopoint geoPosition = new Geopoint(new BasicGeoposition()
            {
                Latitude = -26.6615635,
                Longitude = 27.976229699999976
            });
        }

        private void btnBackVer_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Campuses));
        }
    }
    
}
