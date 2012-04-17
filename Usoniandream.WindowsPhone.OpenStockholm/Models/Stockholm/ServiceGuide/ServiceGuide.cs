using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Device.Location;

namespace Usoniandream.WindowsPhone.LocationServices.Models.Stockholm
{
    public class ServiceGuide : ILocation
    {
        public virtual GeoCoordinate Location { get; set; }
        public virtual object Content { get; set; }
        public string ID { get; set; }
    }
}
