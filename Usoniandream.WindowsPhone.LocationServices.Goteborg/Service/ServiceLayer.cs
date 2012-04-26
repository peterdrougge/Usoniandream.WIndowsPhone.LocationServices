using System;
using System.ComponentModel;
using System.Device.Location;
using System.Diagnostics;
using System.Reactive.Linq;
using RestSharp;
using Usoniandream.WindowsPhone.Extensions;
using Usoniandream.WindowsPhone;
using Usoniandream.WindowsPhone.GeoConverter;
using Usoniandream.WindowsPhone.LocationServices.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Usoniandream.WindowsPhone.LocationServices.Service.Goteborg
{
    public class ServiceLayer : IService
    {
        public void GetPayMachinesByRadius(SearchCriterias.Goteborg.Parking.PublicPayMachinesByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.PublicPayMachines.RootObject>> callback)
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

        public void GetPrivateParkingsByRadius(SearchCriterias.Goteborg.Parking.PrivateParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.PrivateParkings.RootObject>> callback)
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

        public void GetBusParkingsByRadius(SearchCriterias.Goteborg.Parking.BusParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.BusParkings.RootObject>> callback)
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

        public void GetMotorcykleParkingsByRadius(SearchCriterias.Goteborg.Parking.MotorcycleParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.MotorcyleParkings.RootObject>> callback)
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

        public void GetHandicapParkingsByRadius(SearchCriterias.Goteborg.Parking.HandicapParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.HandicapParkings.RootObject>> callback)
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

        public void GetResidentialParkingsByRadius(SearchCriterias.Goteborg.Parking.ResidentialParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.ResidentialParkings.RootObject>> callback)
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
        public void GetPublicTimeParkingsByRadius(SearchCriterias.Goteborg.Parking.PublicTimeParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.PublicTimeParkings.RootObject>> callback)
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
        public void GetPublicTollParkingsByRadius(SearchCriterias.Goteborg.Parking.PublicTollParkingsByRadius criteria, Action<RestResponse<Models.JSON.Goteborg.PublicTollParkings.RootObject>> callback)
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


    }
}
