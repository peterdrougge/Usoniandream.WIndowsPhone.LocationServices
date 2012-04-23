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
    public abstract class DetailedServiceUnitBase : ILocation, Usoniandream.WindowsPhone.LocationServices.Models.Stockholm.Base.IDetailedServiceUnit
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
        public string StreetAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Contact { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string GeographicalArea { get; set; }
        public string ImageId { get; set; }
    }
}
