
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
using System.Collections.Generic;

namespace Usoniandream.WindowsPhone.LocationServices.Models.JSON.Instagram.MediaSearch
{

    public class Comments
    {
    }

    public class Likes
    {
    }

    public class User
    {
        public string username { get; set; }
        public string profile_picture { get; set; }
        public string id { get; set; }
    }

    public class LowResolution
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Thumbnail
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class StandardResolution
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Images
    {
        public LowResolution low_resolution { get; set; }
        public Thumbnail thumbnail { get; set; }
        public StandardResolution standard_resolution { get; set; }
    }

    public class Datum
    {
        public double distance { get; set; }
        public string type { get; set; }
        public string filter { get; set; }
        public List<object> tags { get; set; }
        public Comments comments { get; set; }
        public string caption { get; set; }
        public Likes likes { get; set; }
        public string link { get; set; }
        public User user { get; set; }
        public string created_time { get; set; }
        public Images images { get; set; }
        public string id { get; set; }
        public Location location { get; set; }
    }
    public class Location
    {
        public double latitude { get; set; }
        public string id { get; set; }
        public double longitude { get; set; }
        public string name { get; set; }
    }

    public class RootObject
    {
        public List<Datum> data { get; set; }
    }
}
