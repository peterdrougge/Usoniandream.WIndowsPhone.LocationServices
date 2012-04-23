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

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.ServiceGuide
{
    public class DetailedServiceUnit : ServiceGuideBase<Models.Stockholm.ServiceGuide.DetailedServiceUnit, Models.JSON.Stockholm.DetailedServiceUnit.RootObject>
    {
        public DetailedServiceUnit(string id)
            : base()
        {
            Mapper = new Mappers.Stockholm.ServiceGuide.DetailedServiceUnit();

            ID = id;

            Request.Resource += "/DetailedServiceUnits/" + ID + "/json/";
        }

        public string ID { get; set; }
    }
}
