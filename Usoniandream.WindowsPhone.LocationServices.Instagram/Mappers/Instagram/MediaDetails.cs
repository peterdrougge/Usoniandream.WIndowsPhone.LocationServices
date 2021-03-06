﻿
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
    public class MediaDetails : IMapper<Models.Instagram.MediaDetails, Models.JSON.Instagram.MediaDetails.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Instagram.MediaDetails> JSON2Model(Models.JSON.Instagram.MediaDetails.RootObject root)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Models.Instagram.MediaDetails> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Instagram.MediaDetails.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Instagram.MediaDetails JSON2FirstModel(Models.JSON.Instagram.MediaDetails.RootObject root)
        {
            return new Models.Instagram.MediaDetails()
            {
                ID = root.data.id,
                Content = root.data.caption,
                Location = new System.Device.Location.GeoCoordinate(root.data.location.latitude, root.data.location.longitude),
                UserName = root.data.user.username,
                Owner = root.data.user.full_name,
                UserId = root.data.user.id,
                UserProfilePicture = root.data.user.profile_picture,
                ImageURL = root.data.images.standard_resolution.url,
                ImageThumbnailURL = root.data.images.thumbnail.url,
                Created = root.data.created_time,
                DateTaken = root.data.created_time.FromUnix(),
                Link = root.data.link,
                Type = root.data.type
            };
        }

        public Models.Instagram.MediaDetails JSON2LastModel(Models.JSON.Instagram.MediaDetails.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public Models.GenericPagedResultsContainer<Models.Instagram.MediaDetails> JSON2PagedContainer(Models.JSON.Instagram.MediaDetails.RootObject root)
        {
            throw new NotImplementedException();
        }
    }
}
