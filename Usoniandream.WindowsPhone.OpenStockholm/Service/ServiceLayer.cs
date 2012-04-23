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
        public IObservable<Models.Stockholm.ParkingLocation> GetParkingLocationsByRadius(SearchCriterias.Stockholm.Parking.ParkingLocation.ParkingLocationsByRadius criteria)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            return criteria.Client.ExecuteAsync<Models.JSON.Stockholm.ParkingPlaces.RootObject>(criteria.Request)
                            .SelectMany<Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ParkingPlaces.RootObject, ParkingLocation>(x => criteria.Mapper.JSON2Model(x))
                            .ObserveOnDispatcher();
        }
        public IObservable<Models.Stockholm.ParkingLocation> GetParkingLocationsByStreet(SearchCriterias.Stockholm.Parking.ParkingLocation.ParkingLocationsByStreet criteria)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            return criteria.Client.ExecuteAsync<Models.JSON.Stockholm.ParkingPlaces.RootObject>(criteria.Request)
                            .SelectMany<Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ParkingPlaces.RootObject, ParkingLocation>(x => criteria.Mapper.JSON2Model(x))
                            .ObserveOnDispatcher();
        }

        public IObservable<Models.Stockholm.ParkingMeter> GetParkingMeters(SearchCriterias.Stockholm.Parking.ParkingMeter.ParkingMeter criteria)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            return criteria.Client.ExecuteAsync<Models.JSON.Stockholm.ParkingMeters.RootObject>(criteria.Request)
                            .SelectMany<Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ParkingMeters.RootObject, ParkingMeter>(x => criteria.Mapper.JSON2Model(x))
                            .ObserveOnDispatcher();
        }

        public IObservable<Models.Stockholm.ServiceGuide.ServiceUnitType> GetServiceUnitTypes(SearchCriterias.Stockholm.ServiceGuide.ServiceUnitTypes criteria)
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
                            .Select(x => JsonConvert.DeserializeObject<Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject>("{\"features\":" + x + "}"))
                            .SelectMany<Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject, ServiceUnitType>(x => criteria.Mapper.JSON2Model(x))
                            .ObserveOnDispatcher();
        }

        public IObservable<Models.Stockholm.ServiceGuide.ServiceUnit> GetServiceUnits(SearchCriterias.Stockholm.ServiceGuide.ServiceUnits criteria)
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
                            .Select(x => JsonConvert.DeserializeObject<Models.JSON.Stockholm.ServiceUnits.RootObject>("{\"features\":" + x + "}"))
                            .SelectMany<Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ServiceUnits.RootObject, ServiceUnit>(x => criteria.Mapper.JSON2Model(x))
                            .ObserveOnDispatcher();
        }

        public IObservable<Models.Stockholm.ServiceGuide.DetailedServiceUnit> GetDetailedServiceUnit(SearchCriterias.Stockholm.ServiceGuide.DetailedServiceUnit criteria)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            return criteria.Client.ExecuteAsync<Models.JSON.Stockholm.DetailedServiceUnit.RootObject>(criteria.Request)
                            .Select<Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.DetailedServiceUnit.RootObject, DetailedServiceUnit>(x => criteria.Mapper.JSON2FirstModel(x))
                            .ObserveOnDispatcher();
        }


        public IObservable<Models.Stockholm.Place.ServiceUnitType> GetPlaceServiceUnitTypes(SearchCriterias.Stockholm.Place.ServiceUnitTypes criteria)
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
                            .Select(x => JsonConvert.DeserializeObject<Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject>("{\"features\":" + x + "}"))
                            .SelectMany<Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ServiceGuide.ServiceUnitTypes.RootObject, Usoniandream.WindowsPhone.LocationServices.Models.Stockholm.Place.ServiceUnitType>(x => criteria.Mapper.JSON2Model(x))
                            .ObserveOnDispatcher();
        }

        public IObservable<Models.Stockholm.Place.ServiceUnit> GetPlaceServiceUnits(SearchCriterias.Stockholm.Place.ServiceUnits criteria)
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
                            .Select(x => JsonConvert.DeserializeObject<Models.JSON.Stockholm.ServiceUnits.RootObject>("{\"features\":" + x + "}"))
                            .SelectMany<Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ServiceUnits.RootObject, Usoniandream.WindowsPhone.LocationServices.Models.Stockholm.Place.ServiceUnit>(x => criteria.Mapper.JSON2Model(x))
                            .ObserveOnDispatcher();
        }

        public IObservable<Models.Stockholm.Place.DetailedServiceUnit> GetPlaceDetailedServiceUnit(SearchCriterias.Stockholm.Place.DetailedServiceUnit criteria)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            return criteria.Client.ExecuteAsync<Models.JSON.Stockholm.DetailedServiceUnit.RootObject>(criteria.Request)
                            .Select<Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.DetailedServiceUnit.RootObject, Usoniandream.WindowsPhone.LocationServices.Models.Stockholm.Place.DetailedServiceUnit>(x => criteria.Mapper.JSON2FirstModel(x))
                            .ObserveOnDispatcher();
        }

    
    
    }


}
