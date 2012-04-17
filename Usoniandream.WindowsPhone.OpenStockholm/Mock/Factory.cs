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
using System.Collections.ObjectModel;
using System.Device.Location;
using Microsoft.Phone.Reactive;
using System.Collections.Generic;
using Usoniandream.WindowsPhone.Extensions;
using Usoniandream.StockholmParking.Extensions;

namespace Usoniandream.WindowsPhone.OpenStockholm.Data.Mock
{
    public class Factory
    {
        public static IEnumerable<Models.ParkingMeter> ParkingMeters(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return new Models.ParkingMeter() { Content = "automat " + i.ToString(), AcceptsCards = i % 2 > 1, ResidentButton = i % 4 > 1, AcceptsCoins = i % 3 > 1, GeoLocation = GetGeoCoordinate(i) };
            }
        }

        public static IEnumerable<Models.ParkingLocation> ParkingPlaces(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return new Models.ParkingLocation() { Content = "parkering " + i.ToString(), GeoLocation = GetGeoCoordinate(i) };
            }
        }

        private static GeoCoordinate GetGeoCoordinate(double count)
        {
            Random rand = new Random();
            double latitude = 59.36206; // 59.36206
            double longitude = 17.86462; // 17.86462
            if (GeoHelper.Watcher.Status == GeoPositionStatus.Ready)
            {
                latitude = GeoHelper.Watcher.Position.Location.Latitude;
                longitude = GeoHelper.Watcher.Position.Location.Longitude;
            }

            latitude = latitude + (count + (double)rand.Next(-100, 100)) / 100000;
            longitude = longitude + (count + (double)rand.Next(-100, 100)) / 100000;

            return new GeoCoordinate(latitude, longitude);
        }

    }
}
