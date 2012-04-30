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
using Usoniandream.WindowsPhone.Extensions;
using RestSharp;
using System.Reactive.Linq;
using Newtonsoft.Json;

namespace Usoniandream.WindowsPhone.LocationServices.Service.Reactive
{
    public abstract class GenericServiceLayer : IService
    {
        public IObservable<Ttarget> ExecuteRequestReturnFirstObservable<Ttarget, Tsource>(SearchCriterias.ISearchCriteria<Ttarget, Tsource> criteria) where Tsource : new()
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            return criteria.Client.ExecuteAsync<Tsource>(criteria.Request)
                            .Select<Tsource, Ttarget>(x => criteria.Mapper.JSON2FirstModel(x));
        }

        public IObservable<Ttarget> ExecuteRequestReturnObservable<Ttarget, Tsource>(SearchCriterias.ISearchCriteria<Ttarget, Tsource> criteria) where Tsource : new()
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            return criteria.Client.ExecuteAsync<Tsource>(criteria.Request)
                            .SelectMany<Tsource, Ttarget>(x => criteria.Mapper.JSON2Model(x));
        }

        public IObservable<Ttarget> ExecuteRequestWithPaddingReturnFirstObservable<Ttarget, Tsource>(SearchCriterias.ISearchCriteria<Ttarget, Tsource> criteria) where Tsource : new()
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            return criteria.Client.ExecuteAsync(criteria.Request)
                            .Select(x => JsonConvert.DeserializeObject<Tsource>("{\"features\":" + x + "}"))
                            .Select<Tsource, Ttarget>(x => criteria.Mapper.JSON2FirstModel(x));
        }
        public IObservable<Ttarget> ExecuteRequestWithPaddingReturnObservable<Ttarget, Tsource>(SearchCriterias.ISearchCriteria<Ttarget, Tsource> criteria) where Tsource : new()
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            return criteria.Client.ExecuteAsync(criteria.Request)
                            .Select(x => JsonConvert.DeserializeObject<Tsource>("{\"features\":" + x + "}"))
                            .SelectMany<Tsource, Ttarget>(x => criteria.Mapper.JSON2Model(x));
        }


    }
}
