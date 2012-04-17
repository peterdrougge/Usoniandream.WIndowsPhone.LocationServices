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

namespace Usoniandream.WindowsPhone.LocationServices.Models.JSON.Nokia.Places
{
    public class Location
    {
        public List<double> position { get; set; }
    }

    public class Search
    {
        public Location location { get; set; }
    }

    public class Category
    {
        public string id { get; set; }
        public string title { get; set; }
        public string href { get; set; }
        public string type { get; set; }
    }

    public class Item
    {
        public List<double> position { get; set; }
        public int distance { get; set; }
        public string title { get; set; }
        public double averageRating { get; set; }
        public Category category { get; set; }
        public string icon { get; set; }
        public string vicinity { get; set; }
        public List<object> having { get; set; }
        public string type { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public string places { get; set; }
        public double? weight { get; set; }
    }

    public class Results
    {
        public List<Item> items { get; set; }
    }

    public class RootObject
    {
        public Search search { get; set; }
        public Results results { get; set; }
    }
}
