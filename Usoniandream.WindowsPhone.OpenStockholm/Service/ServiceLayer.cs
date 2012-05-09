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
using Usoniandream.WindowsPhone;
using Usoniandream.WindowsPhone.Extensions;
using Usoniandream.WindowsPhone.GeoConverter;
using Usoniandream.WindowsPhone.LocationServices.Models;
using Usoniandream.WindowsPhone.LocationServices.Models.Stockholm;
using System.Windows;
using System.Linq;
using Usoniandream.WindowsPhone.LocationServices.Models.Stockholm.ServiceGuide;

namespace Usoniandream.WindowsPhone.LocationServices.Service.Stockholm
{
    public class ServiceLayer : GenericServiceLayer
    {
        /// <summary>
        /// Gets the parking locations by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetParkingLocationsByRadius(SearchCriterias.Stockholm.Parking.ParkingLocation.ParkingLocationsByRadius criteria, Action<IRestResponse<Models.JSON.Stockholm.ParkingPlaces.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Stockholm.ParkingLocation, Models.JSON.Stockholm.ParkingPlaces.RootObject>(criteria, callback);
        }
        /// <summary>
        /// Gets the parking locations by street.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetParkingLocationsByStreet(SearchCriterias.Stockholm.Parking.ParkingLocation.ParkingLocationsByStreet criteria, Action<IRestResponse<Models.JSON.Stockholm.ParkingPlaces.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Stockholm.ParkingLocation, Models.JSON.Stockholm.ParkingPlaces.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Gets the parking meters.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetParkingMeters(SearchCriterias.Stockholm.Parking.ParkingMeter.ParkingMeter criteria, Action<IRestResponse<Models.JSON.Stockholm.ParkingMeters.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Stockholm.ParkingMeter, Models.JSON.Stockholm.ParkingMeters.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Gets the service unit types.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetServiceUnitTypes(SearchCriterias.Stockholm.ServiceGuide.ServiceUnitTypes criteria, Action<IRestResponse<Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Stockholm.ServiceGuide.ServiceUnitType, Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Gets the service units.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetServiceUnits(SearchCriterias.Stockholm.ServiceGuide.ServiceUnits criteria, Action<IRestResponse<Models.JSON.Stockholm.ServiceUnits.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Stockholm.ServiceGuide.ServiceUnit, Models.JSON.Stockholm.ServiceUnits.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Searches the service units.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void SearchServiceUnits(SearchCriterias.Stockholm.ServiceGuide.SearchServiceUnits criteria, Action<IRestResponse<Models.JSON.Stockholm.ServiceUnits.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Stockholm.ServiceGuide.ServiceUnit, Models.JSON.Stockholm.ServiceUnits.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Gets the service unit details.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetDetailedServiceUnit(SearchCriterias.Stockholm.ServiceGuide.DetailedServiceUnit criteria, Action<IRestResponse<Models.JSON.Stockholm.DetailedServiceUnit.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Stockholm.ServiceGuide.DetailedServiceUnit, Models.JSON.Stockholm.DetailedServiceUnit.RootObject>(criteria, callback);
        }


        /// <summary>
        /// Gets the place service unit types.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetPlaceServiceUnitTypes(SearchCriterias.Stockholm.Place.ServiceUnitTypes criteria, Action<IRestResponse<Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Stockholm.Place.ServiceUnitType, Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Gets the place service units.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetPlaceServiceUnits(SearchCriterias.Stockholm.Place.ServiceUnits criteria, Action<IRestResponse<Models.JSON.Stockholm.ServiceUnits.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Stockholm.Place.ServiceUnit, Models.JSON.Stockholm.ServiceUnits.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Searches the place service units.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void SearchPlaceServiceUnits(SearchCriterias.Stockholm.Place.SearchServiceUnits criteria, Action<IRestResponse<Models.JSON.Stockholm.ServiceUnits.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Stockholm.Place.ServiceUnit, Models.JSON.Stockholm.ServiceUnits.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Gets the place service unit details.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetPlaceDetailedServiceUnit(SearchCriterias.Stockholm.Place.DetailedServiceUnit criteria, Action<IRestResponse<Models.JSON.Stockholm.DetailedServiceUnit.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Stockholm.Place.DetailedServiceUnit, Models.JSON.Stockholm.DetailedServiceUnit.RootObject>(criteria, callback);
        }

    }
}
