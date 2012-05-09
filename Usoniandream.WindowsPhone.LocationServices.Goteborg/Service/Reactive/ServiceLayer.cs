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

namespace Usoniandream.WindowsPhone.LocationServices.Service.Goteborg.Reactive
{
    public class ServiceLayer : LocationServices.Service.Reactive.GenericServiceLayer
    {
        /// <summary>
        /// Gets the pay machines by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Goteborg.Parking.PublicPayMachine> GetPayMachinesByRadius(SearchCriterias.Goteborg.Parking.PublicPayMachinesByRadius criteria)
        {
            return ExecuteRequestReturnObservable<Models.Goteborg.Parking.PublicPayMachine, Models.JSON.Goteborg.PublicPayMachines.RootObject>(criteria);
        }

        /// <summary>
        /// Gets the private parkings by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Goteborg.Parking.PrivateParking> GetPrivateParkingsByRadius(SearchCriterias.Goteborg.Parking.PrivateParkingsByRadius criteria)
        {
            return ExecuteRequestReturnObservable<Models.Goteborg.Parking.PrivateParking, Models.JSON.Goteborg.PrivateParkings.RootObject>(criteria);
        }

        /// <summary>
        /// Gets the bus parkings by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Goteborg.Parking.BusParking> GetBusParkingsByRadius(SearchCriterias.Goteborg.Parking.BusParkingsByRadius criteria)
        {
            return ExecuteRequestReturnObservable<Models.Goteborg.Parking.BusParking, Models.JSON.Goteborg.BusParkings.RootObject>(criteria);
        }

        /// <summary>
        /// Gets the motorcykle parkings by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Goteborg.Parking.MotorcycleParking> GetMotorcykleParkingsByRadius(SearchCriterias.Goteborg.Parking.MotorcycleParkingsByRadius criteria)
        {
            return ExecuteRequestReturnObservable<Models.Goteborg.Parking.MotorcycleParking, Models.JSON.Goteborg.MotorcyleParkings.RootObject>(criteria);
        }

        /// <summary>
        /// Gets the handicap parkings by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Goteborg.Parking.HandicapParking> GetHandicapParkingsByRadius(SearchCriterias.Goteborg.Parking.HandicapParkingsByRadius criteria)
        {
            return ExecuteRequestReturnObservable<Models.Goteborg.Parking.HandicapParking, Models.JSON.Goteborg.HandicapParkings.RootObject>(criteria);
        }

        /// <summary>
        /// Gets the residential parkings by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Goteborg.Parking.ResidentialParking> GetResidentialParkingsByRadius(SearchCriterias.Goteborg.Parking.ResidentialParkingsByRadius criteria)
        {
            return ExecuteRequestReturnObservable<Models.Goteborg.Parking.ResidentialParking, Models.JSON.Goteborg.ResidentialParkings.RootObject>(criteria);
        }
        /// <summary>
        /// Gets the public time parkings by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Goteborg.Parking.PublicTimeParking> GetPublicTimeParkingsByRadius(SearchCriterias.Goteborg.Parking.PublicTimeParkingsByRadius criteria)
        {
            return ExecuteRequestReturnObservable<Models.Goteborg.Parking.PublicTimeParking, Models.JSON.Goteborg.PublicTimeParkings.RootObject>(criteria);
        }
        /// <summary>
        /// Gets the public toll parkings by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Goteborg.Parking.PublicTollParking> GetPublicTollParkingsByRadius(SearchCriterias.Goteborg.Parking.PublicTollParkingsByRadius criteria)
        {
            return ExecuteRequestReturnObservable<Models.Goteborg.Parking.PublicTollParking, Models.JSON.Goteborg.PublicTollParkings.RootObject>(criteria);
        }

        /// <summary>
        /// Gets the traffic cameras.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Goteborg.TrafficCamera.TrafficCamera> GetTrafficCameras(SearchCriterias.Goteborg.TrafficCamera.TrafficCameras criteria)
        {
            return ExecuteRequestReturnObservable<Models.Goteborg.TrafficCamera.TrafficCamera, Models.JSON.Goteborg.TrafficCameras.RootObject>(criteria);
        }

        /// <summary>
        /// Gets the bike stations by radius.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Models.Goteborg.StyrOchStall.BikeStation> GetBikeStationsByRadius(SearchCriterias.Goteborg.StyrOchStall.BikeStationsByRadius criteria)
        {
            return ExecuteRequestReturnObservable<Models.Goteborg.StyrOchStall.BikeStation, Models.JSON.Goteborg.BikeStations.RootObject>(criteria);
        }

    }
}
