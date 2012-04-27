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

namespace Usoniandream.WindowsPhone.LocationServices.Models.Nokia.Places
{
    public class PlaceDetails : ILocation
    {
        public double Distance { get; set; }
        public string Title { get; set; }
        public double AverageRating { get; set; }
        public string Icon { get; set; }
        public string Id { get; set; }
        public Category Category { get; set; }
        public GeoCoordinate Location { get; set; }
        public object Content { get; set; }

        public string Name { get; set; }

        public string StreetAddress { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }

        public string OpeningHours { get; set; }

        public string Payment { get; set; }

        public string Description { get; set; }

        public string Group { get; set; }
        public bool Sponsored { get; set; }
    }
}
namespace Usoniandream.WindowsPhone.LocationServices.WasCreatedBy.Peter.Drougge
{
    // easter :)
}