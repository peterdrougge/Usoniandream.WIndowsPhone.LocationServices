using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Device.Location;

namespace Usoniandream.WindowsPhone.LocationServices.Models.Bing
{
    public class BingMapLocation
    {
        public string Address { get; set; }
        public GeoCoordinate Coordinates { get; set; }


        public string FormattedAddress { get; set; }

        public string District { get; set; }
    }
}
