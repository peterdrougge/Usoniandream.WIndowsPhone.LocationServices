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
    public class ParkingLocationsByRadiusBase<Ttarget, Tsource> : SearchCriteriaBase<Ttarget, Tsource>
    {
        public  ParkingLocationsByRadiusBase(string resource, int radius, GeoCoordinate location)
            : base("GOTEBORG_DATA_SERVICE_URI_PARKING")
        {
            APIKeyResourceName = "GOTEBORG_DATA_API_KEY";

            Location = location;
            Radius = radius;

            Request.Resource = resource + APIkey;

            Request.AddParameter("latitude", Location.Latitude.ToString().Replace(",", "."));
            Request.AddParameter("longitude", Location.Longitude.ToString().Replace(",", "."));
            Request.AddParameter("radius", Radius);
            Request.AddParameter("format", "json");

        }
        public GeoCoordinate Location { get; set; }

        public int Radius { get; set; }
    }
}
