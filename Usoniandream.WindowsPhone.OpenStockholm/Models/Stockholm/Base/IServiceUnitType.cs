using System;
namespace Usoniandream.WindowsPhone.LocationServices.Models.Stockholm.Base
{
    public interface IServiceUnitType
    {
        object Content { get; set; }
        string GroupName { get; set; }
        string ID { get; set; }
        System.Device.Location.GeoCoordinate Location { get; set; }
    }
}
