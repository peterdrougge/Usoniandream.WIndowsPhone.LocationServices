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
            this.gbgservicelayer = new Service.Goteborg.ServiceLayer();
            this.sthlmservicelayer = new Service.Stockholm.ServiceLayer();
            this.nokiaservicelayer = new Service.Nokia.ServiceLayer();
            this.bingservicelayer = new Service.Bing.ServiceLayer();

            //this.ParkingLocations = new ObservableCollection<LocationServices.Models.Stockholm.ParkingLocation>();
            //this.ParkingMeters = new ObservableCollection<LocationServices.Models.Stockholm.ParkingMeter>();
            //this.ServiceUnits = new ObservableCollection<LocationServices.Models.Stockholm.ServiceUnit>();
            //this.Places = new ObservableCollection<LocationServices.Models.Nokia.Places.Place>();
        }
        private ObservableCollection<GenericPivotItem> pivotItems;
        public ObservableCollection<GenericPivotItem> PivotItems { get { if (pivotItems == null) pivotItems = new ObservableCollection<GenericPivotItem>(); return pivotItems; } set { pivotItems = value; } }

        public Service.Goteborg.ServiceLayer gbgservicelayer { get; private set; }
        public Service.Stockholm.ServiceLayer sthlmservicelayer { get; private set; }
        public Service.Nokia.ServiceLayer nokiaservicelayer { get; private set; }
        public Service.Bing.ServiceLayer bingservicelayer { get; private set; }

        //public ObservableCollection<LocationServices.Models.Stockholm.ParkingLocation> ParkingLocations { get; private set; }
        //public ObservableCollection<LocationServices.Models.Stockholm.ParkingMeter> ParkingMeters { get; private set; }
        //public ObservableCollection<LocationServices.Models.Stockholm.ServiceUnit> ServiceUnits { get; private set; }
        //public ObservableCollection<LocationServices.Models.Nokia.Places.Place> Places { get; private set; }

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
            GenericPivotItem parkings = new GenericPivotItem() { Header = "p-platser", Source = "stockholm stad" };
            var rxlocations = sthlmservicelayer.GetParkingLocationsByStreet(new Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.Parking.ParkingLocation.ParkingLocationsByStreet("Odengatan", Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.VehicleTypeEnum.Car))
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() =>
                {
                    PivotItems.Add(parkings);
                    IsDataLoading = false;
                })
                .Subscribe(
                // result
                    x =>
                    {
                        parkings.Items.Add(x);
                    },
                // exception
                    ex =>
                    {
                        // handle exception..
                    });

            IsDataLoading = true;
            GenericPivotItem parkingmeters = new GenericPivotItem() { Header = "automater", Source = "stockholm stad" };
            var rxmeters = sthlmservicelayer.GetParkingMeters(new Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.Parking.ParkingMeter.ParkingMeter())
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() =>
                {
                    PivotItems.Add(parkingmeters);
                    IsDataLoading = false;
                })
                .Subscribe(
                // result
                    x =>
                    {
                        parkingmeters.Items.Add(x);
                    },
                // exception
                    ex =>
                    {
                        // handle exception..
                    });

            IsDataLoading = true;
            GenericPivotItem serviceunits = new GenericPivotItem() { Header = "service", Source = "stockholm stad" };
            var rxguides = sthlmservicelayer.GetServiceUnitTypes(new Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.ServiceGuide.ServiceUnitTypes())
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() =>
                    {
                        PivotItems.Add(serviceunits);
                        IsDataLoading = false;
                    })
                .Subscribe(
                // result
                    x =>
                    {
                        serviceunits.Items.Add(x);
                    },
                // exception
                    ex =>
                    {
                        MessageBox.Show(ex.Message);
                    });

            IsDataLoading = true;
            GenericPivotItem placeserviceunits = new GenericPivotItem() { Header = "place", Source = "stockholm stad" };
            var rxplaceguides = sthlmservicelayer.GetPlaceServiceUnitTypes(new Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.Place.ServiceUnitTypes())
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() =>
                {
                    PivotItems.Add(placeserviceunits);
                    IsDataLoading = false;
                })
                .Subscribe(
                // result
                    x =>
                    {
                        placeserviceunits.Items.Add(x);
                    },
                // exception
                    ex =>
                    {
                        MessageBox.Show(ex.Message);
                    });

            IsDataLoading = true;
            GenericPivotItem gbgparkingmeters = new GenericPivotItem() { Header = "automater", Source = "göteborg stad" };
            var rxggbparkingmeters = gbgservicelayer.GetPayMachinesByRadius(new SearchCriterias.Goteborg.Parking.PublicPayMachinesByRadius(500, new GeoCoordinate(57.69962,11.97654)))
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() =>
                {
                    PivotItems.Add(gbgparkingmeters);
                    IsDataLoading = false;
                })
                .Subscribe(
                // result
                    x =>
                    {
                        gbgparkingmeters.Items.Add(x);
                    },
                // exception
                    ex =>
                    {
                        MessageBox.Show(ex.Message);
                    });

            IsDataLoading = true;
            GenericPivotItem gbgpublictimeparkings = new GenericPivotItem() { Header = "p-platser", Source = "göteborg stad" };
            var rxgbgpublictime = gbgservicelayer.GetPublicTimeParkingsByRadius(new SearchCriterias.Goteborg.Parking.PublicTimeParkingsByRadius(500, new GeoCoordinate(57.69962, 11.97654)))
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() =>
                {
                    PivotItems.Add(gbgpublictimeparkings);
                    IsDataLoading = false;
                })
                .Subscribe(
                // result
                    x =>
                    {
                        gbgpublictimeparkings.Items.Add(x);
                    },
                // exception
                    ex =>
                    {
                        MessageBox.Show(ex.Message);
                    });

            IsDataLoading = true;

            GenericPivotItem nokiaplaces = new GenericPivotItem() { Header = "nokia places", Source = "nokia" };
            var rxplaces = nokiaservicelayer.GetNokiaPlaces(new Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Nokia.Places.Places(new GeoCoordinate(40.74917, -73.98529)))
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() =>
                {
                    PivotItems.Add(nokiaplaces);
                    IsDataLoading = false;
                })
                .Subscribe(
                // result
                    x =>
                    {
                        nokiaplaces.Items.Add(x);
                    },
                // exception
                    ex =>
                    {
                        // handle exception..
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