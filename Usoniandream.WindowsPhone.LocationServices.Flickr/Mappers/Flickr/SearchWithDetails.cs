
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

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Flickr
{
    public class SearchWithDetails : IMapper<Models.Flickr.Photo, Models.JSON.Flickr.Search.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Flickr.Photo> JSON2Model(Models.JSON.Flickr.Search.RootObject root)
        {
            Service.Flickr.Reactive.ServiceLayer servicelayer = new Service.Flickr.Reactive.ServiceLayer();
            foreach (var item in root.photos.photo)
            {
                yield return new Models.Flickr.Photo()
                {
                    Content = item.title,
                    ID = item.id,
                    Details = servicelayer.GetPhotoDetails(new SearchCriterias.Flickr.PhotoDetails(item.id)),
                    ImageURL = String.Format("http://farm{0}.staticflickr.com/{1}/{2}_{3}.jpg", item.farm, item.server, item.id, item.secret)
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Flickr.Photo> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Flickr.Search.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Flickr.Photo JSON2FirstModel(Models.JSON.Flickr.Search.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Flickr.Photo JSON2LastModel(Models.JSON.Flickr.Search.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
