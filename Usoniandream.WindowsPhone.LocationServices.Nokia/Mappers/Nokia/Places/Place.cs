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

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Nokia.Places
{
    public class Place : IMapper<Models.Nokia.Places.PlaceDetails, Models.JSON.Nokia.Place.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Nokia.Places.PlaceDetails> JSON2Model(Models.JSON.Nokia.Place.RootObject root)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Models.Nokia.Places.PlaceDetails> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Nokia.Place.RootObject> root)
        {
            throw new NotImplementedException();
        }

        private Models.Nokia.Places.Category GetCategoryInformation(Models.JSON.Nokia.Place.RootObject item)
        {
            return new Models.Nokia.Places.Category();
        }

        public Models.Nokia.Places.PlaceDetails JSON2FirstModel(Models.JSON.Nokia.Place.RootObject root)
        {
            if (root.location!=null)
            {
                if (root.location.position != null && root.location.position.Count == 2)
                {
                    return new Models.Nokia.Places.PlaceDetails()
                    {
                        Content = root.name,
                        //AverageRating = root.ratings.average,
                        Category = GetCategoryInformation(root),
                        Location = new System.Device.Location.GeoCoordinate(root.location.position[0], root.location.position[1]),
                        Icon = root.icon,
                        Id = root.placeId,
                        Name = root.name
                        //StreetAddress = root.location.address.street,
                        //Phone = root.contacts.phone,
                        //Website = root.contacts.website,
                        //OpeningHours = root.extended.openingHours
                    };
                }
            }
            return new Models.Nokia.Places.PlaceDetails();
        }

        public Models.Nokia.Places.PlaceDetails JSON2LastModel(Models.JSON.Nokia.Place.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
