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
using System.Device.Location;

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Goteborg.Parking
{
    public class BusParkingsByRadius: ParkingLocationsByRadiusBase<Models.Goteborg.Parking.BusParking, Models.JSON.Goteborg.BusParkings.RootObject>
    {
        public BusParkingsByRadius(int radius, GeoCoordinate location)
            : base("BusParkings/", radius, location)
        {
            Mapper = new Mappers.Goteborg.Parking.BusParkings();
        }
    }
}
