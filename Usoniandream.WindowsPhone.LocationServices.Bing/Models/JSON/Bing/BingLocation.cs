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

namespace Usoniandream.WindowsPhone.LocationServices.Models.JSON.Bing.BingLocation
{
    public class Point
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }

    public class Address
    {
        public string addressLine { get; set; }
        public string adminDistrict { get; set; }
        public string countryRegion { get; set; }
        public string formattedAddress { get; set; }
        public string locality { get; set; }
        public string postalCode { get; set; }
    }

    public class GeocodePoint
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
        public string calculationMethod { get; set; }
        public List<string> usageTypes { get; set; }
    }

    public class Resource
    {
        public string __type { get; set; }
        public List<double> bbox { get; set; }
        public string name { get; set; }
        public Point point { get; set; }
        public Address address { get; set; }
        public string confidence { get; set; }
        public string entityType { get; set; }
        public List<GeocodePoint> geocodePoints { get; set; }
        public List<string> matchCodes { get; set; }
    }

    public class ResourceSet
    {
        public int estimatedTotal { get; set; }
        public List<Resource> resources { get; set; }
    }

    public class RootObject
    {
        public string authenticationResultCode { get; set; }
        public string brandLogoUri { get; set; }
        public string copyright { get; set; }
        public List<ResourceSet> resourceSets { get; set; }
        public int statusCode { get; set; }
        public string statusDescription { get; set; }
        public string traceId { get; set; }
    }
}
