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

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Nokia.Places
{
    public class Places : SearchCriteriaBase<Models.Nokia.Places.Place, Models.JSON.Nokia.Places.RootObject>
    {
        public Places(GeoCoordinate location)
            : base("NOKIA_SERVICE_URI_PLACES")
        {
            Mapper = new Mappers.Nokia.Places.Place();
            Location = location;

            Request.Resource = "discover/explore";

            APIKeyResourceName = "NOKIA_APP_CODE";

            Request.AddParameter("at", string.Format("{0},{1}", Location.Latitude, Location.Longitude));
            Request.AddParameter("app_id", AppId);
            Request.AddParameter("app_code", APIkey);
            Request.AddParameter("tf", "plain");
            Request.AddParameter("pretty", "true");

        }

        public string AppId
        {
            get
            {
                string key = ((Models.ServiceAPIKey)Application.Current.Resources["NOKIA_APP_ID"]).Value;
                if (string.IsNullOrWhiteSpace(key))
                {
                    throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
                }
                return key;
            }
        }


        public GeoCoordinate Location { get; set; }
    }
}
