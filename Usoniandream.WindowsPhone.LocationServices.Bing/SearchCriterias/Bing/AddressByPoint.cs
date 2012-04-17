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

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Bing
{
    public class AddressByPoint : SearchCriterias.SearchCriteriaBase<Models.Bing.BingMapLocation, Models.JSON.Bing.BingLocation.RootObject>
    {
        public AddressByPoint(GeoCoordinate location)
            : base("BING_SERVICE_URI_LOCATION")
        {

            Location = location;

            APIKeyResourceName = "BING_API_KEY";

            Request.Resource = "Locations/" + Location.Latitude + "," + Location.Longitude;

            Request.AddParameter("includeEntityTypes", "Address");
            Request.AddParameter("o","json");
            Request.AddParameter("key", APIkey);

        }

        public GeoCoordinate Location { get; set; }
    }
}
