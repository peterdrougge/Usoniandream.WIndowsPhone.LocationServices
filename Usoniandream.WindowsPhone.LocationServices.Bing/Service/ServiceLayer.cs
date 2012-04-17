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
using Usoniandream.WindowsPhone.LocationServices.Models.Bing;

namespace Usoniandream.WindowsPhone.LocationServices.Service.Bing
{
    public class ServiceLayer
    {
        public IObservable<BingMapLocation> GetAddressAtPoint(SearchCriterias.Bing.AddressByPoint criteria)
        {
            if (String.IsNullOrWhiteSpace(criteria.Client.BaseUrl))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            if (String.IsNullOrWhiteSpace(criteria.APIkey))
            {
                throw new ArgumentException("missing api key, please check App.xaml.", "APIkey");
            }

            return criteria.Client.ExecuteAsync<Models.JSON.Bing.BingLocation.RootObject>(criteria.Request)
                            .Select<Usoniandream.WindowsPhone.LocationServices.Models.JSON.Bing.BingLocation.RootObject, BingMapLocation>(x => criteria.Mapper.JSON2FirstModel(x))
                            .ObserveOnDispatcher();
        }

    }
}
