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

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.ServiceGuide
{
    public class ServiceUnitTypes : ServiceGuideBase<Models.Stockholm.ServiceGuide.ServiceUnitType, Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject>
    {
        public ServiceUnitTypes() : base()
        {
            Mapper = new Mappers.Stockholm.ServiceGuide.ServiceUnitTypes();
            Request.Resource += "/ServiceUnitTypes/json/";
        }
    }
}
