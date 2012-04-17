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
using Usoniandream.WindowsPhone.LocationServices.Models.Stockholm;
using System.Windows;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Linq;

namespace Usoniandream.WindowsPhone.LocationServices.Service.Stockholm
{
    public class ServiceLayer
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

        public IObservable<Models.Stockholm.ServiceGuide> GetServiceGuides(SearchCriterias.Stockholm.ServiceGuide.ServiceGuides criteria)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            return criteria.Client.ExecuteAsync<Models.JSON.Stockholm.ServiceGuide.RootObject>(criteria.Request)
                            .SelectMany<Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ServiceGuide.RootObject, ServiceGuide>(x => criteria.Mapper.JSON2Model(x))
                            .ObserveOnDispatcher();
        }
    }
}
