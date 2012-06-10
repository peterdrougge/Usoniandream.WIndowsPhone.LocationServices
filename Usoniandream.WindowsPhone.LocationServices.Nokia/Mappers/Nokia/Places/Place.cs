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

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Nokia.Places
{
    public class Place : IMapper<Models.Nokia.Places.PlaceDetails, Models.JSON.Nokia.Place.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Nokia.Places.PlaceDetails> JSON2Model(Models.JSON.Nokia.Place.RootObject root)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Models.Nokia.Places.PlaceDetails> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Nokia.Place.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Nokia.Places.PlaceDetails JSON2FirstModel(Models.JSON.Nokia.Place.RootObject root)
        {
            if (root.location!=null)
            {
                if (root.location.position != null && root.location.position.Count == 2)
                {
                    Models.Nokia.Places.PlaceDetails ret = new Models.Nokia.Places.PlaceDetails();

                    ret.Content = root.name;
                    if (root.ratings!=null)
	                {
                        ret.AverageRating = root.ratings.average;
                	}
                    ret.Category = new Models.Nokia.Places.Category(root.categories.FirstOrDefault());
                    ret.Location = new System.Device.Location.GeoCoordinate(root.location.position[0], root.location.position[1]);
                    ret.Icon = root.icon;
                    ret.Id = root.placeId;
                    ret.Name = root.name;
                    if (root.extended!=null)
	                {
                        if (root.extended.payment!=null)
                            ret.Payment = root.extended.payment.text;
                        if (root.extended.openingHours!=null)
    	                    ret.OpeningHours = root.extended.openingHours.text;
                    }
                    ret.Group = root.categories.FirstOrDefault().title;
                    ret.Sponsored = root.sponsored.GetValueOrDefault(false);
                    if (root.media != null)
                    {
                        if (root.media.editorials!=null)
                        {
                            if (root.media.editorials.items.FirstOrDefault() != null)
                            {
                                ret.Description = root.media.editorials.items.FirstOrDefault().description;
                            }
                        }
                    }
                    if (root.location.address!=null)
                    {
                        ret.StreetAddress = root.location.address.street;
                    }
                    if (root.contacts!=null)
                    {
                        if (root.contacts.phone!=null)
                            ret.Phone = root.contacts.phone.FirstOrDefault().value;
                        if (root.contacts.website!=null)
                            ret.Website = root.contacts.website.FirstOrDefault().value;
                    }
                    return ret;
               }
            }
            return new Models.Nokia.Places.PlaceDetails();
        }

        public Models.Nokia.Places.PlaceDetails JSON2LastModel(Models.JSON.Nokia.Place.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public Models.GenericPagedResultsContainer<Models.Nokia.Places.PlaceDetails> JSON2PagedContainer(Models.JSON.Nokia.Place.RootObject root)
        {
            throw new NotImplementedException();
        }
    }
}
