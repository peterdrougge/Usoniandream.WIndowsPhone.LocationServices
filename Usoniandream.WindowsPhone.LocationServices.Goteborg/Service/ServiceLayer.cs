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

namespace Usoniandream.WindowsPhone.LocationServices.Service.Goteborg
{
    public class ServiceLayer : GenericServiceLayer
    {
        public void GetPayMachinesByRadius(SearchCriterias.Goteborg.Parking.PublicPayMachinesByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.PublicPayMachines.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Goteborg.Parking.PublicPayMachine, Models.JSON.Goteborg.PublicPayMachines.RootObject>(criteria, callback);
        }

        public void GetPrivateParkingsByRadius(SearchCriterias.Goteborg.Parking.PrivateParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.PrivateParkings.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Goteborg.Parking.PrivateParking, Models.JSON.Goteborg.PrivateParkings.RootObject>(criteria, callback);
        }

        public void GetBusParkingsByRadius(SearchCriterias.Goteborg.Parking.BusParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.BusParkings.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Goteborg.Parking.BusParking, Models.JSON.Goteborg.BusParkings.RootObject>(criteria, callback);
        }

        public void GetMotorcykleParkingsByRadius(SearchCriterias.Goteborg.Parking.MotorcycleParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.MotorcyleParkings.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Goteborg.Parking.MotorcycleParking, Models.JSON.Goteborg.MotorcyleParkings.RootObject>(criteria, callback);
        }

        public void GetHandicapParkingsByRadius(SearchCriterias.Goteborg.Parking.HandicapParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.HandicapParkings.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Goteborg.Parking.HandicapParking, Models.JSON.Goteborg.HandicapParkings.RootObject>(criteria, callback);
        }

        public void GetResidentialParkingsByRadius(SearchCriterias.Goteborg.Parking.ResidentialParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.ResidentialParkings.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Goteborg.Parking.ResidentialParking, Models.JSON.Goteborg.ResidentialParkings.RootObject>(criteria, callback);
        }
        public void GetPublicTimeParkingsByRadius(SearchCriterias.Goteborg.Parking.PublicTimeParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.PublicTimeParkings.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Goteborg.Parking.PublicTimeParking, Models.JSON.Goteborg.PublicTimeParkings.RootObject>(criteria, callback);
        }
        public void GetPublicTollParkingsByRadius(SearchCriterias.Goteborg.Parking.PublicTollParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.PublicTollParkings.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Goteborg.Parking.PublicTollParking, Models.JSON.Goteborg.PublicTollParkings.RootObject>(criteria, callback);
        }


    }
}
