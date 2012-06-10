
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
using Usoniandream.WindowsPhone.LocationServices.SearchCriterias;

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Eniro
{
    public class CompanySearch : SearchCriteriaBase<Models.Eniro.Company, Models.JSON.Eniro.CompanySearch.RootObject>
    {
        public CompanySearch(string query, string country)
            : base("ENIRO_SERVICE_URI_COMPANYSEARCH", SearchCriteriaResultType.Collection)
        {
            APIKeyResourceName = "ENIRO_API_KEY";
            Mapper = new Mappers.Eniro.CompanySearch();

            Request.Resource = "search/basic";

            Request.AddParameter("key", APIkey);
            Request.AddParameter("profile", Profile);
            Request.AddParameter("country", country);
            Request.AddParameter("version", "1.1.3");
            Request.AddParameter("search_word", UTF8Encode(query));

        }
        public int From { set { base.SetRequestParameter("from_list", value); } }
        public int To { set { base.SetRequestParameter("to_list", value); } }
        public bool AutoFillToMaxLimit { get; set; }
        private string UTF8Encode(string text)
        {
            byte[] utf8Bytes = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Text.Encoding.UTF8.GetString(utf8Bytes,0,utf8Bytes.Length);
        }

        public string Profile
        {
            get
            {
                string key = ((Models.ServiceAPIKey)Application.Current.Resources["ENIRO_API_PROFILE"]).Value;
                if (string.IsNullOrWhiteSpace(key))
                {
                    throw new ArgumentException("missing api profile, please check App.xaml.", "ENIRO_API_PROFILE");
                }
                return key;
            }
        }
    }
}
