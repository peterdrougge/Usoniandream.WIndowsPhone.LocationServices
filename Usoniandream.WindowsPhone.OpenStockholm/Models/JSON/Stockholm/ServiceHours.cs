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

namespace Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ServiceHours
{
public class Geometry
{
    public string type { get; set; }
    public List<List<double>> coordinates { get; set; }
}

public class Properties
{
    public int FEATURE_OBJECT_ID { get; set; }
    public int FEATURE_VERSION_ID { get; set; }
    public int EXTENT_NO { get; set; }
    public string VALID_FROM { get; set; }
    public int START_TIME { get; set; }
    public int END_TIME { get; set; }
    public string START_WEEKDAY { get; set; }
    public string CITATION { get; set; }
    public string STREET_NAME { get; set; }
    public string CITY_DISTRICT { get; set; }
    public string PARKING_DISTRICT { get; set; }
    public int VF_METER { get; set; }
    public string VF_PLATS_TYP { get; set; }
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
