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
    public class CommuterParkings : IMapper<Models.Goteborg.Parking.CommuterParking, Models.JSON.Goteborg.CommuterParkings.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Goteborg.Parking.CommuterParking> JSON2Model(Models.JSON.Goteborg.CommuterParkings.RootObject root)
        {
            foreach (var item in root.features)
            {
                yield return new Models.Goteborg.Parking.CommuterParking()
                {
                    Content = item.Name,
                    Location = new System.Device.Location.GeoCoordinate(item.Lat, item.Long),
                    ParkingSpaces = item.ParkingSpaces,
                    ExtraInfo = item.ExtraInfo,
                    FreeSpaces = item.FreeSpaces,
                    FreeSpacesDate = item.FreeSpacesDate
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Goteborg.Parking.CommuterParking> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Goteborg.CommuterParkings.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.Parking.CommuterParking JSON2FirstModel(Models.JSON.Goteborg.CommuterParkings.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.Parking.CommuterParking JSON2LastModel(Models.JSON.Goteborg.CommuterParkings.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
