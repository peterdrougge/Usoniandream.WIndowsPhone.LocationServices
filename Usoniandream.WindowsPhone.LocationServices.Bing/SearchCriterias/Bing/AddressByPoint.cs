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

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Bing
{
    public class AddressByPoint : SearchCriterias.SearchCriteriaBase<Models.Bing.BingMapLocation, Models.JSON.Bing.BingLocation.RootObject>
    {
        public AddressByPoint(GeoCoordinate location)
            : base("BING_MAPS_SERVICE_URI_LOCATION", SearchCriteriaResultType.Single)
        {
            Location = location;

            Mapper = new Mappers.Bing.BingLocation();

            APIKeyResourceName = "BING_MAPS_API_KEY";

            Request.Resource = "Locations/" + Location.Latitude.ToString().Replace(",", ".") + "," + Location.Longitude.ToString().Replace(",", ".");

            Request.AddParameter("includeEntityTypes", "Address");
            Request.AddParameter("o","json");
            Request.AddParameter("key", APIkey);

        }

        public GeoCoordinate Location { get; set; }
    }
}
