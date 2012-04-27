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

namespace Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.DetailedServiceUnit
{
    public class ServiceUnitTypeInfo
    {
        public string Id { get; set; }
        public string SingularName { get; set; }
    }

    public class Attribute
    {
        public string Description { get; set; }
        public string Group { get; set; }
        public string GroupDescription { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public ServiceUnitTypeInfo ServiceUnitTypeInfo { get; set; }
    }

    public class GeographicalArea
    {
        public string FriendlyId { get; set; }
        public int Id { get; set; }
        public bool IsCityArea { get; set; }
        public string Name { get; set; }
    }

    public class GeographicalPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class ServiceUnitTypeGroupInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ServiceUnitType
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
        public List<Attribute> Attributes { get; set; }
        public List<GeographicalArea> GeographicalAreas { get; set; }
        public GeographicalPosition GeographicalPosition { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public List<object> RelatedServiceUnits { get; set; }
        public List<ServiceUnitType> ServiceUnitTypes { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeUpdated { get; set; }
    }
}
