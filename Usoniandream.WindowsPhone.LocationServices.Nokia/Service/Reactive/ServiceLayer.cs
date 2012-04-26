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

namespace Usoniandream.WindowsPhone.LocationServices.Service.Nokia.Reactive
{
    public class ServiceLayer
    {
        public IObservable<Models.Nokia.Places.Place> SearchNokiaPlaces(SearchCriterias.Nokia.Places.SearchPlaces criteria)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            return criteria.Client.ExecuteAsync<Models.JSON.Nokia.Places.RootObject>(criteria.Request)
                    .SelectMany<Usoniandream.WindowsPhone.LocationServices.Models.JSON.Nokia.Places.RootObject, Models.Nokia.Places.Place>(x => criteria.Mapper.JSON2Model(x));

        }
        public IObservable<Models.Nokia.Places.Place> GetNokiaPlaces(SearchCriterias.Nokia.Places.Places criteria)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            return criteria.Client.ExecuteAsync<Models.JSON.Nokia.Places.RootObject>(criteria.Request)
                    .SelectMany<Usoniandream.WindowsPhone.LocationServices.Models.JSON.Nokia.Places.RootObject, Models.Nokia.Places.Place>(x => criteria.Mapper.JSON2Model(x));
 
        }
        public IObservable<Models.Nokia.Places.PlaceDetails> GetNokiaPlace(SearchCriterias.Nokia.Places.Place criteria)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            return criteria.Client.ExecuteAsync<Models.JSON.Nokia.Place.RootObject>(criteria.Request)
                    .Select<Usoniandream.WindowsPhone.LocationServices.Models.JSON.Nokia.Place.RootObject, Models.Nokia.Places.PlaceDetails>(x => criteria.Mapper.JSON2FirstModel(x));

        }
    }
}
