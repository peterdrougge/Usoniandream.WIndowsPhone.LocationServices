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

namespace Usoniandream.WindowsPhone.LocationServices.Models.Nokia.Places
{
    public class Place
    {

        public int Distance { get; set; }
        public string Title { get; set; }
        public double AverageRating { get; set; }
        public string Icon { get; set; }
        public string Vicinity { get; set; }
        public string Type { get; set; }
        public string URL { get; set; }
        public string Id { get; set; }
        public Category Category { get; set; }

    }
}
