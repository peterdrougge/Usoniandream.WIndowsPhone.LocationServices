﻿//
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
using System.ComponentModel;
using System.Collections.Generic;
using RestSharp;
using Usoniandream.WindowsPhone.LocationServices.Mappers;
using System.Linq;
using System.Reactive.Linq;

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias
{
    /// <summary>
    /// The base for all SearchCriterias.
    /// </summary>
    /// <typeparam name="Ttarget">The type of the target.</typeparam>
    /// <typeparam name="Tsource">The type of the source.</typeparam>
    public abstract class SearchCriteriaBase<Ttarget, Tsource> : INotifyPropertyChanged, Usoniandream.WindowsPhone.LocationServices.SearchCriterias.ISearchCriteria<Ttarget, Tsource> where Tsource : new()
    {
        public SearchCriteriaBase(SearchCriteriaResultType type)
        {
            Type = type;
            Request = new RestRequest();
            Client = new RestClient();
        }
        
        public SearchCriteriaBase(string baseurlresourcename, SearchCriteriaResultType type)
        {
            Type = type;
            Request = new RestRequest();
            if (string.IsNullOrWhiteSpace(baseurlresourcename))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
                Client = new RestClient(((Models.ServiceURI)Application.Current.Resources[baseurlresourcename]).URL);
        }
        public SearchCriteriaBase(Uri baseuri, SearchCriteriaResultType type)
        {
            Type = type;
            Request = new RestRequest();
            if (baseuri==null)
            {
                throw new ArgumentException("missing 'baseuri", "baseuri");
            }
            Client = new RestClient(baseuri.ToString());
        }
        public SearchCriteriaBase(Uri baseuri, bool skipApiKeyCheck, SearchCriteriaResultType type)
        {
            Type = type;
            Request = new RestRequest();
            if (baseuri == null)
            {
                throw new ArgumentException("missing 'baseuri", "baseuri");
            }
            Client = new RestClient(baseuri.ToString());
            SkipAPIKeyCheck = skipApiKeyCheck;
        }
        public SearchCriteriaBase(Method method, SearchCriteriaResultType type)
        {
            Type = type;
            Request = new RestRequest(method);
            Client = new RestClient();
        }
        public SearchCriteriaBase(Method method, string baseurlresourcename, SearchCriteriaResultType type)
        {
            Type = type;
            Request = new RestRequest(method);
            if (string.IsNullOrWhiteSpace(baseurlresourcename))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            Client = new RestClient(((Models.ServiceURI)Application.Current.Resources[baseurlresourcename]).URL);
        }

        public RestClient Client { get; private set; }
        public RestRequest Request { get; private set; }
        public CriteriaCacheSettings CacheSettings { get; set; }
        public IMapper<Ttarget, Tsource> Mapper { get; set; }
        
        public Dictionary<string, string> Parameters { get; set; }

        public virtual string APIKeyResourceName { get; protected set; }

        private string apikey = null;

        public virtual string APIkey 
        { 
            get
            {
                if (string.IsNullOrWhiteSpace(apikey))
                {
                    if (SkipAPIKeyCheck)
                    {
                        return string.Empty;
                    }
                    if (!String.IsNullOrWhiteSpace(APIKeyResourceName))
                    {
                        return ((Models.ServiceAPIKey)Application.Current.Resources[APIKeyResourceName]).Value;
                    }
                    if (!string.IsNullOrWhiteSpace(apikey))
                    {
                        return apikey;
                    }
                    else
                    {
                        throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
                    }
                }
                return apikey;
            } 
            private set
            {
                apikey = value;
                RaisePropertyChanged("APIkey");
            }
        }

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        protected void SetRequestParameter(string paramname, object value)
        {
            var param = Request.Parameters.FirstOrDefault(x => x.Name == paramname);
            if (param!=null)
            {
                param.Value = value;
            }
            else
            {
                Request.AddParameter(paramname, value);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;


        public bool DebugMode { get; set; }
        public bool SkipAPIKeyCheck { get; set; }

        public string Identifier
        {
            get
            {
                return this.Client.BuildUri(this.Request).ToString().Replace("/", "").Replace(".", "").Replace(",", "").Replace(":","").Replace("&","").Replace("?","").Replace("=","").Replace("-","");
            }
        }

        private Caching.ICacheProvider cacheProvider;
        public Caching.ICacheProvider CacheProvider
        {
            get
            {
                return cacheProvider;
            }
            set
            {
                cacheProvider = value;
            }
        }

        public enum SearchCriteriaResultType
        {
            Collection = 0,
            Single = 1
        }

        public SearchCriteriaResultType Type { get; internal set; }

        public virtual IObservable<Ttarget> Execute()
        {
            Service.Reactive.GenericServiceLayer serviceLayer = new Service.Reactive.GenericServiceLayer();

            switch (Type)
            {
                case SearchCriteriaBase<Ttarget, Tsource>.SearchCriteriaResultType.Collection:
                    return serviceLayer.ExecuteRequestReturnObservable<Ttarget, Tsource>(this);
                case SearchCriteriaBase<Ttarget, Tsource>.SearchCriteriaResultType.Single:
                    return serviceLayer.ExecuteRequestReturnFirstObservable<Ttarget, Tsource>(this);
                default:
                    return serviceLayer.ExecuteRequestReturnObservable<Ttarget, Tsource>(this);
            }
        }

        public virtual IObservable<Models.GenericPagedResultsContainer<Ttarget>> ExecutePaged()
        {
            Service.Reactive.GenericServiceLayer serviceLayer = new Service.Reactive.GenericServiceLayer();

            return serviceLayer.ExecuteRequestReturnPagedObservable<Ttarget, Tsource>(this);
        }
    }
}
