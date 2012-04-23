using System;
namespace Usoniandream.WindowsPhone.LocationServices.Models.Stockholm.Base
{
    public interface IDetailedServiceUnit
    {
        string Contact { get; set; }
        string ContactEmail { get; set; }
        string ContactPhone { get; set; }
        object Content { get; set; }
        string Description { get; set; }
        string GeographicalArea { get; set; }
        string ID { get; set; }
        string ImageId { get; set; }
        System.Device.Location.GeoCoordinate Location { get; set; }
        string PhoneNumber { get; set; }
        string ShortDescription { get; set; }
        string StreetAddress { get; set; }
    }
}
