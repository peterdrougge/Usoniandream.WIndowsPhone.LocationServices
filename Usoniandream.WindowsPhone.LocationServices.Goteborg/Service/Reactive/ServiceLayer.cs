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

namespace Usoniandream.WindowsPhone.LocationServices.Service.Goteborg.Reactive
{
    public class ServiceLayer : IService
    {
        public IObservable<Models.Goteborg.Parking.PublicPayMachine> GetPayMachinesByRadius(SearchCriterias.Goteborg.Parking.PublicPayMachinesByRadius criteria)
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
                                       .Select(x => JsonConvert.DeserializeObject<Models.JSON.Goteborg.PublicPayMachines.RootObject>("{\"features\":" + x + "}"))
                                       .SelectMany<Models.JSON.Goteborg.PublicPayMachines.RootObject, Models.Goteborg.Parking.PublicPayMachine>(x => criteria.Mapper.JSON2Model(x));
        }

        public IObservable<Models.Goteborg.Parking.PrivateParking> GetPrivateParkingsByRadius(SearchCriterias.Goteborg.Parking.PrivateParkingsByRadius criteria)
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
                                       .Select(x => JsonConvert.DeserializeObject<Models.JSON.Goteborg.PrivateParkings.RootObject>("{\"features\":" + x + "}"))
                                       .SelectMany<Models.JSON.Goteborg.PrivateParkings.RootObject, Models.Goteborg.Parking.PrivateParking>(x => criteria.Mapper.JSON2Model(x));
        }

        public IObservable<Models.Goteborg.Parking.BusParking> GetBusParkingsByRadius(SearchCriterias.Goteborg.Parking.BusParkingsByRadius criteria)
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
                                       .Select(x => JsonConvert.DeserializeObject<Models.JSON.Goteborg.BusParkings.RootObject>("{\"features\":" + x + "}"))
                                       .SelectMany<Models.JSON.Goteborg.BusParkings.RootObject, Models.Goteborg.Parking.BusParking>(x => criteria.Mapper.JSON2Model(x));
        }

        public IObservable<Models.Goteborg.Parking.MotorcycleParking> GetMotorcykleParkingsByRadius(SearchCriterias.Goteborg.Parking.MotorcycleParkingsByRadius criteria)
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
                                       .Select(x => JsonConvert.DeserializeObject<Models.JSON.Goteborg.MotorcyleParkings.RootObject>("{\"features\":" + x + "}"))
                                       .SelectMany<Models.JSON.Goteborg.MotorcyleParkings.RootObject, Models.Goteborg.Parking.MotorcycleParking>(x => criteria.Mapper.JSON2Model(x));
        }

        public IObservable<Models.Goteborg.Parking.HandicapParking> GetHandicapParkingsByRadius(SearchCriterias.Goteborg.Parking.HandicapParkingsByRadius criteria)
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
                                       .Select(x => JsonConvert.DeserializeObject<Models.JSON.Goteborg.HandicapParkings.RootObject>("{\"features\":" + x + "}"))
                                       .SelectMany<Models.JSON.Goteborg.HandicapParkings.RootObject, Models.Goteborg.Parking.HandicapParking>(x => criteria.Mapper.JSON2Model(x));
        }

        public IObservable<Models.Goteborg.Parking.ResidentialParking> GetResidentialParkingsByRadius(SearchCriterias.Goteborg.Parking.ResidentialParkingsByRadius criteria)
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
                                       .Select(x => JsonConvert.DeserializeObject<Models.JSON.Goteborg.ResidentialParkings.RootObject>("{\"features\":" + x + "}"))
                                       .SelectMany<Models.JSON.Goteborg.ResidentialParkings.RootObject, Models.Goteborg.Parking.ResidentialParking>(x => criteria.Mapper.JSON2Model(x));
        }
        public IObservable<Models.Goteborg.Parking.PublicTimeParking> GetPublicTimeParkingsByRadius(SearchCriterias.Goteborg.Parking.PublicTimeParkingsByRadius criteria)
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
                                       .Select(x => JsonConvert.DeserializeObject<Models.JSON.Goteborg.PublicTimeParkings.RootObject>("{\"features\":" + x + "}"))
                                       .SelectMany<Models.JSON.Goteborg.PublicTimeParkings.RootObject, Models.Goteborg.Parking.PublicTimeParking>(x => criteria.Mapper.JSON2Model(x));
        }
        public IObservable<Models.Goteborg.Parking.PublicTollParking> GetPublicTollParkingsByRadius(SearchCriterias.Goteborg.Parking.PublicTollParkingsByRadius criteria)
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
                                       .Select(x => JsonConvert.DeserializeObject<Models.JSON.Goteborg.PublicTollParkings.RootObject>("{\"features\":" + x + "}"))
                                       .SelectMany<Models.JSON.Goteborg.PublicTollParkings.RootObject, Models.Goteborg.Parking.PublicTollParking>(x => criteria.Mapper.JSON2Model(x));
        }


    }
}
