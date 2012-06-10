
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
using System.Device.Location;

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Twitter
{
    public abstract class TwitterSearchCriteriaBase<Ttarget, Tsource> : SearchCriteriaBase<Ttarget, Tsource> where Tsource : new()
    {
        public TwitterSearchCriteriaBase(SearchCriteriaResultType type)
            : base("TWITTER_DATA_SERVICE_URI", type)
        {
            SetDefaultCriteriaSettings();
        }

        private void SetDefaultCriteriaSettings()
        {
            base.SkipAPIKeyCheck = true;
            Request.Resource = "search.json";
            Request.AddParameter("with_twitter_user_id", "true");
            Request.AddParameter("rpp", 100);
        }
        public TwitterSearchCriteriaBase(string query, SearchCriteriaResultType type)
            : base("TWITTER_DATA_SERVICE_URI", type)
        {
            SetDefaultCriteriaSettings();
        }
        public TwitterSearchCriteriaBase(DateTime since, SearchCriteriaResultType type)
            : base("TWITTER_DATA_SERVICE_URI", type)
        {
            SetDefaultCriteriaSettings();
            Query = string.Format("since {0}", since.ToString("yyyy-mm-dd"));
            Request.AddParameter("q", Query);
        }
        public TwitterSearchCriteriaBase(string query, DateTime since, SearchCriteriaResultType type)
            : base("TWITTER_DATA_SERVICE_URI", type)
        {
            SetDefaultCriteriaSettings();
            Query = string.Format("{0} since {1}", query, since.ToString("yyyy-mm-dd"));
            Request.AddParameter("q", Query);
        }
        public string Query { get; set; }
    }
}
