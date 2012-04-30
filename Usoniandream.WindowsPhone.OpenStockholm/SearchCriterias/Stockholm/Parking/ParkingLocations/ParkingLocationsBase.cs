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

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.Parking.ParkingLocation
{
    public abstract class ParkingLocationsBase : SearchCriteriaBase<Models.Stockholm.ParkingLocation, Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ParkingPlaces.RootObject>
    {
        public ParkingLocationsBase(Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.VehicleTypeEnum vehicletype)
            : base("STHLM_DATA_SERVICE_URI_PARKINGLOCATION")
        {
            Mapper = new Usoniandream.WindowsPhone.LocationServices.Mappers.Stockholm.Parking.ParkingLocation();
            APIKeyResourceName = "STHLM_DATA_API_KEY_PARKING";
            VehicleType = vehicletype;

            switch (this.VehicleType)
            {
                case Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.VehicleTypeEnum.Car:
                    Request.Resource += "ptillaten/";
                    break;
                case Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.VehicleTypeEnum.Bike:
                    Request.Resource += "pmotorcykel/";
                    break;
                case Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.VehicleTypeEnum.Truck:
                    Request.Resource += "plastbil/";
                    break;
                case Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.VehicleTypeEnum.Handicap:
                    Request.Resource += "prorelsehindrad/";
                    break;
                default:
                    throw new ArgumentException("VehicleType must be set", "VehicleType");
            }

            Request.AddParameter("outputFormat", "json");
            Request.AddParameter("apiKey", APIkey);
        }

        public Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.VehicleTypeEnum VehicleType { get; private set; }
    }
}
