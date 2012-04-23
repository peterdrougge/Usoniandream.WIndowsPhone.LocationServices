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

namespace Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes
{
    public class ServiceUnitTypeGroupInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Feature
    {
        public string DefinitiveName { get; set; }
        public string Id { get; set; }
        public string PluralName { get; set; }
        public ServiceUnitTypeGroupInfo ServiceUnitTypeGroupInfo { get; set; }
        public string SingularName { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeUpdated { get; set; }
    }

    public class RootObject
    {
        public List<Feature> features { get; set; }
    }
}
