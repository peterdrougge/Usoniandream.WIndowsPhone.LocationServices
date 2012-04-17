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

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.Parking.ParkingLocation
{
    public class ParkingLocationsByRadius : ParkingLocationsBase
    {
        public ParkingLocationsByRadius(int radius, Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.VehicleTypeEnum vehicletype)
            : base(vehicletype)
        {
            Radius = radius;

            Request.Resource += "within?";
            
            Request.AddParameter("radius", Radius);
            Request.AddParameter("lat", Location.Latitude.ToString().Replace(",", "."));
            Request.AddParameter("&lng",Location.Longitude.ToString().Replace(",", "."));
        }

        public GeoCoordinate Location { get; set; }
        public int Radius { get; private set; }
    }
}