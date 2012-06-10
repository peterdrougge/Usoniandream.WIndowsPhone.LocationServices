//
// Copyright (c) 2012 Peter Drougge
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

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
                if (!item.SingularName.ToLower().StartsWith("använd ej denna kategori"))
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



        public Models.GenericPagedResultsContainer<Models.Stockholm.Place.ServiceUnitType> JSON2PagedContainer(Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject root)
        {
            throw new NotImplementedException();
        }
    }
}
