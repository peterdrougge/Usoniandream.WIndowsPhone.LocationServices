﻿//
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

namespace Usoniandream.WindowsPhone.LocationServices.Models.Nokia.Places
{
    public partial class Place : ILocation
    {
        public double Distance { get; set; }
        public string Title { get; set; }
        public double AverageRating { get; set; }
        public string Icon { get; set; }
        public string Vicinity { get; set; }
        public string Type { get; set; }
        public string URL { get; set; }
        public string Id { get; set; }
        public Category Category { get; set; }
        public GeoCoordinate Location { get; set; }
        public object Content { get; set; }
        public bool Sponsored { get; set; }
    }
}
