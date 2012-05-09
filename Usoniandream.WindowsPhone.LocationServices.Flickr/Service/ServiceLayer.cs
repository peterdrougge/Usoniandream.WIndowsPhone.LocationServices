
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
using RestSharp;

namespace Usoniandream.WindowsPhone.LocationServices.Service.Flickr
{
    public class ServiceLayer : LocationServices.Service.GenericServiceLayer
    {
        /// <summary>
        /// Gets the photos by location.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetPhotosByLocation(SearchCriterias.Flickr.PhotosByLocation criteria, Action<IRestResponse<Models.JSON.Flickr.Search.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Flickr.Photo, Models.JSON.Flickr.Search.RootObject>(criteria, callback);
        }
        /// <summary>
        /// Gets the photo details.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetPhotoDetails(SearchCriterias.Flickr.PhotoDetails criteria, Action<IRestResponse<Models.JSON.Flickr.Info.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Flickr.PhotoDetails, Models.JSON.Flickr.Info.RootObject>(criteria, callback);
        }
    }
}
