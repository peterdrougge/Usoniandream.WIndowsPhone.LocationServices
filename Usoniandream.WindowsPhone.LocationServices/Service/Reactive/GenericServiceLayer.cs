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
using Usoniandream.WindowsPhone.LocationServices.Extensions;
using RestSharp;
using System.Reactive.Linq;
using System.Diagnostics;
using System.Threading;

namespace Usoniandream.WindowsPhone.LocationServices.Service.Reactive
{
    /// <summary>
    /// base for all reactive service layers
    /// </summary>
    public sealed class GenericServiceLayer : IService
    {
        public GenericServiceLayer()
        {}

        /// <summary>
        /// Executes the request return first observable.
        /// </summary>
        /// <typeparam name="Ttarget">The type of the target.</typeparam>
        /// <typeparam name="Tsource">The type of the source.</typeparam>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Ttarget> ExecuteRequestReturnFirstObservable<Ttarget, Tsource>(SearchCriterias.ISearchCriteria<Ttarget, Tsource> criteria) where Tsource : new()
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename' (or 'baseuri'), please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey) && !criteria.SkipAPIKeyCheck)
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            if (criteria.DebugMode)
            {
                Debug.WriteLine(string.Format("LocationServices - executing criteria - {0}", criteria.Client.BuildUri(criteria.Request)));
            }

            if (criteria.CacheSettings != null)
            {
                if (criteria.CacheSettings.Provider!=null)
                {
                    if (criteria.CacheSettings.Provider.IsCached(criteria))
                    {
                        if (criteria.CacheSettings.Provider.IsValid<Tsource>(criteria, criteria.CacheSettings.Duration))
                        {
                            Debug.WriteLine("returning " + criteria.GetType().FullName + " cached response");
                            return criteria.CacheSettings.Provider.GetCachedData<Tsource>(criteria).Select<Tsource, Ttarget>(x => criteria.Mapper.JSON2FirstModel(x));
                        }
                    }
                }
            }

            IObservable<Tsource> ret = null;
            ret = criteria.Client.ExecuteAsync<Tsource>(criteria.Request)
                .Finally(() =>
                {
                    if (criteria.CacheSettings != null)
                    {
                        if (criteria.CacheSettings.Provider!=null)
                        {
                            if (ret!=null)
                            {
                                ThreadPool.QueueUserWorkItem((o) => criteria.CacheSettings.Provider.Add<Tsource>(criteria, ret, criteria.CacheSettings.Duration));
                            }
                        }
                    }
                });
            Debug.WriteLine("returning " + criteria.GetType().FullName + " response from calling service");
            return ret.Select<Tsource, Ttarget>(x => criteria.Mapper.JSON2FirstModel(x));
        }

        /// <summary>
        /// Executes the request return observable.
        /// </summary>
        /// <typeparam name="Ttarget">The type of the target.</typeparam>
        /// <typeparam name="Tsource">The type of the source.</typeparam>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public IObservable<Ttarget> ExecuteRequestReturnObservable<Ttarget, Tsource>(SearchCriterias.ISearchCriteria<Ttarget, Tsource> criteria) where Tsource : new()
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename' (or 'baseuri'), please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey) && !criteria.SkipAPIKeyCheck)
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            if (criteria.DebugMode)
            {
                Debug.WriteLine(string.Format("LocationServices - executing criteria - {0}", criteria.Client.BuildUri(criteria.Request)));
            }

            if (criteria.CacheSettings!=null)
            {
                if (criteria.CacheSettings.Provider!=null)
                {
                    if (criteria.CacheSettings.Provider.IsCached(criteria))
                    {
                        if (criteria.CacheSettings.Provider.IsValid<Tsource>(criteria, criteria.CacheSettings.Duration))
                        {
                            Debug.WriteLine("returning " + criteria.GetType().FullName + " cached response");
                            return criteria.CacheSettings.Provider.GetCachedData<Tsource>(criteria).SelectMany<Tsource, Ttarget>(x => criteria.Mapper.JSON2Model(x));
                        }
                    }
                }
            }

            IObservable<Tsource> ret = null;
            ret = criteria.Client.ExecuteAsync<Tsource>(criteria.Request)
                .Finally(() =>
                {
                    if (criteria.CacheSettings != null)
                    {
                        if (criteria.CacheSettings.Provider!=null)
                        {
                            if (ret != null)
                            {
                                ThreadPool.QueueUserWorkItem((o) => criteria.CacheSettings.Provider.Add<Tsource>(criteria, ret, criteria.CacheSettings.Duration));
                            }
                        }
                    }
                });
            Debug.WriteLine("returning " + criteria.GetType().FullName + " response from calling service");
            return ret.SelectMany<Tsource, Ttarget>(x => criteria.Mapper.JSON2Model(x));
        }

        public IObservable<Models.GenericPagedResultsContainer<Ttarget>> ExecuteRequestReturnPagedObservable<Ttarget, Tsource>(SearchCriterias.ISearchCriteria<Ttarget, Tsource> criteria) where Tsource : new()
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename' (or 'baseuri'), please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey) && !criteria.SkipAPIKeyCheck)
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            if (criteria.DebugMode)
            {
                Debug.WriteLine(string.Format("LocationServices - executing criteria - {0}", criteria.Client.BuildUri(criteria.Request)));
            }

            if (criteria.CacheSettings != null)
            {
                if (criteria.CacheSettings.Provider!=null)
                {
                    if (criteria.CacheSettings.Provider.IsCached(criteria))
                    {
                        if (criteria.CacheSettings.Provider.IsValid<Tsource>(criteria, criteria.CacheSettings.Duration))
                        {
                            Debug.WriteLine("returning " + criteria.GetType().FullName + " cached response");
                            return criteria.CacheSettings.Provider.GetCachedData<Tsource>(criteria).Select<Tsource, Models.GenericPagedResultsContainer<Ttarget>>(x => criteria.Mapper.JSON2PagedContainer(x));
                        }
                    }
                }
           }

            IObservable<Tsource> ret = null;
            ret = criteria.Client.ExecuteAsync<Tsource>(criteria.Request)
                .Finally(() =>
                {
                    if (criteria.CacheSettings != null)
                    {
                        if (criteria.CacheSettings.Provider!=null)
                        {
                            if (ret!=null)
                            {
                                ThreadPool.QueueUserWorkItem((o) => criteria.CacheSettings.Provider.Add<Tsource>(criteria, ret, criteria.CacheSettings.Duration));
                            }
                        }
                    }
                });
            Debug.WriteLine("returning " + criteria.GetType().FullName + " mapped observable to service");
            return ret.Select<Tsource, Models.GenericPagedResultsContainer<Ttarget>>(x => criteria.Mapper.JSON2PagedContainer(x));
        }
    }
}
