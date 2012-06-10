
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

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Twitter
{
    public class Search : IMapper<Models.Twitter.Tweet, Models.JSON.Twitter.Search.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Twitter.Tweet> JSON2Model(Models.JSON.Twitter.Search.RootObject root)
        {
            GeoCoordinate location = null;
            foreach (var item in root.results)
            {
                location = GetLocationFromItem(item.geo, item.location);

                if (location!=null)
                {
                    yield return new Models.Twitter.Tweet()
                    {
                        Content = item.text,
                        Id = item.id,
                        Created = DateTime.Parse(item.created_at),
                        UserName = item.from_user,
                        UserDisplayName = item.from_user_name,
                        UserId = item.from_user_id,
                        ReplyToUserName = item.to_user,
                        ReplyToUserDisplayName = item.to_user_name,
                        ReplyToUserId = item.to_user_id.GetValueOrDefault(),
                        Location = location,
                        ResultType = item.metadata.result_type,
                        Language = item.iso_language_code,
                        ProfileImageUrl = item.profile_image_url
                    };
                }
            }
        }

        private GeoCoordinate GetLocationFromItem(Models.JSON.Twitter.Search.Geo geo, string location)
        {
            if (geo!=null)
	        {
                if (geo.coordinates!=null)
	            {
                    if (geo.coordinates.Count==2)
	                {
                        return new GeoCoordinate(geo.coordinates[0], geo.coordinates[1]);
	                }
	            }
	        }
            // iPhone: 37.786461,-122.394867
            if (!string.IsNullOrWhiteSpace(location))
            {
                try
                {
                    string lat = location.Split(',')[0];
                    string lng = location.Split(',')[1];

                    lat = lat.Split(' ')[1];

                    return new GeoCoordinate(double.Parse(lat), double.Parse(lng));
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return null;
        }

        public System.Collections.Generic.IEnumerable<Models.Twitter.Tweet> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Twitter.Search.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Twitter.Tweet JSON2FirstModel(Models.JSON.Twitter.Search.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Twitter.Tweet JSON2LastModel(Models.JSON.Twitter.Search.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public Models.GenericPagedResultsContainer<Models.Twitter.Tweet> JSON2PagedContainer(Models.JSON.Twitter.Search.RootObject root)
        {
            throw new NotImplementedException();
        }
    }
}
