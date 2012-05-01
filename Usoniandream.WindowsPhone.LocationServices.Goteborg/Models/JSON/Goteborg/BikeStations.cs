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

namespace Usoniandream.WindowsPhone.LocationServices.Models.JSON.Goteborg.BikeStations
{
    public class Station
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public int Capacity { get; set; }
        public int FreeBikes { get; set; }
        public int FreeStands { get; set; }
        public string State { get; set; }
    }

    public class RootObject
    {
        public DateTime TimeStamp { get; set; }
        public List<Station> Stations { get; set; }
    }
}
