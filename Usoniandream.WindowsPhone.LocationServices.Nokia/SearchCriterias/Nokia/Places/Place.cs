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
    public class Place : SearchCriteriaBase<Models.Nokia.Places.PlaceDetails, Models.JSON.Nokia.Place.RootObject>
    {
        public Place(string id, string acceptlanguage)
            : base("NOKIA_SERVICE_URI_PLACES")
        {
            Mapper = new Mappers.Nokia.Places.Place();

            ID = id;

            Client.AddDefaultHeader("Accept-Language", acceptlanguage);

            Request.Resource = "places/" + ID;

            APIKeyResourceName = "NOKIA_APP_CODE";

            Request.AddParameter("app_id", AppId);
            Request.AddParameter("app_code", APIkey);
            Request.AddParameter("tf", "plain");
            Request.AddParameter("pretty", "true");
        }

        public Place(string id)
            : base("NOKIA_SERVICE_URI_PLACES")
        {
            Mapper = new Mappers.Nokia.Places.Place();

            ID = id;

            Request.Resource = "places/" + ID;

            APIKeyResourceName = "NOKIA_APP_CODE";

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


        public string ID { get; set; }
    }
}
