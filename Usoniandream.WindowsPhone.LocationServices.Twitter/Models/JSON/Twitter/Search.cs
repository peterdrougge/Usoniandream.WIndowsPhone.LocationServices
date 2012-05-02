
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

namespace Usoniandream.WindowsPhone.LocationServices.Models.JSON.Twitter.Search
{
    public class Geo
    {
        public List<double> coordinates { get; set; }
        public string type { get; set; }
    }

    public class Metadata
    {
        public string result_type { get; set; }
    }

    public class Result
    {
        public string created_at { get; set; }
        public string from_user { get; set; }
        public int from_user_id { get; set; }
        public string from_user_id_str { get; set; }
        public string from_user_name { get; set; }
        public Geo geo { get; set; }
        public string location { get; set; }
        public object id { get; set; }
        public string id_str { get; set; }
        public string iso_language_code { get; set; }
        public Metadata metadata { get; set; }
        public string profile_image_url { get; set; }
        public string profile_image_url_https { get; set; }
        public string source { get; set; }
        public string text { get; set; }
        public string to_user { get; set; }
        public int? to_user_id { get; set; }
        public string to_user_id_str { get; set; }
        public string to_user_name { get; set; }
        public object in_reply_to_status_id { get; set; }
        public string in_reply_to_status_id_str { get; set; }
    }

    public class RootObject
    {
        public double completed_in { get; set; }
        public long max_id { get; set; }
        public string max_id_str { get; set; }
        public string next_page { get; set; }
        public int page { get; set; }
        public string query { get; set; }
        public string refresh_url { get; set; }
        public List<Result> results { get; set; }
        public int results_per_page { get; set; }
        public int since_id { get; set; }
        public string since_id_str { get; set; }
    }
}
