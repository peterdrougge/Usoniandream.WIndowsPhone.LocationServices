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
using System.Linq;
using System.Device.Location;
using Usoniandream.WindowsPhone.GeoConverter.Positions;

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Orebro
{
    public class Parkings : IMapper<Models.Orebro.Parking, Models.JSON.Orebro.OrebroJSONModel.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Orebro.Parking> JSON2Model(Models.JSON.Orebro.OrebroJSONModel.RootObject root)
        {
            RT90 point90 = null;
            WGS84 wgs = null;
            foreach (var item in root.features)
            {
                point90 = new RT90(item.geometry.geometries.First().coordinates[0], item.geometry.geometries.First().coordinates[1]);
                wgs = point90.ToWGS84();
                yield return new Models.Orebro.Parking()
                {
                    Content = item.properties.title,
                    Description = item.properties.description,
                    Id = item.properties.id,
                    Link = item.properties.link,
                    Type = item.type,
                    Location = new GeoCoordinate(wgs.Latitude, wgs.Longitude)
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Orebro.Parking> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Orebro.OrebroJSONModel.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Orebro.Parking JSON2FirstModel(Models.JSON.Orebro.OrebroJSONModel.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Orebro.Parking JSON2LastModel(Models.JSON.Orebro.OrebroJSONModel.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public Models.GenericPagedResultsContainer<Models.Orebro.Parking> JSON2PagedContainer(Models.JSON.Orebro.OrebroJSONModel.RootObject root)
        {
            throw new NotImplementedException();
        }
    }
}
