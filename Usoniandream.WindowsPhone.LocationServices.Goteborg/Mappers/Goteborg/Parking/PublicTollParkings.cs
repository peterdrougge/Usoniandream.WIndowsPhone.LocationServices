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
    public class PublicTollParkings : IMapper<Models.Goteborg.Parking.PublicTollParking, Models.JSON.Goteborg.PublicTollParkings.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Goteborg.Parking.PublicTollParking> JSON2Model(Models.JSON.Goteborg.PublicTollParkings.RootObject root)
        {
            foreach (var item in root.features)
            {
                yield return new Models.Goteborg.Parking.PublicTollParking()
                {
                    Content = item.Name,
                    Location = new System.Device.Location.GeoCoordinate(item.Lat, item.Long),
                    MaxParkingTime = item.MaxParkingTime,
                    CurrentParkingCost = item.CurrentParkingCost,
                    ParkingCost = item.ParkingCost,
                    Owner = item.Owner,
                    ParkingSpaces = item.ParkingSpaces,
                    ExtraInfo = item.ExtraInfo,
                    FreeSpaces = item.FreeSpaces,
                    FreeSpacesDate = item.FreeSpacesDate,
                    MaxParkingTimeLimitation = item.MaxParkingTimeLimitation,
                    ParkingCharge = item.ParkingCharge
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Goteborg.Parking.PublicTollParking> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Goteborg.PublicTollParkings.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.Parking.PublicTollParking JSON2FirstModel(Models.JSON.Goteborg.PublicTollParkings.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.Parking.PublicTollParking JSON2LastModel(Models.JSON.Goteborg.PublicTollParkings.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}