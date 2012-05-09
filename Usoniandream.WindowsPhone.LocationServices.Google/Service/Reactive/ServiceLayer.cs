
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

namespace Usoniandream.WindowsPhone.LocationServices.Service.Google.Reactive
{
    public class ServiceLayer : LocationServices.Service.Reactive.GenericServiceLayer
    {
        /// <summary>
        /// Gets the places by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Google.Place> GetPlacesByRadius(SearchCriterias.Google.PlacesByRadius criteria)
        {
            return ExecuteRequestReturnObservable<Models.Google.Place, Models.JSON.Google.Places.RootObject>(criteria);
        }

        /// <summary>
        /// Gets the place details.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Google.PlaceDetails> GetPlaceDetails(SearchCriterias.Google.PlaceDetails criteria)
        {
            return ExecuteRequestReturnFirstObservable<Models.Google.PlaceDetails, Models.JSON.Google.Place.RootObject>(criteria);
        }

        /// <summary>
        /// Gets the event details.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Google.EventDetails> GetEventDetails(SearchCriterias.Google.EventDetails criteria)
        {
            return ExecuteRequestReturnFirstObservable<Models.Google.EventDetails, Models.JSON.Google.EventDetails.RootObject>(criteria);
        }

    }
}
