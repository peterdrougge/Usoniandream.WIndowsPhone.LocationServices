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

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.Parking.ParkingLocation
{
    public class ParkingLocationsByStreet :ParkingLocationsBase
    {
        public ParkingLocationsByStreet(string address, Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.VehicleTypeEnum vehicletype)
            : base(vehicletype)
        {
            Request.Resource += "street/" + address;
            Request.AddParameter("srsname", "EPSG:3426");
        }
    }
}
