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
using System.ComponentModel;
using System.Device.Location;
using System.Diagnostics;
using System.Reactive.Linq;
using RestSharp;
using Usoniandream.WindowsPhone;
using Usoniandream.WindowsPhone.Extensions;
using Usoniandream.WindowsPhone.GeoConverter;
using Usoniandream.WindowsPhone.LocationServices.Models;
using Usoniandream.WindowsPhone.LocationServices.Models.Stockholm;
using System.Windows;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Linq;
using Usoniandream.WindowsPhone.LocationServices.Models.Stockholm.ServiceGuide;

namespace Usoniandream.WindowsPhone.LocationServices.Service.Stockholm
{
    public class ServiceLayer : IService
    {
        public void GetParkingLocationsByRadius(SearchCriterias.Stockholm.Parking.ParkingLocation.ParkingLocationsByRadius criteria, Action<RestResponse<Models.JSON.Stockholm.ParkingPlaces.RootObject>> callback)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            criteria.Client.ExecuteAsync<Models.JSON.Stockholm.ParkingPlaces.RootObject>(criteria.Request, callback);
        }
        public void GetParkingLocationsByStreet(SearchCriterias.Stockholm.Parking.ParkingLocation.ParkingLocationsByStreet criteria, Action<RestResponse<Models.JSON.Stockholm.ParkingPlaces.RootObject>> callback)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            criteria.Client.ExecuteAsync<Models.JSON.Stockholm.ParkingPlaces.RootObject>(criteria.Request, callback);
        }

        public void GetParkingMeters(SearchCriterias.Stockholm.Parking.ParkingMeter.ParkingMeter criteria, Action<RestResponse<Models.JSON.Stockholm.ParkingMeters.RootObject>> callback)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            criteria.Client.ExecuteAsync<Models.JSON.Stockholm.ParkingMeters.RootObject>(criteria.Request, callback);
        }

        public void GetServiceUnitTypes(SearchCriterias.Stockholm.ServiceGuide.ServiceUnitTypes criteria, Action<RestResponse<Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject>> callback)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            criteria.Client.ExecuteAsync(criteria.Request, callback);
        }

        public void GetServiceUnits(SearchCriterias.Stockholm.ServiceGuide.ServiceUnits criteria, Action<RestResponse<Models.JSON.Stockholm.ServiceUnits.RootObject>> callback)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            criteria.Client.ExecuteAsync(criteria.Request, callback);
        }

        public void SearchServiceUnits(SearchCriterias.Stockholm.ServiceGuide.SearchServiceUnits criteria, Action<RestResponse<Models.JSON.Stockholm.ServiceUnits.RootObject>> callback)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            criteria.Client.ExecuteAsync(criteria.Request, callback);
        }

        public void GetDetailedServiceUnit(SearchCriterias.Stockholm.ServiceGuide.DetailedServiceUnit criteria, Action<RestResponse<Models.JSON.Stockholm.DetailedServiceUnit.RootObject>> callback)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            criteria.Client.ExecuteAsync<Models.JSON.Stockholm.DetailedServiceUnit.RootObject>(criteria.Request, callback);
        }


        public void GetPlaceServiceUnitTypes(SearchCriterias.Stockholm.Place.ServiceUnitTypes criteria, Action<RestResponse<Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject>> callback)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            criteria.Client.ExecuteAsync(criteria.Request, callback);
        }

        public void GetPlaceServiceUnits(SearchCriterias.Stockholm.Place.ServiceUnits criteria, Action<RestResponse<Models.JSON.Stockholm.ServiceUnits.RootObject>> callback)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            criteria.Client.ExecuteAsync(criteria.Request, callback);
        }

        public void SearchPlaceServiceUnits(SearchCriterias.Stockholm.Place.SearchServiceUnits criteria, Action<RestResponse<Models.JSON.Stockholm.ServiceUnits.RootObject>> callback)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            criteria.Client.ExecuteAsync(criteria.Request, callback);
        }

        public void GetPlaceDetailedServiceUnit(SearchCriterias.Stockholm.Place.DetailedServiceUnit criteria, Action<RestResponse<Models.JSON.Stockholm.DetailedServiceUnit.RootObject>> callback)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            criteria.Client.ExecuteAsync<Models.JSON.Stockholm.DetailedServiceUnit.RootObject>(criteria.Request);
        }

    }
}
