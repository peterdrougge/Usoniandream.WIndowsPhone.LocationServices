using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Device.Location;

namespace Usoniandream.WindowsPhone.LocationServices.Models
{
    public interface ILocation
    {
        object Content { get; set; }
        GeoCoordinate Location { get; set; }
    }
}
