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
using System.Linq;
using Usoniandream.WindowsPhone.GeoConverter.Positions;


namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Stockholm.ServiceGuide
{
    public class DetailedServiceUnit : IMapper<Models.Stockholm.ServiceGuide.DetailedServiceUnit, Models.JSON.Stockholm.DetailedServiceUnit.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Stockholm.ServiceGuide.DetailedServiceUnit> JSON2Model(Models.JSON.Stockholm.DetailedServiceUnit.RootObject root)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Models.Stockholm.ServiceGuide.DetailedServiceUnit> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Stockholm.DetailedServiceUnit.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Stockholm.ServiceGuide.DetailedServiceUnit JSON2FirstModel(Models.JSON.Stockholm.DetailedServiceUnit.RootObject root)
        {
            RT90 rt90pos = new RT90(root.GeographicalPosition.X, root.GeographicalPosition.Y, RT90.RT90Projection.rt90_2_5_gon_v);
            WGS84 pos = rt90pos.ToWGS84();
            return new Models.Stockholm.ServiceGuide.DetailedServiceUnit()
            {
                Content = root.Name,
                ID = root.Id,
                Group = root.ServiceUnitTypes.FirstOrDefault().SingularName,
                Location = new System.Device.Location.GeoCoordinate(pos.Latitude, pos.Longitude),
                StreetAddress = GetAttributeByID(root, "StreetAddress"),
                PhoneNumber = GetAttributeByID(root, "PhoneNumber"),
                Contact = GetAttributeByID(root, "ContactPersonName"),
                ContactPhone = GetAttributeByID(root, "ContactPersonPhone"),
                ContactEmail = GetAttributeByID(root, "ContactPersonEmail"),
                ShortDescription = GetAttributeByID(root, "ShortDescription"),
                Description = GetAttributeByID(root, "Description"),
                GeographicalArea = GetGeographicalArea(root),
                ImageId = GetAttributeByID(root, "Image")
            };
        }

        private string GetGeographicalArea(Models.JSON.Stockholm.DetailedServiceUnit.RootObject root)
        {
            if (root.GeographicalAreas.FirstOrDefault()!=null)
            {
                return root.GeographicalAreas.FirstOrDefault().Name;
            }

            return string.Empty;
        }

        private string GetAttributeByID(Models.JSON.Stockholm.DetailedServiceUnit.RootObject root, string id)
        {
            if (root.Attributes.SingleOrDefault(x => x.Id.Equals(id))!=null)
            {
                if (root.Attributes.SingleOrDefault(x => x.Id.Equals(id)).Value != null)
                    return root.Attributes.SingleOrDefault(x => x.Id.Equals(id)).Value as string;
            }
            return string.Empty;
        }

        public Models.Stockholm.ServiceGuide.DetailedServiceUnit JSON2LastModel(Models.JSON.Stockholm.DetailedServiceUnit.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
