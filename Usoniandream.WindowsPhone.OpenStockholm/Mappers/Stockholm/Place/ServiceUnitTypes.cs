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
using Usoniandream.WindowsPhone.LocationServices.Mappers;
using System.Reactive.Linq;
using System.Diagnostics;

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Stockholm.Place
{
    public class ServiceUnitTypes : IMapper<Models.Stockholm.Place.ServiceUnitType, Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject>
    {

        public IEnumerable<Models.Stockholm.Place.ServiceUnitType> JSON2Model(IEnumerable<Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject> root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new List<Models.Stockholm.Place.ServiceUnitType>();
        }

        public Models.Stockholm.Place.ServiceUnitType JSON2FirstModel(Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new Models.Stockholm.Place.ServiceUnitType();
        }

        public Models.Stockholm.Place.ServiceUnitType JSON2LastModel(Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new Models.Stockholm.Place.ServiceUnitType();
        }

        public void Dispose()
        {
            //
        }

        public IEnumerable<Models.Stockholm.Place.ServiceUnitType> JSON2Model(Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject root)
        {
            foreach (var item in root.features)
            {
                yield return new Models.Stockholm.Place.ServiceUnitType()
                {
                    Content = item.SingularName,
                    ID = item.Id,
                    GroupName = item.ServiceUnitTypeGroupInfo.Name
                };
            }
        }

    }
}
