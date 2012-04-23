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

namespace Usoniandream.WindowsPhone.LocationServices.Models.JSON.Goteborg.CleaningZones
{
    public class Feature
    {
        public string Id { get; set; }
        public string StreetName { get; set; }
        public string ActivePeriodText { get; set; }
        public DateTime CurrentPeriodStart { get; set; }
        public DateTime CurrentPeriodEnd { get; set; }
        public int WeekDay { get; set; }
        public int StartMonth { get; set; }
        public int StartDay { get; set; }
        public int StartHour { get; set; }
        public int EndMonth { get; set; }
        public int EndDay { get; set; }
        public int EndHour { get; set; }
        public int Distance { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public bool? OnlyEvenWeeks { get; set; }
    }

    public class RootObject
    {
        public List<Feature> features { get; set; }
    }
}
