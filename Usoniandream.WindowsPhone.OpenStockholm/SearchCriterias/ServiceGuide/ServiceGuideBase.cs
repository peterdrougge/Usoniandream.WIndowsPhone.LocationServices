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
    public class ServiceGuideBase : SearchCriteriaBase<Models.Stockholm.ServiceGuide, Models.JSON.Stockholm.ServiceGuide.RootObject>
    {
        public ServiceGuideBase()
            : base("STHLM_DATA_SERVICE_URI_SERVICEGUIDE")
        {
            Mapper = new Mappers.Stockholm.ServiceGuide.ServiceGuide();
            APIKeyResourceName = "STHLM_DATA_API_KEY_SERVICEGUIDE";
            Request.AddParameter("apiKey", APIkey);
        }
    }
}
