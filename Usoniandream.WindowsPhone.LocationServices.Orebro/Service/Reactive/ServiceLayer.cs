
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

namespace Usoniandream.WindowsPhone.LocationServices.Service.Orebro.Reactive
{
    public class ServiceLayer : LocationServices.Service.Reactive.GenericServiceLayer
    {
        /// <summary>
        /// Gets the baths.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Orebro.Bath> GetBaths(SearchCriterias.Orebro.Baths criteria)
        {
            return ExecuteRequestReturnObservable<Models.Orebro.Bath, Models.JSON.Orebro.OrebroJSONModel.RootObject>(criteria);
        }
        /// <summary>
        /// Gets the parks.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Orebro.Park> GetParks(SearchCriterias.Orebro.Parks criteria)
        {
            return ExecuteRequestReturnObservable<Models.Orebro.Park, Models.JSON.Orebro.OrebroJSONModel.RootObject>(criteria);
        }
        /// <summary>
        /// Gets the parkings.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Orebro.Parking> GetParkings(SearchCriterias.Orebro.Parkings criteria)
        {
            return ExecuteRequestReturnObservable<Models.Orebro.Parking, Models.JSON.Orebro.OrebroJSONModel.RootObject>(criteria);
        }
        /// <summary>
        /// Gets the recycling.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Orebro.Recycling> GetRecycling(SearchCriterias.Orebro.Recycling criteria)
        {
            return ExecuteRequestReturnObservable<Models.Orebro.Recycling, Models.JSON.Orebro.OrebroJSONModel.RootObject>(criteria);
        }

    }
}
