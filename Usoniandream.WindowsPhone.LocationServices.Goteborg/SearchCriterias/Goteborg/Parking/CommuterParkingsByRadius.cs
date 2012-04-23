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
using Usoniandream.WindowsPhone.LocationServices.SearchCriterias;
using System.Device.Location;

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Goteborg.Parking
{
    public class CommuterParkingsByRadius : ParkingLocationsByRadiusBase<Models.Goteborg.Parking.CommuterParking, Models.JSON.Goteborg.CommuterParkings.RootObject>
    {
        public CommuterParkingsByRadius(int radius, GeoCoordinate location)
            : base("CommuterParkings/", radius, location)
        {
            Mapper = new Mappers.Goteborg.Parking.CommuterParkings();
        }
    }
}
