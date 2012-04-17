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

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias
{
    public abstract class SearchCriteriaBase<Ttarget, Tsource> : INotifyPropertyChanged, Usoniandream.WindowsPhone.LocationServices.SearchCriterias.ISearchCriteria<Ttarget, Tsource>
    {
        public SearchCriteriaBase()
        {
            Request = new RestRequest();
            Client = new RestClient();
        }
        public SearchCriteriaBase(string baseurlresourcename)
        {
            Request = new RestRequest();
            if (string.IsNullOrWhiteSpace(baseurlresourcename))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            Client = new RestClient(((Models.ServiceURI)Application.Current.Resources[baseurlresourcename]).URL);
        }
        public SearchCriteriaBase(Method method)
        {
            Request = new RestRequest(method);
            Client = new RestClient();
        }
        public SearchCriteriaBase(Method method, string baseurlresourcename)
        {
            Request = new RestRequest(method);
            if (string.IsNullOrWhiteSpace(baseurlresourcename))
            {
                throw new ArgumentException("missing 'baseurlresourcename', please check App.xaml.", "baseurlresourcename");
            }
            Client = new RestClient(((Models.ServiceURI)Application.Current.Resources[baseurlresourcename]).URL);
        }

        public RestClient Client { get; private set; }
        public RestRequest Request { get; private set; }

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
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
