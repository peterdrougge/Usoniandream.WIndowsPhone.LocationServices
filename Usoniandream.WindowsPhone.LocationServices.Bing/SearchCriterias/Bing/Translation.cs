
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
using System.Text;
using Usoniandream.WindowsPhone.LocationServices.Models;

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Bing
{
    public class Translation : SearchCriterias.SearchCriteriaBase<Models.Bing.Translation, Models.JSON.Bing.Translation.RootObject>
    {
        public Translation(string sourceLanguage, string targetLanguage, string market, params string[] translate)
            : base("BING_SERVICE_URI_LOCATION")
        {
            Mapper = new Mappers.Bing.Translation();

            APIKeyResourceName = "BING_API_KEY";

            Request.Resource = "json.aspx";

            Request.AddParameter("Sources", "Translation");
            Request.AddParameter("Version", "2.2");
            Request.AddParameter("Market", market);
            Request.AddParameter("Translation.SourceLanguage", sourceLanguage);
            Request.AddParameter("Translation.TargetLanguage", targetLanguage);
            Request.AddParameter("AppId", APIkey);

            StringBuilder sb = new StringBuilder();
            foreach (var item in translate)
            {
                sb.Append(item + " | ");
            }
            Request.AddParameter("Query", sb.ToString().Substring(0, sb.ToString().Length-3));
        }
        public Translation(string sourceLanguage, string targetLanguage, string market, IModel foundation)
            : base("BING_SERVICE_URI_LOCATION")
        {
            Mapper = new Mappers.Bing.Translation();

            APIKeyResourceName = "BING_API_KEY";

            Request.Resource = "json.aspx";

            Request.AddParameter("Sources", "Translation");
            Request.AddParameter("Version", "2.2");
            Request.AddParameter("Market", market);
            Request.AddParameter("Translation.SourceLanguage", sourceLanguage);
            Request.AddParameter("Translation.TargetLanguage", targetLanguage);
            Request.AddParameter("AppId", APIkey);

            Request.AddParameter("Query", foundation.Content);
        }
    }
}
