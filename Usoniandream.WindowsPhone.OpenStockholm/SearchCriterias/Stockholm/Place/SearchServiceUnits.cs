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

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.Place
{
    public class SearchServiceUnits : PlaceBase<Models.Stockholm.Place.ServiceUnit, Models.JSON.Stockholm.ServiceUnits.RootObject>
    {
        public SearchServiceUnits(string namecontains)
            : base()
        {
            Mapper = new Mappers.Stockholm.Place.ServiceUnits();

            NameContains = namecontains;

            Request.Resource += "/ServiceUnits/json";

            Request.AddParameter("name", NameContains);
        }
        public string NameContains { get; set; }
    }
}
