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

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.Place
{
    public class SearchServiceUnits : PlaceWithPaddingBase<Models.Stockholm.Place.ServiceUnit, Models.JSON.Stockholm.ServiceUnits.RootObject>
    {
        public string NameContains { get; protected set; }

        public SearchServiceUnits(string namecontains)
            : base(null, Models.Enums.Stockholm.ServiceGuideSortByEnum.Name, Models.Enums.Stockholm.ServiceGuideSortOrderEnum.Ascending, 0, SearchCriteriaResultType.Collection)
        {
            ApplyDefaultSearchCriterias(namecontains);
        }

        public SearchServiceUnits(string namecontains, GeoCoordinate location)
            : base(location, Models.Enums.Stockholm.ServiceGuideSortByEnum.DistanceToGeographicalPosition, Models.Enums.Stockholm.ServiceGuideSortOrderEnum.Ascending, 0, SearchCriteriaResultType.Collection)
        {
            ApplyDefaultSearchCriterias(namecontains);
        }
        public SearchServiceUnits(string namecontains, GeoCoordinate location, int maxHits)
            : base(location, Models.Enums.Stockholm.ServiceGuideSortByEnum.DistanceToGeographicalPosition, Models.Enums.Stockholm.ServiceGuideSortOrderEnum.Ascending, maxHits, SearchCriteriaResultType.Collection)
        {
            ApplyDefaultSearchCriterias(namecontains);
        }

        private void ApplyDefaultSearchCriterias(string namecontains)
        {
            Mapper = new Mappers.Stockholm.Place.ServiceUnits();
            NameContains = namecontains;
            Request.Resource += "/ServiceUnits/json";
            if (String.IsNullOrWhiteSpace(NameContains))
            {
                NameContains = String.Empty;
            }
            Request.AddParameter("name", NameContains);
        }
    }
}
