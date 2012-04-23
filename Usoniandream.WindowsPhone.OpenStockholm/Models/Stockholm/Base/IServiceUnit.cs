using System;
namespace Usoniandream.WindowsPhone.LocationServices.Models.Stockholm.Base
{
    public interface IServiceUnit
    {
        object Content { get; set; }
        string ID { get; set; }
        System.Device.Location.GeoCoordinate Location { get; set; }
    }
}
