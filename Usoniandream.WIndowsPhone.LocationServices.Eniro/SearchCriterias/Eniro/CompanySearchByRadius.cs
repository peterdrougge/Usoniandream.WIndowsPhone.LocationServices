
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
using Usoniandream.WindowsPhone.LocationServices.SearchCriterias;
using System.Device.Location;

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Eniro
{
    public class CompanySearchByRadius : SearchCriteriaBase<Models.Eniro.Company, Models.JSON.Eniro.CompanySearch.RootObject>
    {
        public CompanySearchByRadius(string query, string country, GeoCoordinate location, int radius)
            : base("ENIRO_SERVICE_URI_COMPANYSEARCH", SearchCriteriaResultType.Collection)
        {
            APIKeyResourceName = "ENIRO_API_KEY";
            Mapper = new Mappers.Eniro.CompanySearch();

            Request.Resource = "proximity/basic";

            Request.AddParameter("key", APIkey);
            Request.AddParameter("profile", Profile);
            Request.AddParameter("country", country);
            Request.AddParameter("version", "1.1.3");
            Request.AddParameter("search_word", query);
            Request.AddParameter("latitude", location.Latitude);
            Request.AddParameter("longitude", location.Longitude);
            Request.AddParameter("max_distance", radius);
        }

        public string Profile
        {
            get
            {
                string key = ((Models.ServiceAPIKey)Application.Current.Resources["ENIRO_API_PROFILE"]).Value;
                if (string.IsNullOrWhiteSpace(key))
                {
                    throw new ArgumentException("missing api profile, please check App.xaml.", "ENIRO_API_PROFILE");
                }
                return key;
            }
        }
    }
}
