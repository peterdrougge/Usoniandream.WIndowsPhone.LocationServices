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

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Goteborg.TrafficCamera
{
    public class TrafficCameras : IMapper<Models.Goteborg.TrafficCamera.TrafficCamera, Models.JSON.Goteborg.TrafficCameras.RootObject>
    {
        public TrafficCameras(string apikey)
        {
            ApiKey = apikey;
        }
        public string ApiKey { get; set; }

        public System.Collections.Generic.IEnumerable<Models.Goteborg.TrafficCamera.TrafficCamera> JSON2Model(Models.JSON.Goteborg.TrafficCameras.RootObject root)
        {
            foreach (var item in root.features)
            {
                yield return new Models.Goteborg.TrafficCamera.TrafficCamera()
                {
                    CaptureIntervalSeconds = item.CaptureIntervalSeconds,
                    Content = item.Description,
                    ID = item.ID,
                    ImageURL = String.Format("http://data.goteborg.se/TrafficCamera/v0.1/CameraImage/{0}/{1}", ApiKey, item.ID),
                    Model = item.Model,
                    StorageDurationMinutes = item.StorageDurationMinutes
                };
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Goteborg.TrafficCamera.TrafficCamera> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Goteborg.TrafficCameras.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.TrafficCamera.TrafficCamera JSON2FirstModel(Models.JSON.Goteborg.TrafficCameras.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Goteborg.TrafficCamera.TrafficCamera JSON2LastModel(Models.JSON.Goteborg.TrafficCameras.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public Models.GenericPagedResultsContainer<Models.Goteborg.TrafficCamera.TrafficCamera> JSON2PagedContainer(Models.JSON.Goteborg.TrafficCameras.RootObject root)
        {
            throw new NotImplementedException();
        }
    }
}
