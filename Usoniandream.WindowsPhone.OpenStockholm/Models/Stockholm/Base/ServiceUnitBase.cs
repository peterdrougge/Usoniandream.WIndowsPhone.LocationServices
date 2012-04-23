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

namespace Usoniandream.WindowsPhone.LocationServices.Models.Stockholm.Base
{
    public abstract class ServiceUnitBase : ILocation, Usoniandream.WindowsPhone.LocationServices.Models.Stockholm.Base.IServiceUnit
    {
        public object Content
        {
            get;
            set;
        }

        public System.Device.Location.GeoCoordinate Location
        {
            get;
            set;
        }

        public string ID { get; set; }
    }
}
