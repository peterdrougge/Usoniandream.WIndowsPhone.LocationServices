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
using Usoniandream.WindowsPhone.LocationServices.Mappers;

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Goteborg.Parking
{
    public class BusParkings : IMapper<Models.Goteborg.Parking.BusParking, Models.JSON.Goteborg.BusParkings.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Goteborg.Parking.BusParking> JSON2Model(Models.JSON.Goteborg.BusParkings.RootObject root)
        {
            foreach (var item in root.features)
            {
                yield return new Models.Goteborg.Parking.BusParking()
                {
                    Content = item.Name,
                    Location = new System.Device.Location.GeoCoordinate(item.Lat, item.Long),
                    MaxParkingTime = item.MaxParkingTime,
                    Owner = item.Owner,
                    ParkableLength = item.ParkableLength,
                    ParkingSpaceCount = item.ParkingSpaceCount,
                    MaxParkingTimeLimitation = item.MaxParkingTimeLimitation
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Goteborg.Parking.BusParking> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Goteborg.BusParkings.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.Parking.BusParking JSON2FirstModel(Models.JSON.Goteborg.BusParkings.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.Parking.BusParking JSON2LastModel(Models.JSON.Goteborg.BusParkings.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
