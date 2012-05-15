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
using Usoniandream.WindowsPhone.LocationServices.Mappers;
namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias
{
    /// <summary>
    /// deep base interface for all SearchCriterias
    /// </summary>
    public interface ISearchCriteriaFoundation
    {
        /// <summary>
        /// Gets the client.
        /// </summary>
        RestSharp.RestClient Client { get; }
        /// <summary>
        /// Gets the request.
        /// </summary>
        RestSharp.RestRequest Request { get; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ISearchCriteria&lt;Ttarget, Tsource&gt;"/> is debug.
        /// </summary>
        /// <value>
        ///   <c>true</c> if debug; otherwise, <c>false</c>.
        /// </value>
        bool DebugMode { get; set; }

        string Identifier { get; }
    }
}
