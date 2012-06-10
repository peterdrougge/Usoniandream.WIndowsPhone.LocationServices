
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

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Google
{
    public class Places : IMapper<Models.Google.Place, Models.JSON.Google.Places.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Google.Place> JSON2Model(Models.JSON.Google.Places.RootObject root)
        {
            foreach (var item in root.result)
            {
                yield return new Models.Google.Place()
                {
                    Content = item.name,
                    Address = item.formatted_address,
                    PhoneNumber = item.formatted_phone_number,
                    Icon = item.icon,
                    Rating = item.rating,
                    Reference = item.reference,
                    Vicinity = item.vicinity,
                    Attributions = root.html_attributions,
                    Location = new System.Device.Location.GeoCoordinate(item.geometry.location.lat, item.geometry.location.lng),
                    Id = item.id
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Google.Place> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Google.Places.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Google.Place JSON2FirstModel(Models.JSON.Google.Places.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Google.Place JSON2LastModel(Models.JSON.Google.Places.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public Models.GenericPagedResultsContainer<Models.Google.Place> JSON2PagedContainer(Models.JSON.Google.Places.RootObject root)
        {
            throw new NotImplementedException();
        }
    }
}
