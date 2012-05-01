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

namespace Usoniandream.WindowsPhone.LocationServices.Models.JSON.Orebro.OrebroJSONModel
{
    public class Properties
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string link { get; set; }
    }

    public class Geometry2
    {
        public List<int> coordinates { get; set; }
        public string type { get; set; }
    }

    public class Geometry
    {
        public List<Geometry2> geometries { get; set; }
        public string type { get; set; }
    }

    public class Feature
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public Geometry geometry { get; set; }
    }

    public class RootObject
    {
        public List<Feature> features { get; set; }
        public string type { get; set; }
    }
}
