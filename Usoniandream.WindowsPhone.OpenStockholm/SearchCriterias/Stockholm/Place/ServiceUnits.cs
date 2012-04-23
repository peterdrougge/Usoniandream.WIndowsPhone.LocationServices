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
using Usoniandream.WindowsPhone.GeoConverter.Positions;
using System.Device.Location;

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.Place
{
    public class ServiceUnits : PlaceBase<Models.Stockholm.Place.ServiceUnit, Models.JSON.Stockholm.ServiceUnits.RootObject>
    {
        public ServiceUnits(string id) : base()
        {
            Mapper = new Mappers.Stockholm.Place.ServiceUnits();

            ID = id;

            Request.Resource += "/ServiceUnitTypes/" + ID + "/ServiceUnits/json/";
        }
        public string ID { get; set; }
    }
}
