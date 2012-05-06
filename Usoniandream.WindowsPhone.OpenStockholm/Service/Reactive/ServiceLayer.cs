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
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Linq;
using Usoniandream.WindowsPhone.LocationServices.Models.Stockholm.ServiceGuide;

namespace Usoniandream.WindowsPhone.LocationServices.Service.Stockholm.Reactive
{
    public class ServiceLayer : LocationServices.Service.Reactive.GenericServiceLayer
    {
        /// <summary>
        /// Gets the parking locations by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Stockholm.ParkingLocation> GetParkingLocationsByRadius(SearchCriterias.Stockholm.Parking.ParkingLocation.ParkingLocationsByRadius criteria)
        {
            return ExecuteRequestReturnObservable<Models.Stockholm.ParkingLocation, Models.JSON.Stockholm.ParkingPlaces.RootObject>(criteria);
        }
        /// <summary>
        /// Gets the parking locations by street.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Stockholm.ParkingLocation> GetParkingLocationsByStreet(SearchCriterias.Stockholm.Parking.ParkingLocation.ParkingLocationsByStreet criteria)
        {
            return ExecuteRequestReturnObservable<Models.Stockholm.ParkingLocation, Models.JSON.Stockholm.ParkingPlaces.RootObject>(criteria);
        }

        /// <summary>
        /// Gets the parking meters.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Stockholm.ParkingMeter> GetParkingMeters(SearchCriterias.Stockholm.Parking.ParkingMeter.ParkingMeter criteria)
        {
            return ExecuteRequestReturnObservable<Models.Stockholm.ParkingMeter, Models.JSON.Stockholm.ParkingMeters.RootObject>(criteria);
        }

        /// <summary>
        /// Gets the service unit types.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Stockholm.ServiceGuide.ServiceUnitType> GetServiceUnitTypes(SearchCriterias.Stockholm.ServiceGuide.ServiceUnitTypes criteria)
        {
            return ExecuteRequestWithPaddingReturnObservable<Models.Stockholm.ServiceGuide.ServiceUnitType, Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject>(criteria);
        }

        /// <summary>
        /// Gets the service units.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Stockholm.ServiceGuide.ServiceUnit> GetServiceUnits(SearchCriterias.Stockholm.ServiceGuide.ServiceUnits criteria)
        {
            return ExecuteRequestWithPaddingReturnObservable<Models.Stockholm.ServiceGuide.ServiceUnit, Models.JSON.Stockholm.ServiceUnits.RootObject>(criteria);
        }

        /// <summary>
        /// Searches the service units.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Stockholm.ServiceGuide.ServiceUnit> SearchServiceUnits(SearchCriterias.Stockholm.ServiceGuide.SearchServiceUnits criteria)
        {
            return ExecuteRequestWithPaddingReturnObservable<Models.Stockholm.ServiceGuide.ServiceUnit, Models.JSON.Stockholm.ServiceUnits.RootObject>(criteria);
        }

        /// <summary>
        /// Gets the service unit details.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Stockholm.ServiceGuide.DetailedServiceUnit> GetDetailedServiceUnit(SearchCriterias.Stockholm.ServiceGuide.DetailedServiceUnit criteria)
        {
            return ExecuteRequestReturnFirstObservable<Models.Stockholm.ServiceGuide.DetailedServiceUnit, Models.JSON.Stockholm.DetailedServiceUnit.RootObject>(criteria);
        }


        /// <summary>
        /// Gets the place service unit types.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Stockholm.Place.ServiceUnitType> GetPlaceServiceUnitTypes(SearchCriterias.Stockholm.Place.ServiceUnitTypes criteria)
        {
            return ExecuteRequestWithPaddingReturnObservable<Models.Stockholm.Place.ServiceUnitType, Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject>(criteria);
        }

        /// <summary>
        /// Gets the place service units.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Stockholm.Place.ServiceUnit> GetPlaceServiceUnits(SearchCriterias.Stockholm.Place.ServiceUnits criteria)
        {
            return ExecuteRequestWithPaddingReturnObservable<Models.Stockholm.Place.ServiceUnit, Models.JSON.Stockholm.ServiceUnits.RootObject>(criteria);
        }

        /// <summary>
        /// Searches the place service units.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Stockholm.Place.ServiceUnit> SearchPlaceServiceUnits(SearchCriterias.Stockholm.Place.SearchServiceUnits criteria)
        {
            return ExecuteRequestWithPaddingReturnObservable<Models.Stockholm.Place.ServiceUnit, Models.JSON.Stockholm.ServiceUnits.RootObject>(criteria);
        }

        /// <summary>
        /// Gets the place service unit details.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Stockholm.Place.DetailedServiceUnit> GetPlaceDetailedServiceUnit(SearchCriterias.Stockholm.Place.DetailedServiceUnit criteria)
        {
            return ExecuteRequestReturnFirstObservable<Models.Stockholm.Place.DetailedServiceUnit, Models.JSON.Stockholm.DetailedServiceUnit.RootObject>(criteria);
        }

    }
}
