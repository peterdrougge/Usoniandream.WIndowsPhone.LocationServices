﻿//
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
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Bing
{
    public class BingLocation : IMapper<Models.Bing.BingMapLocation, Usoniandream.WindowsPhone.LocationServices.Models.JSON.Bing.BingLocation.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Bing.BingMapLocation> JSON2Model(Models.JSON.Bing.BingLocation.RootObject root)
        {
            foreach (var sets in root.resourceSets)
            {
                foreach (var item in sets.resources)
                {
                    yield return new Models.Bing.BingMapLocation()
                    {
                        Address = item.address.addressLine
                    };
                }
            }
        }

        public Models.Bing.BingMapLocation JSON2FirstModel(Models.JSON.Bing.BingLocation.RootObject root)
        {
            return new Models.Bing.BingMapLocation()
            {
                Address = root.resourceSets.First().resources.First().address.addressLine,
                FormattedAddress = root.resourceSets.First().resources.First().address.formattedAddress,
                District = root.resourceSets.First().resources.First().address.adminDistrict
            };
        }

        public Models.Bing.BingMapLocation JSON2LastModel(Models.JSON.Bing.BingLocation.RootObject root)
        {
            return new Models.Bing.BingMapLocation()
            {
                Address = root.resourceSets.First().resources.Last().address.addressLine,
                FormattedAddress = root.resourceSets.First().resources.Last().address.formattedAddress,
                District = root.resourceSets.First().resources.Last().address.adminDistrict
            };
        }


        public System.Collections.Generic.IEnumerable<Models.Bing.BingMapLocation> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Bing.BingLocation.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            // clean up..
        }



        public Models.GenericPagedResultsContainer<Models.Bing.BingMapLocation> JSON2PagedContainer(Models.JSON.Bing.BingLocation.RootObject root)
        {
            throw new NotImplementedException();
        }
    }
}
