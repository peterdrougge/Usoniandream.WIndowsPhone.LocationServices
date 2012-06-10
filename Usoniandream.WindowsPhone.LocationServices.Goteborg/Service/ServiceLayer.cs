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

namespace Usoniandream.WindowsPhone.LocationServices.Service.Goteborg
{
    public class ServiceLayer : GenericServiceLayer
    {
        /// <summary>
        /// Gets the pay machines by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetPayMachinesByRadius(SearchCriterias.Goteborg.Parking.PublicPayMachinesByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.PublicPayMachines.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Goteborg.Parking.PublicPayMachine, Models.JSON.Goteborg.PublicPayMachines.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Gets the private parkings by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetPrivateParkingsByRadius(SearchCriterias.Goteborg.Parking.PrivateParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.PrivateParkings.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Goteborg.Parking.PrivateParking, Models.JSON.Goteborg.PrivateParkings.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Gets the bus parkings by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetBusParkingsByRadius(SearchCriterias.Goteborg.Parking.BusParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.BusParkings.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Goteborg.Parking.BusParking, Models.JSON.Goteborg.BusParkings.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Gets the motorcykle parkings by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetMotorcykleParkingsByRadius(SearchCriterias.Goteborg.Parking.MotorcycleParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.MotorcyleParkings.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Goteborg.Parking.MotorcycleParking, Models.JSON.Goteborg.MotorcyleParkings.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Gets the handicap parkings by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetHandicapParkingsByRadius(SearchCriterias.Goteborg.Parking.HandicapParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.HandicapParkings.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Goteborg.Parking.HandicapParking, Models.JSON.Goteborg.HandicapParkings.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Gets the residential parkings by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetResidentialParkingsByRadius(SearchCriterias.Goteborg.Parking.ResidentialParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.ResidentialParkings.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Goteborg.Parking.ResidentialParking, Models.JSON.Goteborg.ResidentialParkings.RootObject>(criteria, callback);
        }
        /// <summary>
        /// Gets the public time parkings by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetPublicTimeParkingsByRadius(SearchCriterias.Goteborg.Parking.PublicTimeParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.PublicTimeParkings.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Goteborg.Parking.PublicTimeParking, Models.JSON.Goteborg.PublicTimeParkings.RootObject>(criteria, callback);
        }
        /// <summary>
        /// Gets the public toll parkings by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetPublicTollParkingsByRadius(SearchCriterias.Goteborg.Parking.PublicTollParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.PublicTollParkings.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Goteborg.Parking.PublicTollParking, Models.JSON.Goteborg.PublicTollParkings.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Gets the traffic cameras.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetTrafficCameras(SearchCriterias.Goteborg.TrafficCamera.TrafficCameras criteria, Action<RestResponse<Models.JSON.Goteborg.TrafficCameras.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Goteborg.TrafficCamera.TrafficCamera, Models.JSON.Goteborg.TrafficCameras.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Gets the bike stations by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetBikeStationsByRadius(SearchCriterias.Goteborg.StyrOchStall.BikeStationsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.BikeStations.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Goteborg.StyrOchStall.BikeStation, Models.JSON.Goteborg.BikeStations.RootObject>(criteria, callback);
        }
    }
}
