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
    public class BingMapLocation : ILocation
    {
        public string Address { get; set; }
        public string FormattedAddress { get; set; }

        public string District { get; set; }

        public GeoCoordinate Location { get; set; }
        public object Content { get; set; }
    }
}
