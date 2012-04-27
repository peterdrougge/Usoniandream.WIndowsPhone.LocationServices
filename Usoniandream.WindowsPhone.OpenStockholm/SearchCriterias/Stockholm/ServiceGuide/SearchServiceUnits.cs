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
    public class SearchServiceUnits : ServiceGuideBase<Models.Stockholm.ServiceGuide.ServiceUnit, Models.JSON.Stockholm.ServiceUnits.RootObject>
    {
        public SearchServiceUnits(string namecontains) : base()
        {
            Mapper = new Mappers.Stockholm.ServiceGuide.ServiceUnits();

            NameContains = namecontains;

            Request.Resource += "/ServiceUnits/json";

            Request.AddParameter("name",NameContains);
        }

        public SearchServiceUnits(string namecontains, GeoCoordinate location) : base()
        {
            Mapper = new Mappers.Stockholm.ServiceGuide.ServiceUnits();

            PointOfOrigin = location;
            NameContains = namecontains;

            Request.Resource += "/ServiceUnits/json";

            Request.AddParameter("name",NameContains);
        }
        
        public string NameContains { get; set; }
    }
}
