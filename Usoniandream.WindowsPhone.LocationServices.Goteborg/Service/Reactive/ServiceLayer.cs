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
using Newtonsoft.Json;

namespace Usoniandream.WindowsPhone.LocationServices.Service.Goteborg.Reactive
{
    public class ServiceLayer : LocationServices.Service.Reactive.GenericServiceLayer
    {
        public IObservable<Models.Goteborg.Parking.PublicPayMachine> GetPayMachinesByRadius(SearchCriterias.Goteborg.Parking.PublicPayMachinesByRadius criteria)
        {
            return ExecuteRequestWithPaddingReturnObservable<Models.Goteborg.Parking.PublicPayMachine, Models.JSON.Goteborg.PublicPayMachines.RootObject>(criteria);
        }

        public IObservable<Models.Goteborg.Parking.PrivateParking> GetPrivateParkingsByRadius(SearchCriterias.Goteborg.Parking.PrivateParkingsByRadius criteria)
        {
            return ExecuteRequestWithPaddingReturnObservable<Models.Goteborg.Parking.PrivateParking, Models.JSON.Goteborg.PrivateParkings.RootObject>(criteria);
        }

        public IObservable<Models.Goteborg.Parking.BusParking> GetBusParkingsByRadius(SearchCriterias.Goteborg.Parking.BusParkingsByRadius criteria)
        {
            return ExecuteRequestWithPaddingReturnObservable<Models.Goteborg.Parking.BusParking, Models.JSON.Goteborg.BusParkings.RootObject>(criteria);
        }

        public IObservable<Models.Goteborg.Parking.MotorcycleParking> GetMotorcykleParkingsByRadius(SearchCriterias.Goteborg.Parking.MotorcycleParkingsByRadius criteria)
        {
            return ExecuteRequestWithPaddingReturnObservable<Models.Goteborg.Parking.MotorcycleParking, Models.JSON.Goteborg.MotorcyleParkings.RootObject>(criteria);
        }

        public IObservable<Models.Goteborg.Parking.HandicapParking> GetHandicapParkingsByRadius(SearchCriterias.Goteborg.Parking.HandicapParkingsByRadius criteria)
        {
            return ExecuteRequestWithPaddingReturnObservable<Models.Goteborg.Parking.HandicapParking, Models.JSON.Goteborg.HandicapParkings.RootObject>(criteria);
        }

        public IObservable<Models.Goteborg.Parking.ResidentialParking> GetResidentialParkingsByRadius(SearchCriterias.Goteborg.Parking.ResidentialParkingsByRadius criteria)
        {
            return ExecuteRequestWithPaddingReturnObservable<Models.Goteborg.Parking.ResidentialParking, Models.JSON.Goteborg.ResidentialParkings.RootObject>(criteria);
        }
        public IObservable<Models.Goteborg.Parking.PublicTimeParking> GetPublicTimeParkingsByRadius(SearchCriterias.Goteborg.Parking.PublicTimeParkingsByRadius criteria)
        {
            return ExecuteRequestWithPaddingReturnObservable<Models.Goteborg.Parking.PublicTimeParking, Models.JSON.Goteborg.PublicTimeParkings.RootObject>(criteria);
        }
        public IObservable<Models.Goteborg.Parking.PublicTollParking> GetPublicTollParkingsByRadius(SearchCriterias.Goteborg.Parking.PublicTollParkingsByRadius criteria)
        {
            return ExecuteRequestWithPaddingReturnObservable<Models.Goteborg.Parking.PublicTollParking, Models.JSON.Goteborg.PublicTollParkings.RootObject>(criteria);
        }

        public IObservable<Models.Goteborg.TrafficCamera.TrafficCamera> GetTrafficCameras(SearchCriterias.Goteborg.TrafficCamera.TrafficCameras criteria)
        {
            return ExecuteRequestWithPaddingReturnObservable<Models.Goteborg.TrafficCamera.TrafficCamera, Models.JSON.Goteborg.TrafficCameras.RootObject>(criteria);
        }

    }
}
