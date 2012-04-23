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
using Usoniandream.WindowsPhone.LocationServices.Models;
using System.Device.Location;

namespace Usoniandream.WindowsPhone.LocationServices.Models.Goteborg.Parking
{
    public class ParkingLocationBase : ILocation
    {
        public object Content { get; set; }
        public GeoCoordinate Location { get; set; }
        public string MaxParkingTime { get; set; }
        public int CurrentParkingCost { get; set; }
        public string ParkingCost { get; set; }
        public string Owner { get; set; }
        public int ParkingSpaces { get; set; }
        public string ExtraInfo { get; set; }
    }
}
