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

namespace Usoniandream.WindowsPhone.LocationServices.Models.JSON.Nokia.Places
{
    public class Category
    {
        public string id { get; set; }
        public string title { get; set; }
        public string href { get; set; }
        public string type { get; set; }
    }

    public class Item
    {
        public List<double> position { get; set; }
        public int distance { get; set; }
        public string title { get; set; }
        public double averageRating { get; set; }
        public Category category { get; set; }
        public string icon { get; set; }
        public string vicinity { get; set; }
        public List<object> having { get; set; }
        public string type { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public string places { get; set; }
        public string weight { get; set; }
        public bool sponsored { get; set; }
    }

    public class Results
    {
        public List<Item> items { get; set; }
    }

    public class Location
    {
        public List<double> position { get; set; }
    }

    public class Search
    {
        public Location location { get; set; }
    }

    public class RootObject
    {
        public Results results { get; set; }
        public Search search { get; set; }
    }
}
