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

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.ServiceGuide
{
    public abstract class ServiceGuideBase<Ttarget, Tsource> : SearchCriteriaBase<Ttarget, Tsource>
    {
        public ServiceGuideBase()
            : base("STHLM_DATA_SERVICE_URI_SERVICEGUIDE")
        {
            APIKeyResourceName = "STHLM_DATA_API_KEY_SERVICEGUIDE";
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
