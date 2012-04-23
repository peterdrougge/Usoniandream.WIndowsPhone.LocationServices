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
using System.Collections.Generic;
using System.Diagnostics;

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Stockholm.Parking
{
    public class ParkingLocation : IMapper<Models.Stockholm.ParkingLocation, Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ParkingPlaces.RootObject>
    {
        public IEnumerable<Models.Stockholm.ParkingLocation> JSON2Model(Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ParkingPlaces.RootObject root)
        {
            foreach (var item in root.features)
            {
                yield return new Models.Stockholm.ParkingLocation()
                {
                    Content = item.properties.STREET_NAME,
                    Coordinates = item.geometry.coordinates,
                    CityDistrict = item.properties.CITY_DISTRICT,
                    MaxDays = item.properties.MAX_DAYS,
                    MaxHours = item.properties.MAX_HOURS,
                    MaxMinutes = item.properties.MAX_MINUTES,
                    OtherInfo = item.properties.OTHER_INFO,
                    Meters = item.properties.VF_METER,
                    Type = item.properties.VF_PLATS_TYP,
                    StartWeekDay = item.properties.START_WEEKDAY,
                    Location = new System.Device.Location.GeoCoordinate(
                        item.geometry.coordinates[0][1],
                        item.geometry.coordinates[0][0])
                };
            }
        }


        public Models.Stockholm.ParkingLocation JSON2FirstModel(Models.JSON.Stockholm.ParkingPlaces.RootObject root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new Models.Stockholm.ParkingLocation();
        }

        public Models.Stockholm.ParkingLocation JSON2LastModel(Models.JSON.Stockholm.ParkingPlaces.RootObject root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new Models.Stockholm.ParkingLocation();
        }

        public IEnumerable<Models.Stockholm.ParkingLocation> JSON2Model(IEnumerable<Models.JSON.Stockholm.ParkingPlaces.RootObject> root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new List<Models.Stockholm.ParkingLocation>();
        }

        public void Dispose()
        {
            // clean up if needed..
        }

    }
}
