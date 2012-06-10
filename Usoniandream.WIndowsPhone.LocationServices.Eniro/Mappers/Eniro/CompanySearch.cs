
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
using Usoniandream.WindowsPhone.LocationServices.Mappers;
using System.Device.Location;
using System.Linq;
using System.Collections.Generic;

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Eniro
{
    public class CompanySearch : IMapper<Models.Eniro.Company, Models.JSON.Eniro.CompanySearch.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Eniro.Company> JSON2Model(Models.JSON.Eniro.CompanySearch.RootObject root)
        {
            if (root==null)
            {
                yield return null;
            }

            foreach (var item in root.adverts)
            {
                yield return new Models.Eniro.Company()
                {
                    Content = item.companyInfo.companyName,
                    Location = GetLocation(item),
                    Website = item.homepage,
                    Address = item.address.streetName,
                    PostCode = item.address.postCode,
                    PostArea = item.address.postArea,
                    PostBox = item.address.postBox,
                    InfoLink = item.infoPageLink,
                    PhoneNumber = GetPhoneNumber(item),
                    Description = item.companyInfo.companyText,
                    OrgNr = item.companyInfo.orgNumber
                };
            }
        }

        private static string GetPhoneNumber(Models.JSON.Eniro.CompanySearch.Advert item)
        {
            if (item.phoneNumbers.FirstOrDefault()==null)
            {
                return string.Empty;
            }
            return item.phoneNumbers.FirstOrDefault().phoneNumber;
        }

        private static GeoCoordinate GetLocation(Models.JSON.Eniro.CompanySearch.Advert item)
        {
            if (item.location==null)
            {
                return null;
            }
            if (item.location.coordinates==null)
            {
                return null;
            }
            var location = item.location.coordinates.Where(x => x.latitude.HasValue && x.longitude.HasValue).FirstOrDefault();
            if (location == null)
            {
                return null;
            }
            return new GeoCoordinate(location.latitude.GetValueOrDefault(), location.longitude.GetValueOrDefault());
        }

        public System.Collections.Generic.IEnumerable<Models.Eniro.Company> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Eniro.CompanySearch.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Eniro.Company JSON2FirstModel(Models.JSON.Eniro.CompanySearch.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.Eniro.Company JSON2LastModel(Models.JSON.Eniro.CompanySearch.RootObject root)
        {
            throw new NotImplementedException();
        }

        public Models.GenericPagedResultsContainer<Models.Eniro.Company> JSON2PagedContainer(Models.JSON.Eniro.CompanySearch.RootObject root)
        {
            if (root == null)
            {
                return null;
            }

            Models.GenericPagedResultsContainer<Models.Eniro.Company> container = new Models.GenericPagedResultsContainer<Models.Eniro.Company>();
            container.MaxHits = root.totalHits;
            container.PageSize = root.itemsPerPage;
            container.StartIndex = root.startIndex;
            container.Items = JSON2Model(root);
            return container;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
