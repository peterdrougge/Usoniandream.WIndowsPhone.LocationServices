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

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Stockholm.ServiceGuide
{
    public class ServiceGuide : IMapper<Models.Stockholm.ServiceGuide, Models.JSON.Stockholm.ServiceGuide.RootObject>
    {

        public IEnumerable<Models.Stockholm.ServiceGuide> JSON2Model(IEnumerable<Models.JSON.Stockholm.ServiceGuide.RootObject> root)
        {
            foreach (var item in root)
            {
                yield return new Models.Stockholm.ServiceGuide()
                {
                    Content = item.SingularName,
                    ID = item.Id
                };
            }
        }

        public Models.Stockholm.ServiceGuide JSON2FirstModel(Models.JSON.Stockholm.ServiceGuide.RootObject root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new Models.Stockholm.ServiceGuide();
        }

        public Models.Stockholm.ServiceGuide JSON2LastModel(Models.JSON.Stockholm.ServiceGuide.RootObject root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new Models.Stockholm.ServiceGuide();
        }

        public void Dispose()
        {
            //
        }

        public IEnumerable<Models.Stockholm.ServiceGuide> JSON2Model(Models.JSON.Stockholm.ServiceGuide.RootObject root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new List<Models.Stockholm.ServiceGuide>();
        }

    }
}
