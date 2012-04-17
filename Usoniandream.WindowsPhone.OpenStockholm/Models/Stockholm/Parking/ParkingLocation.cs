using System;
using System.IO;
using System.Runtime;
using System.Runtime.Serialization;
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
using System.Device.Location;

namespace Usoniandream.WindowsPhone.LocationServices.Models.Stockholm
{
    public class ParkingLocation : ILocation
    {
        public virtual GeoCoordinate Location { get; set; }
        public virtual object Content { get; set; }

        public List<List<double>> Coordinates { get; set; }

        public string CityDistrict { get; set; }
        public int ParkingTimeTotalMinutes 
        {
            get
            {
                int total = (MaxDays.GetValueOrDefault(0) * 24 * 60) +
                    (MaxHours.GetValueOrDefault(0) * 60) +
                    MaxMinutes.GetValueOrDefault(0);
                if (total > 0)
	            {
                    return total;
	            }
                else
            	{
                    return int.MaxValue;
	            }
            }
        }
        public int? MaxDays { get; set; }
        public int? MaxHours { get; set; }
        public int? MaxMinutes { get; set; }

        public string OtherInfo { get; set; }
    }
}


