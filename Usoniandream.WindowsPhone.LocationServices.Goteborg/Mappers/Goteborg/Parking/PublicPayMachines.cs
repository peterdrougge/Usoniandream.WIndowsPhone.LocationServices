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
using Usoniandream.WindowsPhone.LocationServices.Mappers;

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Goteborg.Parking
{
    public class PublicPayMachines : IMapper<Models.Goteborg.Parking.PublicPayMachine, Models.JSON.Goteborg.PublicPayMachines.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Goteborg.Parking.PublicPayMachine> JSON2Model(Models.JSON.Goteborg.PublicPayMachines.RootObject root)
        {
            foreach (var item in root.features)
            {
                yield return new Models.Goteborg.Parking.PublicPayMachine()
                {
                    Content = item.Name,
                    Location = new System.Device.Location.GeoCoordinate(item.Lat, item.Long),
                    MaxParkingTime = item.MaxParkingTime,
                    MaxParkingTimeLimitation = item.MaxParkingTimeLimitation,
                    ParkingCost = item.ParkingCost,
                    Owner = item.Owner,
                    ParkingCharge = item.ParkingCharge,
                    ExtraInfo = item.ExtraInfo
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Goteborg.Parking.PublicPayMachine> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Goteborg.PublicPayMachines.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.Parking.PublicPayMachine JSON2FirstModel(Models.JSON.Goteborg.PublicPayMachines.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.Parking.PublicPayMachine JSON2LastModel(Models.JSON.Goteborg.PublicPayMachines.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public Models.GenericPagedResultsContainer<Models.Goteborg.Parking.PublicPayMachine> JSON2PagedContainer(Models.JSON.Goteborg.PublicPayMachines.RootObject root)
        {
            throw new NotImplementedException();
        }
    }
}
