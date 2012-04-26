﻿using System;
using System.ComponentModel;
using System.Device.Location;
using System.Diagnostics;
using System.Reactive.Linq;
using RestSharp;
using Usoniandream.WindowsPhone.Extensions;
using Usoniandream.WindowsPhone;
using Usoniandream.WindowsPhone.GeoConverter;
using Usoniandream.WindowsPhone.LocationServices.Models;
using Usoniandream.WindowsPhone.LocationServices.Models.Bing;

namespace Usoniandream.WindowsPhone.LocationServices.Service.Bing
{
    public class ServiceLayer : IService
    {
        public void GetAddressAtPoint(SearchCriterias.Bing.AddressByPoint criteria, Action<RestResponse<Models.JSON.Bing.BingLocation.RootObject>> callback)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            criteria.Client.ExecuteAsync<Models.JSON.Bing.BingLocation.RootObject>(criteria.Request, callback);
        }

    }
}
