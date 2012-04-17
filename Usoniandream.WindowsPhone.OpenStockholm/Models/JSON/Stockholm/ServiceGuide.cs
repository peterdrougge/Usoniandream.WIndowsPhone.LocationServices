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

namespace Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ServiceGuide
{
    public class ServiceUnitTypeGroupInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class RootObject
    {
        public string DefinitiveName { get; set; }
        public string Id { get; set; }
        public string PluralName { get; set; }
        public ServiceUnitTypeGroupInfo ServiceUnitTypeGroupInfo { get; set; }
        public string SingularName { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeUpdated { get; set; }
    }

    public class GeographicalPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class ServiceUnitRoot : System.Collections.Generic.List<ServiceUnit>
    {

    }
    public class ServiceUnit
    {
        public GeographicalPosition GeographicalPosition { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeUpdated { get; set; }
    }
}
