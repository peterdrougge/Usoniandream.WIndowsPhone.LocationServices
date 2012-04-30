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

namespace Usoniandream.WindowsPhone.LocationServices.Service.Nokia.Reactive
{
    public class ServiceLayer : LocationServices.Service.Reactive.GenericServiceLayer
    {
        public IObservable<Models.Nokia.Places.Place> SearchNokiaPlaces(SearchCriterias.Nokia.Places.SearchPlaces criteria)
        {
            return ExecuteRequestReturnObservable<Models.Nokia.Places.Place, Models.JSON.Nokia.Places.RootObject>(criteria);
        }
        public IObservable<Models.Nokia.Places.Place> GetNokiaPlaces(SearchCriterias.Nokia.Places.Places criteria)
        {
            return ExecuteRequestReturnObservable<Models.Nokia.Places.Place, Models.JSON.Nokia.Places.RootObject>(criteria);
 
        }
        public IObservable<Models.Nokia.Places.PlaceDetails> GetNokiaPlace(SearchCriterias.Nokia.Places.Place criteria)
        {
            return ExecuteRequestReturnFirstObservable<Models.Nokia.Places.PlaceDetails, Models.JSON.Nokia.Place.RootObject>(criteria);

        }
    }
}
