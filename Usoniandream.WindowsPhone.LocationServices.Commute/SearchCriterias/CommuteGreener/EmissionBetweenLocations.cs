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
using System.Device.Location;

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.CommuteGreener
{
    public class EmissionBetweenLocations : SearchCriteriaBase<Models.CommuteGreener.Emission, Models.JSON.CommuteGreener.Emissions.RootObject>
    {
        public EmissionBetweenLocations(GeoCoordinate startlocation, GeoCoordinate endlocation)
            : base("COMMUTEGREENER_DATA_SERVICE_URI")
        {
            SkipAPIKeyCheck = true;
            APIKeyResourceName = "NO NEED FOR A KEY - IT'S PUBLIC";
            StartLocation = startlocation;
            EndLocation = endlocation;

            Mapper = new Mappers.CommuteGreener.Emission();

            Request.Resource = "emissions";
            Request.AddParameter("startLat", StartLocation.Latitude.ToString().Replace(",", "."));
            Request.AddParameter("startLng", StartLocation.Longitude.ToString().Replace(",", "."));
            Request.AddParameter("endLat", EndLocation.Latitude.ToString().Replace(",", "."));
            Request.AddParameter("endLng", EndLocation.Longitude.ToString().Replace(",", "."));
            Request.AddParameter("format", "json");
        }
        public GeoCoordinate StartLocation { get; set; }
        public GeoCoordinate EndLocation { get; set; }

        public int Radius { get; set; }
    }
}
