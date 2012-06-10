//
// Copyright (c) 2012 Peter Drougge
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

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
    public class SearchPlaces : SearchCriteriaBase<Models.Nokia.Places.Place, Models.JSON.Nokia.Places.RootObject>
    {
        public SearchPlaces(string query, GeoCoordinate location, string language)
            : base("NOKIA_SERVICE_URI_PLACES", SearchCriteriaResultType.Collection)
        {
            Mapper = new Mappers.Nokia.Places.Places();
            Language = language;
            Location = location;
            Query = query;

            Request.Resource = "discover/search";

            APIKeyResourceName = "NOKIA_APP_CODE";
            Request.AddParameter("q", query);
            Request.AddParameter("at", string.Format("{0},{1}", Location.Latitude.ToString().Replace(",", "."), Location.Longitude.ToString().Replace(",", ".")));
            Request.AddParameter("app_id", AppId);
            Request.AddParameter("app_code", APIkey);
            Request.AddParameter("tf", "plain");
            Request.AddParameter("pretty", "true");
            Client.AddDefaultHeader("Accept-Language", Language);
        }
        public SearchPlaces(string query, GeoCoordinate location)
            : base("NOKIA_SERVICE_URI_PLACES", SearchCriteriaResultType.Collection)
        {
            Mapper = new Mappers.Nokia.Places.Places();
            Location = location;
            Query = query;

            Request.Resource = "discover/search";

            APIKeyResourceName = "NOKIA_APP_CODE";
            Request.AddParameter("q", query);
            Request.AddParameter("at", string.Format("{0},{1}", Location.Latitude.ToString().Replace(",", "."), Location.Longitude.ToString().Replace(",", ".")));
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

        public string Query { get; set; }

        public string Language { get; set; }
    }
}
