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
using System.ComponentModel;
using Usoniandream.WindowsPhone.GeoConverter.Positions;
using System.Device.Location;

namespace Usoniandream.WindowsPhone.LocationServices.Models.Stockholm
{
    public class ParkingMeter
    {
        public ParkingMeter()
        {}

        public ParkingMeter(Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ParkingMeters.Feature item)
        {
            SWEREF99 swerefpos = new SWEREF99(item.geometry.coordinates[0], item.geometry.coordinates[1], SWEREF99.SWEREFProjection.sweref_99_18_00);
            WGS84 pos = swerefpos.ToWGS84();
            GeoCoordinate coords = new GeoCoordinate(pos.Latitude, pos.Longitude);


            Status = item.properties.DESC2;
            Content = item.properties.DESC3.Trim();

            if (!String.IsNullOrEmpty(item.properties.DESC4))
            {
                AcceptsCoins = Boolean.Parse(item.properties.DESC4);
            }
            if (!String.IsNullOrEmpty(item.properties.DESC5))
            {
                AcceptsCards = Boolean.Parse(item.properties.DESC5);
            }
            if (!String.IsNullOrEmpty(item.properties.DESC6))
            {
                ResidentButton = Boolean.Parse(item.properties.DESC6);
            }
            CoinFlavours = item.properties.DESC8;
            GeoLocation = coords;

        }

        public virtual object Content { get; set; }
        public virtual GeoCoordinate GeoLocation { get; set; }

        // DESC2
        public string Status { get; set; }
        // DESC4
        public bool AcceptsCoins { get; set; }
        // DESC5
        public bool AcceptsCards { get; set; }
        // DESC6
        public bool ResidentButton { get; set; }
        // DESC8
        public string CoinFlavours { get; set; }

    }
}
