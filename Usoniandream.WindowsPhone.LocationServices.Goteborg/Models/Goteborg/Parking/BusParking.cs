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

namespace Usoniandream.WindowsPhone.LocationServices.Models.Goteborg.Parking
{
    public class BusParking : ParkingLocationBase
    {
        public string MaxParkingTimeLimitation { get; set; }
        public int? ParkingSpaceCount { get; set; }

        public int ParkableLength { get; set; }
    }
}
