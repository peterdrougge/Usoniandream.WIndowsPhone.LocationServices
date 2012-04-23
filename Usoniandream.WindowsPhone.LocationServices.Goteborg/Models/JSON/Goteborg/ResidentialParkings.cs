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
using System.Collections.Generic;

namespace Usoniandream.WindowsPhone.LocationServices.Models.JSON.Goteborg.ResidentialParkings
{
    public class Feature
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public int ParkingSpaces { get; set; }
        public string ResidentialParkingArea { get; set; }
        public int Distance { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public string ExtraInfo { get; set; }
    }

    public class RootObject
    {
        public List<Feature> features { get; set; }
    }
}
