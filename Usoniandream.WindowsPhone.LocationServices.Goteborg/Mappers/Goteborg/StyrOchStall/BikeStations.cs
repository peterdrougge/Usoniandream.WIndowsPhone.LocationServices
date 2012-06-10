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
using Usoniandream.WindowsPhone.Extensions;

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Goteborg.StyrOchStall
{
    public class BikeStations : IMapper<Models.Goteborg.StyrOchStall.BikeStation, Models.JSON.Goteborg.BikeStations.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Goteborg.StyrOchStall.BikeStation> JSON2Model(Models.JSON.Goteborg.BikeStations.RootObject root)
        {
            foreach (var item in root.Stations)
            {
                yield return new Models.Goteborg.StyrOchStall.BikeStation()
                {
                    Capacity = item.Capacity,
                    Content = TextHelper.CapitalizeFirstLetter(item.Label),
                    FreeBikes = item.FreeBikes,
                    FreeStands = item.FreeStands,
                    Id = item.Id,
                    Location = new System.Device.Location.GeoCoordinate(item.Lat, item.Long),
                    State = item.State
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Goteborg.StyrOchStall.BikeStation> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Goteborg.BikeStations.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.StyrOchStall.BikeStation JSON2FirstModel(Models.JSON.Goteborg.BikeStations.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.StyrOchStall.BikeStation JSON2LastModel(Models.JSON.Goteborg.BikeStations.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public Models.GenericPagedResultsContainer<Models.Goteborg.StyrOchStall.BikeStation> JSON2PagedContainer(Models.JSON.Goteborg.BikeStations.RootObject root)
        {
            throw new NotImplementedException();
        }
    }
}
