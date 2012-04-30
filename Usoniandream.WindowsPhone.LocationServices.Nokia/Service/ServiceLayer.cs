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
using System.ComponentModel;
using System.Device.Location;
using System.Diagnostics;
using System.Reactive.Linq;
using RestSharp;
using Usoniandream.WindowsPhone.Extensions;
using Usoniandream.WindowsPhone;
using Usoniandream.WindowsPhone.GeoConverter;
using Usoniandream.WindowsPhone.LocationServices.Models;
using System.Collections.Generic;

namespace Usoniandream.WindowsPhone.LocationServices.Service.Nokia
{
    public class ServiceLayer : GenericServiceLayer
    {
        public void SearchNokiaPlaces(SearchCriterias.Nokia.Places.SearchPlaces criteria, Action<RestResponse<Models.JSON.Nokia.Places.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Nokia.Places.Place, Models.JSON.Nokia.Places.RootObject>(criteria, callback);
        }
        public void GetNokiaPlaces(SearchCriterias.Nokia.Places.Places criteria, Action<RestResponse<Models.JSON.Nokia.Places.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Nokia.Places.Place, Models.JSON.Nokia.Places.RootObject>(criteria, callback);
        }
        public void GetNokiaPlace(SearchCriterias.Nokia.Places.Place criteria, Action<RestResponse<Models.JSON.Nokia.Place.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Nokia.Places.PlaceDetails, Models.JSON.Nokia.Place.RootObject>(criteria, callback);
        }
    }
}
