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

namespace Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ParkingMeters
{
    public class Geometry
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }

    public class Properties
    {
        public int OBJECT_ID { get; set; }
        public int VERSION_ID { get; set; }
        public string FEATURE_TYPE_NAME { get; set; }
        public int FEATURE_TYPE_OBJECT_ID { get; set; }
        public int FEATURE_TYPE_VERSION_ID { get; set; }
        public string MAIN_ATTRIBUTE_NAME { get; set; }
        public string MAIN_ATTRIBUTE_VALUE { get; set; }
        public string MAIN_ATTRIBUTE_DESCRIPTION { get; set; }
        public string NAME1 { get; set; }
        public string DESC1 { get; set; }
        public string NAME2 { get; set; }
        public string DESC2 { get; set; }
        public string NAME3 { get; set; }
        public string DESC3 { get; set; }
        public string NAME4 { get; set; }
        public string DESC4 { get; set; }
        public string NAME5 { get; set; }
        public string DESC5 { get; set; }
        public string NAME6 { get; set; }
        public string DESC6 { get; set; }
        public string NAME7 { get; set; }
        public string DESC7 { get; set; }
        public string NAME8 { get; set; }
        public string DESC8 { get; set; }
        public string NAME9 { get; set; }
        public object DESC9 { get; set; }
        public DateTime? VALID_FROM { get; set; }
        public DateTime? VALID_TO { get; set; }
        public string CID { get; set; }
        public int EXTENT_NO { get; set; }
        public int EXTENT_TYPE { get; set; }
        public int LATERAL_POSITION { get; set; }
        public double LATERAL_DIST { get; set; }
        public double POSITION { get; set; }
        public int NET_ELEMENT_OBJECT_ID { get; set; }
    }

    public class Feature
    {
        public string type { get; set; }
        public string id { get; set; }
        public Geometry geometry { get; set; }
        public string geometry_name { get; set; }
        public Properties properties { get; set; }
    }

    public class Properties2
    {
        public string code { get; set; }
    }

    public class Crs
    {
        public string type { get; set; }
        public Properties2 properties { get; set; }
    }

    public class RootObject
    {
        public string type { get; set; }
        public List<Feature> features { get; set; }
        public Crs crs { get; set; }
        public List<double> bbox { get; set; }
    }
}
