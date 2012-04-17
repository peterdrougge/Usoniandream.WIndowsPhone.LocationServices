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

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Nokia.Places
{
    public class Place : SearchCriteriaBase<Models.Nokia.Places.Place, object>
    {
        public Place()
            : base("http://demo.places.nlp.nokia.com/places/v1/places/")
        {
            //Mapper = new Mappers.Nokia.Places.Place();

            Request.Resource = "discover/explore";

        }
    }
}
