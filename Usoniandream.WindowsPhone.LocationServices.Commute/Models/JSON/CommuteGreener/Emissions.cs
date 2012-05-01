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

namespace Usoniandream.WindowsPhone.LocationServices.Models.JSON.CommuteGreener.Emissions
{
    public class Params
    {
        public string format { get; set; }
        public string startLat { get; set; }
        public string endLat { get; set; }
        public string endLng { get; set; }
        public string startLng { get; set; }
    }

    public class Emission
    {
        public int routedDistance { get; set; }
        public string transportCategory { get; set; }
        public string transportName { get; set; }
        public int totalCo2 { get; set; }
    }

    public class RootObject
    {
        public Params @params { get; set; }
        public List<Emission> emissions { get; set; }
    }
}
