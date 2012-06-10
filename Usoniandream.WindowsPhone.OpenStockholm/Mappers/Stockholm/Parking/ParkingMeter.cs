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
using System.Diagnostics;

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Stockholm.Parking
{
    public class ParkingMeter : IMapper<Models.Stockholm.ParkingMeter, Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ParkingMeters.RootObject>
    {
        public IEnumerable<Models.Stockholm.ParkingMeter> JSON2Model(Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ParkingMeters.RootObject root)
        {
            foreach (var item in root.features)
            {
                yield return new Models.Stockholm.ParkingMeter(item);
            }
        }

        public Models.Stockholm.ParkingMeter JSON2FirstModel(Models.JSON.Stockholm.ParkingMeters.RootObject root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new Models.Stockholm.ParkingMeter();
        }

        public Models.Stockholm.ParkingMeter JSON2LastModel(Models.JSON.Stockholm.ParkingMeters.RootObject root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new Models.Stockholm.ParkingMeter();
        }


        public IEnumerable<Models.Stockholm.ParkingMeter> JSON2Model(IEnumerable<Models.JSON.Stockholm.ParkingMeters.RootObject> root)
        {
            Debug.WriteLine("Hit mapper function not implemented yet");
            return new List<Models.Stockholm.ParkingMeter>();
        }

        public void Dispose()
        {
            // clean up if needed..
        }


        public Models.GenericPagedResultsContainer<Models.Stockholm.ParkingMeter> JSON2PagedContainer(Models.JSON.Stockholm.ParkingMeters.RootObject root)
        {
            throw new NotImplementedException();
        }
    }
}
