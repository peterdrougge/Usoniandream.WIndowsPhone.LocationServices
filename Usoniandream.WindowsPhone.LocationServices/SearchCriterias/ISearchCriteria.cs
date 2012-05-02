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
    /// base interface for all SearchCriterias
    /// </summary>
    /// <typeparam name="Ttarget">The type of the target.</typeparam>
    /// <typeparam name="Tsource">The type of the source.</typeparam>
    public interface ISearchCriteria<Ttarget, Tsource>
    {
        /// <summary>
        /// Gets the API key.
        /// </summary>
        string APIkey { get; }
        /// <summary>
        /// Gets the client.
        /// </summary>
        RestSharp.RestClient Client { get; }
        /// <summary>
        /// Gets the request.
        /// </summary>
        RestSharp.RestRequest Request { get; }
        /// <summary>
        /// Gets or sets the mapper.
        /// </summary>
        /// <value>
        /// The mapper.
        /// </value>
        IMapper<Ttarget, Tsource> Mapper { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [skip API key check].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [skip API key check]; otherwise, <c>false</c>.
        /// </value>
        bool SkipAPIKeyCheck { get; set; }
    }
}
