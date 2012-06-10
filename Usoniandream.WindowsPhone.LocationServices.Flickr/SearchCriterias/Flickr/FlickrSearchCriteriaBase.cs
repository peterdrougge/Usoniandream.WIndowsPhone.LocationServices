
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

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Flickr
{
    public abstract class FlickrSearchCriteriaBase<Ttarget, Tsource> : SearchCriteriaBase<Ttarget, Tsource> where Tsource : new()
    {
        public FlickrSearchCriteriaBase(string method, SearchCriteriaResultType type)
            : base("FLICKR_DATA_SERVICE_URI", type)
        {
            base.APIKeyResourceName = "FLICKR_DATA_API_KEY";
            
            Method = method;

            Request.Resource = "services/rest/";
            Request.AddParameter("method", Method);
            Request.AddParameter("nojsoncallback", 1);
            Request.AddParameter("format", "json");
            Request.AddParameter("api_key", APIkey);
 
        }
        public string Method { get; set; }
    }
}
