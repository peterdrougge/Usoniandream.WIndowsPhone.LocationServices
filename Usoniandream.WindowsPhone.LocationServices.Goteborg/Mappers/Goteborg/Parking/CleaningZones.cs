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
    public class CleaningZones : IMapper<Models.Goteborg.Parking.CleaningZone, Models.JSON.Goteborg.CleaningZones.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Goteborg.Parking.CleaningZone> JSON2Model(Models.JSON.Goteborg.CleaningZones.RootObject root)
        {
            foreach (var item in root.features)
            {
                yield return new Models.Goteborg.Parking.CleaningZone()
                {
                    Content = item.StreetName,
                    Location = new System.Device.Location.GeoCoordinate(item.Lat, item.Long),
                    CurrentPeriodStart = item.CurrentPeriodStart,
                    CurrentPeriodEnd = item.CurrentPeriodEnd,
                    ActivePeriodText = item.ActivePeriodText,
                    WeekDay = item.WeekDay,
                    StartMonth = item.StartMonth,
                    StartDay = item.StartDay,
                    StartHour = item.StartHour,
                    EndMonth = item.EndMonth,
                    EndDay = item.EndDay,
                    EndHour = item.EndHour,
                    OnlyEvenWeeks = item.OnlyEvenWeeks
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Goteborg.Parking.CleaningZone> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Goteborg.CleaningZones.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.Parking.CleaningZone JSON2FirstModel(Models.JSON.Goteborg.CleaningZones.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.Parking.CleaningZone JSON2LastModel(Models.JSON.Goteborg.CleaningZones.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}