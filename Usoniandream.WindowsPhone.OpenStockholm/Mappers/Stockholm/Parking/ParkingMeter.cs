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
    public class ParkingMeter : IMapper<Models.Stockholm.ParkingMeter, Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ParkingMeters.RootObject>
    {
        public IEnumerable<Models.Stockholm.ParkingMeter> JSON2Model(Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ParkingMeters.RootObject root)
        {
            foreach (var item in root.features)
            {
                yield return new Models.Stockholm.ParkingMeter(item);
            }
        }

        public Models.Stockholm.ParkingMeter JSON2FirstModel(Models.JSON.Stockholm.ParkingMeters.RootObject root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new Models.Stockholm.ParkingMeter();
        }

        public Models.Stockholm.ParkingMeter JSON2LastModel(Models.JSON.Stockholm.ParkingMeters.RootObject root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new Models.Stockholm.ParkingMeter();
        }


        public IEnumerable<Models.Stockholm.ParkingMeter> JSON2Model(IEnumerable<Models.JSON.Stockholm.ParkingMeters.RootObject> root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new List<Models.Stockholm.ParkingMeter>();
        }

        public void Dispose()
        {
            // clean up if needed..
        }
    }
}
