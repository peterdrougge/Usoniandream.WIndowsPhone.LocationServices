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
using System.Diagnostics;

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Goteborg.Parking
{
    public class PrivateParkings : IMapper<Models.Goteborg.Parking.PrivateParking, Models.JSON.Goteborg.PrivateParkings.RootObject>
    {
        public System.Collections.Generic.IEnumerable<Models.Goteborg.Parking.PrivateParking> JSON2Model(Models.JSON.Goteborg.PrivateParkings.RootObject root)
        {
            foreach (var item in root.features)
            {
                yield return new Models.Goteborg.Parking.PrivateParking()
                {
                    Content = item.Name,
                    Location = new System.Device.Location.GeoCoordinate(item.Lat, item.Long),
                    MaxParkingTime = item.MaxParkingTime,
                    CurrentParkingCost = item.CurrentParkingCost,
                    ParkingCost = item.ParkingCost,
                    Owner = item.Owner,
                    ParkingSpaces = item.ParkingSpaces,
                    ExtraInfo = item.ExtraInfo
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Goteborg.Parking.PrivateParking> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Goteborg.PrivateParkings.RootObject> root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            throw new NotImplementedException();
        }

        public Models.Goteborg.Parking.PrivateParking JSON2FirstModel(Models.JSON.Goteborg.PrivateParkings.RootObject root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            throw new NotImplementedException();
        }

        public Models.Goteborg.Parking.PrivateParking JSON2LastModel(Models.JSON.Goteborg.PrivateParkings.RootObject root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //
        }
    }
}
