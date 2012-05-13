
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
using Usoniandream.WindowsPhone.LocationServices.Extensions;

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Instagram
{
    public class MediaByLocation : IMapper<Models.Instagram.Media, Models.JSON.Instagram.MediaSearch.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Instagram.Media> JSON2Model(Models.JSON.Instagram.MediaSearch.RootObject root)
        {
            foreach (var item in root.data)
            {
                yield return new Models.Instagram.Media()
                {
                    ID = item.id,
                    Content = GetCaption(item),
                    Location = GetLocation(item),
                    UserName = GetUsername(item),
                    UserFullName = GetUserFullname(item),
                    UserId = item.user.id,
                    UserProfilePicture = GetUserProfilePicture(item),
                    ImageURL = GetImageUrl(item),
                    ImageThumbnailURL = GetThumbnail(item),
                    Created = item.created_time,
                    DateTaken = item.created_time.FromUnix()
                };
            }
        }

        private static string GetThumbnail(Models.JSON.Instagram.MediaSearch.Datum item)
        {
            if (item.images == null)
                return string.Empty;
            if (item.images.thumbnail == null)
                return string.Empty;
            return item.images.thumbnail.url;
        }

        private static string GetImageUrl(Models.JSON.Instagram.MediaSearch.Datum item)
        {
            if (item.images == null)
                return string.Empty;
            if (item.images.standard_resolution == null)
                return string.Empty;
            return item.images.standard_resolution.url;
        }

        private static string GetUserProfilePicture(Models.JSON.Instagram.MediaSearch.Datum item)
        {
            if (item.user == null)
                return string.Empty;
            return item.user.profile_picture;
        }

        private static string GetUserFullname(Models.JSON.Instagram.MediaSearch.Datum item)
        {
            if (item.user == null)
                return string.Empty;
            return item.user.full_name;
        }

        private static string GetUsername(Models.JSON.Instagram.MediaSearch.Datum item)
        {
            if (item.user == null)
                return string.Empty;
            return item.user.username;
        }

        private static System.Device.Location.GeoCoordinate GetLocation(Models.JSON.Instagram.MediaSearch.Datum item)
        {
            if (item.location == null)
                return null;
            return new System.Device.Location.GeoCoordinate(item.location.latitude, item.location.longitude);
        }

        private static string GetCaption(Models.JSON.Instagram.MediaSearch.Datum item)
        {
            if (item.caption==null)
                return string.Empty;
            return item.caption.text;
        }

        public System.Collections.Generic.IEnumerable<Models.Instagram.Media> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Instagram.MediaSearch.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Instagram.Media JSON2FirstModel(Models.JSON.Instagram.MediaSearch.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Instagram.Media JSON2LastModel(Models.JSON.Instagram.MediaSearch.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
