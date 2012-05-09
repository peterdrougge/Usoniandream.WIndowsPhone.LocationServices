
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
using RestSharp;

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias
{
    public abstract class SearchCriteriaWithPaddingBase<Ttarget, Tsource> : SearchCriteriaBase<Ttarget, Tsource>
    {
        private void AddPaddingToResponse(IRestResponse response)
        {
            response.Content = string.Format("{0}{1}{2}", this.StartPadding, response.Content, this.EndPadding);
        }

        public SearchCriteriaWithPaddingBase(string startpadding, string endpadding)
            : base()
        {
            Request.OnBeforeDeserialization = AddPaddingToResponse;
            StartPadding = startpadding;
            EndPadding = endpadding;
        }
        public SearchCriteriaWithPaddingBase(Method method, string startpadding, string endpadding)
            : base(method)
        {
            Request.OnBeforeDeserialization = AddPaddingToResponse;
            StartPadding = startpadding;
            EndPadding = endpadding;
        }
        public SearchCriteriaWithPaddingBase(string baseurlresourcename, string startpadding, string endpadding)
            : base(baseurlresourcename)
        {
            Request.OnBeforeDeserialization = AddPaddingToResponse;
            StartPadding = startpadding;
            EndPadding = endpadding;
        }
        public SearchCriteriaWithPaddingBase(Method method, string baseurlresourcename, string startpadding, string endpadding)
            : base(method, baseurlresourcename)
        {
            Request.OnBeforeDeserialization = AddPaddingToResponse;
            StartPadding = startpadding;
            EndPadding = endpadding;
        }

        public string StartPadding { get; set; }
        public string EndPadding { get; set; }
    }
}
