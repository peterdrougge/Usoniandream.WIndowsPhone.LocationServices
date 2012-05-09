
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

namespace Usoniandream.WindowsPhone.LocationServices.Service.Instagram.Reactive
{
    public class ServiceLayer : LocationServices.Service.Reactive.GenericServiceLayer
    {
        /// <summary>
        /// Gets the media by location.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Instagram.Media> GetMediaByLocation(SearchCriterias.MediaByLocation criteria)
        {
            return ExecuteRequestReturnObservable<Models.Instagram.Media, Models.JSON.Instagram.MediaSearch.RootObject>(criteria);
        }

        /// <summary>
        /// Gets the places by location.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Instagram.Location> GetPlacesByLocation(SearchCriterias.PlacesByLocation criteria)
        {
            return ExecuteRequestReturnObservable<Models.Instagram.Location, Models.JSON.Instagram.Locations.RootObject>(criteria);
        }
        /// <summary>
        /// Gets the media details.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Instagram.MediaDetails> GetMediaDetails(SearchCriterias.MediaDetails criteria)
        {
            return ExecuteRequestReturnFirstObservable<Models.Instagram.MediaDetails, Models.JSON.Instagram.MediaDetails.RootObject>(criteria);
        }

    }
}
