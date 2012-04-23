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

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Goteborg.Parking
{
    public class CommuterParkings : IMapper<Models.Goteborg.Parking.CommuterParking, Models.JSON.Goteborg.CommuterParkings.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Goteborg.Parking.CommuterParking> JSON2Model(Models.JSON.Goteborg.CommuterParkings.RootObject root)
        {
            foreach (var item in root.features)
            {
                yield return new Models.Goteborg.Parking.CommuterParking()
                {
                    Content = item.Name,
                    Location = new System.Device.Location.GeoCoordinate(item.Lat, item.Long),
                    ParkingSpaces = item.ParkingSpaces,
                    ExtraInfo = item.ExtraInfo,
                    FreeSpaces = item.FreeSpaces,
                    FreeSpacesDate = item.FreeSpacesDate
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Goteborg.Parking.CommuterParking> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Goteborg.CommuterParkings.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.Parking.CommuterParking JSON2FirstModel(Models.JSON.Goteborg.CommuterParkings.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.Parking.CommuterParking JSON2LastModel(Models.JSON.Goteborg.CommuterParkings.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
