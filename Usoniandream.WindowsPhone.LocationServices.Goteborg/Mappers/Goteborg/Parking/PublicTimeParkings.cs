﻿using System;
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
    public class PublicTimeParkings : IMapper<Models.Goteborg.Parking.PublicTimeParking, Models.JSON.Goteborg.PublicTimeParkings.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Goteborg.Parking.PublicTimeParking> JSON2Model(Models.JSON.Goteborg.PublicTimeParkings.RootObject root)
        {
            foreach (var item in root.features)
            {
                yield return new Models.Goteborg.Parking.PublicTimeParking()
                {
                    Content = item.Name,
                    Location = new System.Device.Location.GeoCoordinate(item.Lat, item.Long),
                    MaxParkingTime = item.MaxParkingTime,
                    MaxParkingTimeLimitation = item.MaxParkingTimeLimitation,
                    Owner = item.Owner,
                    ParkingSpaces = item.ParkingSpaces,
                    ExtraInfo = item.ExtraInfo
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Goteborg.Parking.PublicTimeParking> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Goteborg.PublicTimeParkings.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.Parking.PublicTimeParking JSON2FirstModel(Models.JSON.Goteborg.PublicTimeParkings.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.Parking.PublicTimeParking JSON2LastModel(Models.JSON.Goteborg.PublicTimeParkings.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
