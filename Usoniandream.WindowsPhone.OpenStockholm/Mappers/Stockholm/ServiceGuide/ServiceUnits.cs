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
using Usoniandream.WindowsPhone.GeoConverter.Positions;

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Stockholm.ServiceGuide
{
    public class ServiceUnits : IMapper<Models.Stockholm.ServiceGuide.ServiceUnit, Models.JSON.Stockholm.ServiceUnits.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Stockholm.ServiceGuide.ServiceUnit> JSON2Model(Models.JSON.Stockholm.ServiceUnits.RootObject root)
        {
            foreach (var item in root.features)
            {
                RT90 rt90pos = new RT90(item.GeographicalPosition.X, item.GeographicalPosition.Y, RT90.RT90Projection.rt90_2_5_gon_v);
                WGS84 pos = rt90pos.ToWGS84();
                yield return new Models.Stockholm.ServiceGuide.ServiceUnit()
                {
                    Content = item.Name,
                    ID = item.Id,
                    Location = new System.Device.Location.GeoCoordinate(pos.Latitude, pos.Longitude)
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Stockholm.ServiceGuide.ServiceUnit> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Stockholm.ServiceUnits.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Stockholm.ServiceGuide.ServiceUnit JSON2FirstModel(Models.JSON.Stockholm.ServiceUnits.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Stockholm.ServiceGuide.ServiceUnit JSON2LastModel(Models.JSON.Stockholm.ServiceUnits.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public Models.GenericPagedResultsContainer<Models.Stockholm.ServiceGuide.ServiceUnit> JSON2PagedContainer(Models.JSON.Stockholm.ServiceUnits.RootObject root)
        {
            throw new NotImplementedException();
        }
    }
}
