
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

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Google
{
    public class EventDetails : GoogleSearchCriteriaBase<Models.Google.EventDetails, Models.JSON.Google.EventDetails.RootObject>
    {
        public EventDetails(string reference, string eventId)
            : base("event/details", SearchCriteriaResultType.Single)
        {
            Mapper = new Mappers.Google.EventDetails();
            Reference = reference;
            EventId = eventId;
            Request.AddParameter("reference", reference);
            Request.AddParameter("event_id", eventId);
        }
        public EventDetails(string reference, string eventId, string language)
            : base("event/details", language, SearchCriteriaResultType.Single)
        {
            Mapper = new Mappers.Google.EventDetails();
            Reference = reference;
            EventId = eventId;
            Request.AddParameter("reference", reference);
            Request.AddParameter("event_id", eventId);
        }
        
        public  string Reference { get; set; }

        public string EventId { get; set; }
    }
}
