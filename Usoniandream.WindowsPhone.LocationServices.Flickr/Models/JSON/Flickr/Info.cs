
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

namespace Usoniandream.WindowsPhone.LocationServices.Models.JSON.Flickr.Info
{
    public class Owner
    {
        public string nsid { get; set; }
        public string username { get; set; }
        public string realname { get; set; }
        public string location { get; set; }
        public string iconserver { get; set; }
        public int iconfarm { get; set; }
    }

    public class Title
    {
        public string _content { get; set; }
    }

    public class Description
    {
        public string _content { get; set; }
    }

    public class Visibility
    {
        public int ispublic { get; set; }
        public int isfriend { get; set; }
        public int isfamily { get; set; }
    }

    public class Dates
    {
        public string posted { get; set; }
        public string taken { get; set; }
        public int takengranularity { get; set; }
        public string lastupdate { get; set; }
    }

    public class Editability
    {
        public int cancomment { get; set; }
        public int canaddmeta { get; set; }
    }

    public class Publiceditability
    {
        public int cancomment { get; set; }
        public int canaddmeta { get; set; }
    }

    public class Usage
    {
        public int candownload { get; set; }
        public int canblog { get; set; }
        public int canprint { get; set; }
        public int canshare { get; set; }
    }

    public class Comments
    {
        public int _content { get; set; }
    }

    public class Notes
    {
        public List<object> note { get; set; }
    }

    public class People
    {
        public int haspeople { get; set; }
    }

    public class Tags
    {
        public List<object> tag { get; set; }
    }

    public class Neighbourhood
    {
        public string _content { get; set; }
        public string place_id { get; set; }
        public string woeid { get; set; }
    }

    public class Locality
    {
        public string _content { get; set; }
        public string place_id { get; set; }
        public string woeid { get; set; }
    }

    public class County
    {
        public string _content { get; set; }
        public string place_id { get; set; }
        public string woeid { get; set; }
    }

    public class Region
    {
        public string _content { get; set; }
        public string place_id { get; set; }
        public string woeid { get; set; }
    }

    public class Country
    {
        public string _content { get; set; }
        public string place_id { get; set; }
        public string woeid { get; set; }
    }

    public class Location
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int accuracy { get; set; }
        public int context { get; set; }
        public Neighbourhood neighbourhood { get; set; }
        public Locality locality { get; set; }
        public County county { get; set; }
        public Region region { get; set; }
        public Country country { get; set; }
        public string place_id { get; set; }
        public string woeid { get; set; }
    }

    public class Geoperms
    {
        public int ispublic { get; set; }
        public int iscontact { get; set; }
        public int isfriend { get; set; }
        public int isfamily { get; set; }
    }

    public class Url
    {
        public string type { get; set; }
        public string _content { get; set; }
    }

    public class Urls
    {
        public List<Url> url { get; set; }
    }

    public class Photo
    {
        public string id { get; set; }
        public string secret { get; set; }
        public string server { get; set; }
        public int farm { get; set; }
        public string dateuploaded { get; set; }
        public int isfavorite { get; set; }
        public int license { get; set; }
        public int safety_level { get; set; }
        public int rotation { get; set; }
        public string originalsecret { get; set; }
        public string originalformat { get; set; }
        public Owner owner { get; set; }
        public Title title { get; set; }
        public Description description { get; set; }
        public Visibility visibility { get; set; }
        public Dates dates { get; set; }
        public int views { get; set; }
        public Editability editability { get; set; }
        public Publiceditability publiceditability { get; set; }
        public Usage usage { get; set; }
        public Comments comments { get; set; }
        public Notes notes { get; set; }
        public People people { get; set; }
        public Tags tags { get; set; }
        public Location location { get; set; }
        public Geoperms geoperms { get; set; }
        public Urls urls { get; set; }
        public string media { get; set; }
    }

    public class RootObject
    {
        public Photo photo { get; set; }
        public string stat { get; set; }
    }
}
