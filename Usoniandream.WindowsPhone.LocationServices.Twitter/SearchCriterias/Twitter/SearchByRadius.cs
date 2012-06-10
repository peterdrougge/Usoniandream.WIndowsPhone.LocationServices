
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

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Twitter
{
    /// <summary>
    /// The search criteria for radius based twitter search
    /// </summary>
    public class SearchByRadius : TwitterSearchCriteriaBase<Models.Twitter.Tweet, Models.JSON.Twitter.Search.RootObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchByRadius"/> class.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="radiusKilometer">The radius in kilometers.</param>
        public SearchByRadius(GeoCoordinate location, double radiusKilometer)
            : base(SearchCriteriaResultType.Collection)
        {
            SetDefaultCriteria(location, radiusKilometer);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchByRadius"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="location">The location.</param>
        /// <param name="radiusKilometer">The radius in kilometers.</param>
        public SearchByRadius(string query, GeoCoordinate location, double radiusKilometer)
            : base(query, SearchCriteriaResultType.Collection)
        {
            SetDefaultCriteria(location, radiusKilometer);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchByRadius"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="location">The location.</param>
        /// <param name="radiusKilometer">The radius in kilometers.</param>
        /// <param name="since">date to go back when searching.</param>
        public SearchByRadius(string query, GeoCoordinate location, double radiusKilometer, DateTime since)
            : base(query, since, SearchCriteriaResultType.Collection)
        {
            SetDefaultCriteria(location, radiusKilometer);
        }

        private void SetDefaultCriteria(GeoCoordinate location, double radiusKilometer)
        {
            base.SkipAPIKeyCheck = true;

            Location = location;
            Radius = radiusKilometer;
            Mapper = new Mappers.Twitter.Search();

            Request.AddParameter("geocode", string.Format("{0},{1},{2}km", Location.Latitude.ToString().Replace(",", "."), Location.Longitude.ToString().Replace(",", "."), Radius.ToString().Replace(",", ".")));
        }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        public GeoCoordinate Location { get; set; }
        /// <summary>
        /// Gets or sets the radius.
        /// </summary>
        /// <value>
        /// The radius.
        /// </value>
        public double Radius { get; set; }
    }
}
