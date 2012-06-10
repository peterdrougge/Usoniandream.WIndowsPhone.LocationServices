
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

namespace Usoniandream.WindowsPhone.LocationServices.Models.JSON.Eniro.CompanySearch
{
    public class CompanyInfo
    {
        public string companyName { get; set; }
        public string orgNumber { get; set; }
        public string companyText { get; set; }
    }

    public class Address
    {
        public string streetName { get; set; }
        public string postCode { get; set; }
        public string postArea { get; set; }
        public object postBox { get; set; }
    }

    public class Coordinate
    {
        public double? longitude { get; set; }
        public double? latitude { get; set; }
        public string use { get; set; }
    }

    public class Location
    {
        public List<Coordinate> coordinates { get; set; }
    }

    public class PhoneNumber
    {
        public string type { get; set; }
        public string phoneNumber { get; set; }
        public string label { get; set; }
    }

    public class Advert
    {
        public string eniroId { get; set; }
        public CompanyInfo companyInfo { get; set; }
        public Address address { get; set; }
        public Location location { get; set; }
        public List<PhoneNumber> phoneNumbers { get; set; }
        public string companyReviews { get; set; }
        public string homepage { get; set; }
        public string infoPageLink { get; set; }
    }

    public class RootObject
    {
        public string title { get; set; }
        public string query { get; set; }
        public int totalHits { get; set; }
        public int totalCount { get; set; }
        public int startIndex { get; set; }
        public int itemsPerPage { get; set; }
        public List<Advert> adverts { get; set; }
    }
}
