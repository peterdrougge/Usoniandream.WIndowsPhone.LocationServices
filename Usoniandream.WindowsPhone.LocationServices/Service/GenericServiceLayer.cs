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
using Usoniandream.WindowsPhone.LocationServices.Models;
using RestSharp;

namespace Usoniandream.WindowsPhone.LocationServices.Service
{
    /// <summary>
    /// base for all traditional service layers
    /// </summary>
    public abstract class GenericServiceLayer : IService
    {
        /// <summary>
        /// Executes the request for callback.
        /// </summary>
        /// <typeparam name="Ttarget">The type of the target.</typeparam>
        /// <typeparam name="Tsource">The type of the source.</typeparam>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void ExecuteRequestForCallback<Ttarget, Tsource>(SearchCriterias.ISearchCriteria<Ttarget, Tsource> criteria, Action<RestResponse<Tsource>> callback) where Tsource : new()
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey) && !criteria.SkipAPIKeyCheck)
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            criteria.Client.ExecuteAsync<Tsource>(criteria.Request, callback);
        }

    }
}
