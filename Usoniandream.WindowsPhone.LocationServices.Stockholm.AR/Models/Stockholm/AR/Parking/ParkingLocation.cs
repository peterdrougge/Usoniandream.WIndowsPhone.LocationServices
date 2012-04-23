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
using GART.Data;
using System.Device.Location;

namespace Usoniandream.WindowsPhone.LocationServices.Stockholm.AR.Models.Stockholm.AR.Parking
{
    public class ParkingLocation : ARItem, Usoniandream.WindowsPhone.LocationServices.Models.ILocation
    {
        public GeoCoordinate Location { get { return GeoLocation; } set { GeoLocation = value; } }
    }
}
