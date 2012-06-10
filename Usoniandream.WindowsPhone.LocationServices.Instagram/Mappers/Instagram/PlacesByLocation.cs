
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

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Instagram
{
    public class PlacesByLocation : IMapper<Models.Instagram.Location, Models.JSON.Instagram.Locations.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Instagram.Location> JSON2Model(Models.JSON.Instagram.Locations.RootObject root)
        {
            foreach (var item in root.data)
            {
                yield return new Models.Instagram.Location()
                {
                    Content = item.name,
                    Location = new System.Device.Location.GeoCoordinate(item.latitude, item.longitude),
                    Id = item.id
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Instagram.Location> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Instagram.Locations.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Instagram.Location JSON2FirstModel(Models.JSON.Instagram.Locations.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Instagram.Location JSON2LastModel(Models.JSON.Instagram.Locations.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public Models.GenericPagedResultsContainer<Models.Instagram.Location> JSON2PagedContainer(Models.JSON.Instagram.Locations.RootObject root)
        {
            throw new NotImplementedException();
        }
    }
}
