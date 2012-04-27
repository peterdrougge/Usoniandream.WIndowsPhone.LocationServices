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
    public abstract class PlaceBase<Ttarget, Tsource> : SearchCriteriaBase<Ttarget, Tsource>
    {
        public PlaceBase()
            : base("STHLM_DATA_SERVICE_URI_PLACE")
        {
            APIKeyResourceName = "STHLM_DATA_API_KEY_PLACE";
            Request.AddParameter("apiKey", APIkey);

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

                    RT90 pos = new RT90(PointOfOrigin.Latitude, PointOfOrigin.Longitude, RT90.RT90Projection.rt90_2_5_gon_v);
                    Request.AddParameter("geographicalPosition", string.Format("{0},{1}", pos.Latitude.ToString().Replace(",","."), pos.Longitude.ToString().Replace(",",".")));
                    break;
                default:
                    break;
            }

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
        public GeoCoordinate PointOfOrigin { get; set; }
        public Models.Enums.Stockholm.ServiceGuideSortByEnum SortBy { get; set; }
        public Models.Enums.Stockholm.ServiceGuideSortOrderEnum SortOrder { get; set; }
    }
}
