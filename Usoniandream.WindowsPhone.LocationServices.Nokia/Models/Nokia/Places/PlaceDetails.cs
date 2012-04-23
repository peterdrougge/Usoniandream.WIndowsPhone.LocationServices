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

        public System.Collections.Generic.List<JSON.Nokia.Place.Phone> Phone { get; set; }

        public System.Collections.Generic.List<JSON.Nokia.Place.Website> Website { get; set; }

        public JSON.Nokia.Place.OpeningHours OpeningHours { get; set; }
    }
}
