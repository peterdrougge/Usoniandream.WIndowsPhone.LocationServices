using System;
namespace Usoniandream.WindowsPhone.LocationServices.Models.Stockholm.Base
{
    public interface IServiceUnitType : ILocation
    {
        string GroupName { get; set; }
        string ID { get; set; }
    }
}
