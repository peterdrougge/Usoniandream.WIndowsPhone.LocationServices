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
using System.Diagnostics;
using System.Collections.Generic;

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Nokia.Places
{
    public class Place : IMapper<Models.Nokia.Places.Place, Models.JSON.Nokia.Places.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Nokia.Places.Place> JSON2Model(Models.JSON.Nokia.Places.RootObject root)
        {
            foreach (var item in root.results.items)
            {
                yield return new Models.Nokia.Places.Place()
                {
                    AverageRating = item.averageRating,
                    Category = new Models.Nokia.Places.Category()
                    {
                        Id = item.category.id,
                        Title = item.category.title,
                        Type = item.category.type,
                        URL = item.category.href
                    },
                    Location = new System.Device.Location.GeoCoordinate(item.position[0], item.position[1]),
                     Distance = item.distance,
                     Icon = item.icon,
                     Id = item.id,
                     Title = item.title,
                     Type = item.type,
                     URL = item.href,
                     Vicinity = item.vicinity
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Nokia.Places.Place> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Nokia.Places.RootObject> root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new List<Models.Nokia.Places.Place>();
        }

        public Models.Nokia.Places.Place JSON2FirstModel(Models.JSON.Nokia.Places.RootObject root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new Models.Nokia.Places.Place();
        }

        public Models.Nokia.Places.Place JSON2LastModel(Models.JSON.Nokia.Places.RootObject root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new Models.Nokia.Places.Place();
        }

        public void Dispose()
        {
            //
        }
    }
}
