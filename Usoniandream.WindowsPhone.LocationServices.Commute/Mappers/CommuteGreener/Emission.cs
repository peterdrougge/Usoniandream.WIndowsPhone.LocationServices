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

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.CommuteGreener
{
    public class Emission : IMapper<Models.CommuteGreener.Emission, Models.JSON.CommuteGreener.Emissions.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.CommuteGreener.Emission> JSON2Model(Models.JSON.CommuteGreener.Emissions.RootObject root)
        {
            foreach (var item in root.emissions)
            {
                yield return new Models.CommuteGreener.Emission()
                {
                    Content = item.transportName,
                    RoutedDistance = item.routedDistance,
                    TotalCo2 = item.totalCo2,
                    TransportCategory = item.transportCategory
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.CommuteGreener.Emission> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.CommuteGreener.Emissions.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.CommuteGreener.Emission JSON2FirstModel(Models.JSON.CommuteGreener.Emissions.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.CommuteGreener.Emission JSON2LastModel(Models.JSON.CommuteGreener.Emissions.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public Models.GenericPagedResultsContainer<Models.CommuteGreener.Emission> JSON2PagedContainer(Models.JSON.CommuteGreener.Emissions.RootObject root)
        {
            throw new NotImplementedException();
        }
    }
}
