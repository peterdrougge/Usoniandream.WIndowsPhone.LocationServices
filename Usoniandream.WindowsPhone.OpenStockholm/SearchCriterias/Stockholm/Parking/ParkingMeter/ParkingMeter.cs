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
