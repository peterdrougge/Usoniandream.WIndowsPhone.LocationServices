
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
using Usoniandream.WindowsPhone.GeoConverter.Positions;

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.Place
{
    public abstract class PlaceWithPaddingBase<Ttarget, Tsource> : SearchCriteriaWithPaddingBase<Ttarget, Tsource>
    {
        public PlaceWithPaddingBase()
            : base("STHLM_DATA_SERVICE_URI_PLACE", "{\"features\":", "}")
        {
            ApplyDefaultSearchValues();

        }
        public PlaceWithPaddingBase(GeoCoordinate pointOfOrigin, Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.ServiceGuideSortByEnum sortBy, Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.ServiceGuideSortOrderEnum sortOrder, int maxHits)
            : base("STHLM_DATA_SERVICE_URI_PLACE", "{\"features\":", "}")
        {
            this.PointOfOrigin = pointOfOrigin;
            this.SortBy = sortBy;
            this.SortOrder = SortOrder;
            this.MaxHits = maxHits;

            ApplyDefaultSearchValues();
            ApplySortBy();
            ApplySortOrder();
        }

        private void ApplySortOrder()
        {
            switch (this.SortOrder)
            {
                case Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.ServiceGuideSortOrderEnum.Ascending:
                    Request.AddParameter("sortDirection", "Ascending");
                    break;
                case Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.ServiceGuideSortOrderEnum.Descending:
                    Request.AddParameter("sortDirection", "Descending");
                    break;
                default:
                    break;
            }
        }

        private void ApplySortBy()
        {
            switch (this.SortBy)
            {
                case Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.ServiceGuideSortByEnum.Unsorted:
                    Request.AddParameter("sortBy", "Unsorted");
                    break;
                case Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.ServiceGuideSortByEnum.Name:
                    Request.AddParameter("sortBy", "Name");
                    break;
                case Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.ServiceGuideSortByEnum.DistanceToGeographicalPosition:
                    Request.AddParameter("sortBy", "DistanceToGeographicalPosition");

                    WGS84 orgpos = new WGS84(PointOfOrigin.Latitude, PointOfOrigin.Longitude);
                    RT90 pos = new RT90(orgpos, RT90.RT90Projection.rt90_2_5_gon_v);
                    Request.AddParameter("geographicalPosition", string.Format("{0},{1}", (int)pos.Latitude, (int)pos.Longitude));
                    break;
                default:
                    break;
            }

        }

        private void ApplyDefaultSearchValues()
        {
            APIKeyResourceName = "STHLM_DATA_API_KEY_PLACE";
            Request.AddParameter("apiKey", APIkey);
            if (MaxHits > 0)
            {
                Request.AddParameter("pageSize", MaxHits);
                Request.AddParameter("pageNumber", 1);
            }
        }
        public GeoCoordinate PointOfOrigin { get; private set; }
        public int MaxHits { get; private set; }
        public Models.Enums.Stockholm.ServiceGuideSortByEnum SortBy { get; set; }
        public Models.Enums.Stockholm.ServiceGuideSortOrderEnum SortOrder { get; set; }
    }
}
