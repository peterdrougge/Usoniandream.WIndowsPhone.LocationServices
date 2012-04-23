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
using Usoniandream.WindowsPhone.GeoConverter.Positions;

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Stockholm.Place
{
    public class ServiceUnits : IMapper<Models.Stockholm.Place.ServiceUnit, Models.JSON.Stockholm.ServiceUnits.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Stockholm.Place.ServiceUnit> JSON2Model(Models.JSON.Stockholm.ServiceUnits.RootObject root)
        {
            foreach (var item in root.features)
            {
                RT90 rt90pos = new RT90(item.GeographicalPosition.X, item.GeographicalPosition.Y, RT90.RT90Projection.rt90_2_5_gon_v);
                WGS84 pos = rt90pos.ToWGS84();
                yield return new Models.Stockholm.Place.ServiceUnit()
                {
                    Content = item.Name,
                    ID = item.Id,
                    Location = new System.Device.Location.GeoCoordinate(pos.Latitude, pos.Longitude)
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Stockholm.Place.ServiceUnit> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Stockholm.ServiceUnits.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Stockholm.Place.ServiceUnit JSON2FirstModel(Models.JSON.Stockholm.ServiceUnits.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Stockholm.Place.ServiceUnit JSON2LastModel(Models.JSON.Stockholm.ServiceUnits.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
