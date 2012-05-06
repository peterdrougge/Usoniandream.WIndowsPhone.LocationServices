
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
using System.Device.Location;
using System.Linq;

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Flickr
{
    public class Info : IMapper<Models.Flickr.PhotoDetails, Models.JSON.Flickr.Info.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Flickr.PhotoDetails> JSON2Model(Models.JSON.Flickr.Info.RootObject root)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Models.Flickr.PhotoDetails> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Flickr.Info.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Flickr.PhotoDetails JSON2FirstModel(Models.JSON.Flickr.Info.RootObject root)
        {
            if (root==null)
            {
                throw new ArgumentNullException("root is missing");
            }
            if (root.photo==null)
            {
                throw new ArgumentNullException("root.photo is missing");
            }
            return new Models.Flickr.PhotoDetails()
            {
                Content = root.photo.title,
                Location = new GeoCoordinate(root.photo.location.latitude, root.photo.location.longitude),
                ImageURL = ExtractImageURL(root),
                DateUploaded = root.photo.dateuploaded,
                Description = ExtractDescription(root),
                DateTaken = ExtractDateTaken(root),
                Owner = ExtractRealName(root),
                ID = root.photo.id
            };
        }

        private static string ExtractRealName(Models.JSON.Flickr.Info.RootObject root)
        {
            try
            {
                return root.photo.owner.realname;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        private static string ExtractDateTaken(Models.JSON.Flickr.Info.RootObject root)
        {
            try
            {
                return root.photo.dates.taken;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        private static string ExtractDescription(Models.JSON.Flickr.Info.RootObject root)
        {
            try
            {
                return root.photo.description._content;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        private static string ExtractImageURL(Models.JSON.Flickr.Info.RootObject root)
        {
            try
            {
                return String.Format("http://farm{0}.staticflickr.com/{1}/{2}_{3}.jpg", root.photo.farm, root.photo.server, root.photo.id, root.photo.secret);
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public Models.Flickr.PhotoDetails JSON2LastModel(Models.JSON.Flickr.Info.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
