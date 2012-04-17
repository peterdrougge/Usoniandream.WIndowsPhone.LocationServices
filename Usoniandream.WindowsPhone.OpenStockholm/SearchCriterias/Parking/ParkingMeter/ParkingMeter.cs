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

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.Parking.ParkingMeter
{
    public class ParkingMeter : SearchCriteriaBase<Models.Stockholm.ParkingMeter, Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ParkingMeters.RootObject>
    {
     
        public ParkingMeter()
            : base("STHLM_DATA_SERVICE_URI_PARKINGMETER")
        {
            Mapper = new Usoniandream.WindowsPhone.LocationServices.Mappers.Stockholm.Parking.ParkingMeter();
            APIKeyResourceName = "STHLM_DATA_API_KEY_PARKING";

            Request.Resource = "wfs/";

            Request.AddParameter("apiKey", APIkey);
            Request.AddParameter("service", "WFS");
            Request.AddParameter("version", "1.1.0");
            Request.AddParameter("request","GetFeature");
            Request.AddParameter("typeName", HttpUtility.UrlDecode("od%3ASB_EXTENT_VIEW_5129561_VALID"));
            Request.AddParameter("outputFormat","json");
        }
    }
}
