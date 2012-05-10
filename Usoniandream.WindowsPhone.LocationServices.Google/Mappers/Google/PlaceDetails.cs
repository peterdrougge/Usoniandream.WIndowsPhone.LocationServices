
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
    public class PlaceDetails : IMapper<Models.Google.PlaceDetails, Models.JSON.Google.Place.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Google.PlaceDetails> JSON2Model(Models.JSON.Google.Place.RootObject root)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Models.Google.PlaceDetails> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Google.Place.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Google.PlaceDetails JSON2FirstModel(Models.JSON.Google.Place.RootObject root)
        {
            return new Models.Google.PlaceDetails()
            {
                Content = root.result.name,
                Address = root.result.formatted_address,
                PhoneNumber = root.result.formatted_phone_number,
                Icon = root.result.icon,
                Rating = root.result.rating,
                Reference = root.result.reference,
                Vicinity = root.result.vicinity,
                Attributions = root.html_attributions,
                Location = new System.Device.Location.GeoCoordinate(root.result.geometry.location.lat, root.result.geometry.location.lng),
                Id = root.result.id
            };
        }

        public Models.Google.PlaceDetails JSON2LastModel(Models.JSON.Google.Place.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
