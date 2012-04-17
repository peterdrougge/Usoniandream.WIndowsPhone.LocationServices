using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;
using Usoniandream.WindowsPhone.LocationServices;
using Usoniandream.WindowsPhone.LocationServices.Models;
using System.Device.Location;
using Usoniandream.WindowsPhone.LocationServices.Service;

namespace Usoniandream.WindowsPhone.LocationServices.Tester
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.sthlmservicelayer = new LocationServices.Service.Stockholm.ServiceLayer();
            this.nokiaservicelayer = new LocationServices.Service.Nokia.ServiceLayer();
            this.bingservicelayer = new LocationServices.Service.Bing.ServiceLayer();

            this.ParkingLocations = new ObservableCollection<LocationServices.Models.Stockholm.ParkingLocation>();
            this.ParkingMeters = new ObservableCollection<LocationServices.Models.Stockholm.ParkingMeter>();
            this.ServiceGuides = new ObservableCollection<LocationServices.Models.Stockholm.ServiceGuide>();
            this.Places = new ObservableCollection<LocationServices.Models.Nokia.Places.Place>();
        }

        public Usoniandream.WindowsPhone.LocationServices.Service.Stockholm.ServiceLayer sthlmservicelayer { get; private set; }
        public Usoniandream.WindowsPhone.LocationServices.Service.Nokia.ServiceLayer nokiaservicelayer { get; private set; }
        public Usoniandream.WindowsPhone.LocationServices.Service.Bing.ServiceLayer bingservicelayer { get; private set; }

        public ObservableCollection<LocationServices.Models.Stockholm.ParkingLocation> ParkingLocations { get; private set; }
        public ObservableCollection<LocationServices.Models.Stockholm.ParkingMeter> ParkingMeters { get; private set; }
        public ObservableCollection<LocationServices.Models.Stockholm.ServiceGuide> ServiceGuides { get; private set; }
        public ObservableCollection<LocationServices.Models.Nokia.Places.Place> Places { get; private set; }

        private int isDataLoading = 0;
        public bool IsDataLoading
        {
            get
            {
                return isDataLoading > 0;
            }
            set
            {
                if (value)
                {
                    isDataLoading++;
                }
                else
                {
                    isDataLoading--;
                }
                NotifyPropertyChanged("IsDataLoading");
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            IsDataLoading = true;
            var rxlocations = sthlmservicelayer.GetParkingLocationsByStreet(new Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.Parking.ParkingLocation.ParkingLocationsByStreet("Odengatan", Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.VehicleTypeEnum.Car))
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() => IsDataLoading = false)
                .Subscribe(
                    // result
                    x =>
                    {
                        ParkingLocations.Add(x);
                    },
                    // exception
                    ex =>
                    {
                        MessageBox.Show(ex.Message);
                    });

            IsDataLoading = true;
            var rxmeters = sthlmservicelayer.GetParkingMeters(new Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.Parking.ParkingMeter.ParkingMeter())
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() => IsDataLoading = false)
                .Subscribe(
                // result
                    x =>
                    {
                        ParkingMeters.Add(x);
                    },
                // exception
                    ex =>
                    {
                        MessageBox.Show(ex.Message);
                    });

            IsDataLoading = true;
            var rxguides = sthlmservicelayer.GetServiceGuides(new Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.ServiceGuide.ServiceGuides())
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() => IsDataLoading = false)
                .Subscribe(
                // result
                    x =>
                    {
                        ServiceGuides.Add(x);
                    },
                // exception
                    ex =>
                    {
                        MessageBox.Show(ex.Message);
                    });

            IsDataLoading = true;

            var rxplaces = nokiaservicelayer.GetNokiaPlaces(new Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Nokia.Places.Places(new GeoCoordinate(40.74917, -73.98529)))
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() => IsDataLoading = false)
                .Subscribe(
                // result
                    x =>
                    {
                        Places.Add(x);
                    },
                // exception
                    ex =>
                    {
                        MessageBox.Show(ex.Message);
                    });

            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}