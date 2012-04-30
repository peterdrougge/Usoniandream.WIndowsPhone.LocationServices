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
    public class Place : SearchCriteriaBase<Models.Nokia.Places.PlaceDetails, Models.JSON.Nokia.Place.RootObject>
    {
        public Place(string id, string language)
            : base("NOKIA_SERVICE_URI_PLACES")
        {
            Mapper = new Mappers.Nokia.Places.Place();
            Language = language;
            ID = id;

            Client.AddDefaultHeader("Accept-Language", Language);

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

        public string Language { get; set; }
    }
}
