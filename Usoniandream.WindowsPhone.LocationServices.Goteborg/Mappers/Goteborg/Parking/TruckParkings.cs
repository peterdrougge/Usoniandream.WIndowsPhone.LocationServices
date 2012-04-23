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
    public class TruckParkings : IMapper<Models.Goteborg.Parking.TruckParking, Models.JSON.Goteborg.TruckParkings.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Goteborg.Parking.TruckParking> JSON2Model(Models.JSON.Goteborg.TruckParkings.RootObject root)
        {
            foreach (var item in root.features)
            {
                yield return new Models.Goteborg.Parking.TruckParking()
                {
                    Content = item.Name,
                    Location = new System.Device.Location.GeoCoordinate(item.Lat, item.Long),
                    MaxParkingTime = item.MaxParkingTime,
                    Owner = item.Owner,
                    MaxParkingTimeLimitation = item.MaxParkingTimeLimitation,
                    ParkableLength = item.ParkableLength
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Goteborg.Parking.TruckParking> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Goteborg.TruckParkings.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.Parking.TruckParking JSON2FirstModel(Models.JSON.Goteborg.TruckParkings.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.Parking.TruckParking JSON2LastModel(Models.JSON.Goteborg.TruckParkings.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
