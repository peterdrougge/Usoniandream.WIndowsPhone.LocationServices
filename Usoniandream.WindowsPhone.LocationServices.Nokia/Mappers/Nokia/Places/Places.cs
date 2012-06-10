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
using System.Diagnostics;
using System.Collections.Generic;

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Nokia.Places
{
    public class Places : IMapper<Models.Nokia.Places.Place, Models.JSON.Nokia.Places.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Nokia.Places.Place> JSON2Model(Models.JSON.Nokia.Places.RootObject root)
        {
            if (root==null)
            {
                throw new MissingMemberException("json root object is missing");
            }
            if (root.results == null)
            {
                throw new MissingMemberException("json root result collection is missing");
            }
            foreach (var item in root.results.items)
            {
                if (item.position!=null && item.position.Count==2)  
                {
                    yield return new Models.Nokia.Places.Place()
                    {
                        Content = item.title,
                        AverageRating = item.averageRating,
                        Category = GetCategoryInformation(item),
                        Location = new System.Device.Location.GeoCoordinate(item.position[0], item.position[1]),
                        Distance = item.distance,
                        Icon = item.icon,
                        Id = item.id,
                        Title = item.title,
                        Type = item.type,
                        URL = item.href,
                        Vicinity = item.vicinity,
                        Sponsored = item.sponsored
                    };
                }
            }
        }

        private Models.Nokia.Places.Category GetCategoryInformation(Models.JSON.Nokia.Places.Item item)
        {
            if (item.category!=null)
            {
                return new Models.Nokia.Places.Category()
                                    {
                                        Id = item.category.id,
                                        Title = item.category.title,
                                        Type = item.category.type,
                                        URL = item.category.href,
                                    };
            }
            else
            {
                return new Models.Nokia.Places.Category();
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Nokia.Places.Place> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Nokia.Places.RootObject> root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new List<Models.Nokia.Places.Place>();
        }

        public Models.Nokia.Places.Place JSON2FirstModel(Models.JSON.Nokia.Places.RootObject root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new Models.Nokia.Places.Place();
        }

        public Models.Nokia.Places.Place JSON2LastModel(Models.JSON.Nokia.Places.RootObject root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new Models.Nokia.Places.Place();
        }

        public void Dispose()
        {
            //
        }


        public Models.GenericPagedResultsContainer<Models.Nokia.Places.Place> JSON2PagedContainer(Models.JSON.Nokia.Places.RootObject root)
        {
            throw new NotImplementedException();
        }
    }
}
