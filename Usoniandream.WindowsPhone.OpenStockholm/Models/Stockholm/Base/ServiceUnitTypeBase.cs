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

namespace Usoniandream.WindowsPhone.LocationServices.Models.Stockholm.Base
{
    public abstract class ServiceUnitTypeBase : ILocation, Usoniandream.WindowsPhone.LocationServices.Models.Stockholm.Base.IServiceUnitType
    {
        public virtual GeoCoordinate Location { get; set; }
        public virtual object Content { get; set; }
        public string ID { get; set; }

        public string GroupName { get; set; }
    }
}
