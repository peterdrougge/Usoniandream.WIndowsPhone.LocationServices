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
using System.Windows.Media.Imaging;

namespace Usoniandream.WindowsPhone.LocationServices.Models.Goteborg.TrafficCamera
{
    public class TrafficCamera : ILocation
    {
        public int ID { get; set; }
        public int StorageDurationMinutes { get; set; }
        public int CaptureIntervalSeconds { get; set; }
        public string Model { get; set; }
        public string ImageURL { get; set; }

        public BitmapImage Image
        {
            get
            {
                return new BitmapImage(new Uri(ImageURL)) { CreateOptions = BitmapCreateOptions.BackgroundCreation };
            }
        }
        public object Content { get; set; }

        public System.Device.Location.GeoCoordinate Location
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}