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
        }
        private ObservableCollection<GenericPivotItem> pivotItems;
        public ObservableCollection<GenericPivotItem> PivotItems { get { if (pivotItems == null) pivotItems = new ObservableCollection<GenericPivotItem>(); return pivotItems; } set { pivotItems = value; } }

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

        public void LoadData()
        {
            WireStockholmPivotItem();

            //WireGoteborgPivotItem();

            //WireOrebroPivotItem();

            //WireNokiaPivotItem();

            //WireFlickrPivotItem();

            //WireTwitterPivotItem();

            WireInstagramPivotItem();

            //WireBingPivotItem();

            //WireEniroPivotItem();

            this.IsDataLoaded = true;
        }

        private void WireBingPivotItem()
        {
            IsDataLoading = true;
            GenericPivotItem bing = new GenericPivotItem() { Header = "translation", Source = "bing" };
            WindowsPhone.LocationServices.SearchCriterias.Bing.Translation criteria = new Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Bing.Translation("sv", "en", "en-US", "badplatser", "parklek", "samhälle");
            var rxbing = criteria.Execute()
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() =>
                {
                    PivotItems.Add(bing);
                    IsDataLoading = false;
                })
                .Subscribe(
                // result
                    x =>
                    {
                        bing.Items.Add(x);
                    },
                // exception
                    ex =>
                    {
                        MessageBox.Show(ex.Message);
                    });

        }

        private void WireEniroPivotItem()
        {
            IsDataLoading = true;
            GenericPivotItem eniro = new GenericPivotItem() { Header = "företag", Source = "eniro" };
            //eniroservicelayer.CacheProvider.RemoveOldestEntry();
            WindowsPhone.LocationServices.SearchCriterias.Eniro.CompanySearch criteria = new SearchCriterias.Eniro.CompanySearch("bärgning", "se");// { CacheSettings = new SearchCriterias.CriteriaCacheSettings(60 * 60 * 24) };
            var rxeniro = criteria.Execute()
                .ObserveOnDispatcher()
                .Finally(() =>
                {
                    PivotItems.Add(eniro);
                    IsDataLoading = false;
                })
                .Subscribe(
                // result
                    x =>
                    {
                        eniro.Items.Add(x);
                    },
                // exception
                    ex =>
                    {
                        MessageBox.Show(ex.Message);
                    });
        }

        private void WireInstagramPivotItem()
        {
            IsDataLoading = true;
            GenericPivotItem instagram = new GenericPivotItem() { Header = "photos", Source = "instagram" };
            WindowsPhone.LocationServices.SearchCriterias.Instagram.MediaByLocation criteria = new Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Instagram.MediaByLocation(new GeoCoordinate(40.74917, -73.98529)) { CacheSettings = new SearchCriterias.CriteriaCacheSettings(new Caching.IsoStoreCache.IsolatedStorageCacheProvider(), 60 * 60 * 24)};
            var rxinstagram = criteria.Execute()
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() =>
                {
                    PivotItems.Add(instagram);
                    IsDataLoading = false;
                })
                .Subscribe(
                // result
                    x =>
                    {
                        instagram.Items.Add(x);
                    },
                // exception
                    ex =>
                    {
                        MessageBox.Show(ex.Message);
                    });
        }

        private void WireTwitterPivotItem()
        {
            IsDataLoading = true;
            GenericPivotItem tweets = new GenericPivotItem() { Header = "tweets", Source = "twitter" };
            var rxtweets = new Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Twitter.SearchByRadius(new GeoCoordinate(40.74917, -73.98529), 0.5).Execute()
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() =>
                {
                    PivotItems.Add(tweets);
                    IsDataLoading = false;
                })
                .Subscribe(
                // result
                    x =>
                    {
                        tweets.Items.Add(x);
                    },
                // exception
                    ex =>
                    {
                        // handle exception..
                    });

        }

        private void WireFlickrPivotItem()
        {
            IsDataLoading = true;
            GenericPivotItem flickrphotos = new GenericPivotItem() { Header = "foton", Source = "flickr" };
            var rxflickrphotos = new Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Flickr.PhotosByLocation(new GeoCoordinate(40.74917, -73.98529), false).Execute()
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() =>
                {
                    PivotItems.Add(flickrphotos);
                    IsDataLoading = false;
                })
                .Subscribe(
                // result
                    x =>
                    {
                        flickrphotos.Items.Add(x);
                    },
                // exception
                    ex =>
                    {
                        // handle exception..
                    });
        }

        private void WireNokiaPivotItem()
        {
            IsDataLoading = true;
            GenericPivotItem nokiaplaces = new GenericPivotItem() { Header = "nokia places", Source = "nokia" };
            var rxplaces = new Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Nokia.Places.Places(new GeoCoordinate(59.3757, 017.8770)).Execute()
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
        }

        private void WireOrebroPivotItem()
        {
            IsDataLoading = true;
            GenericPivotItem orebroparkings = new GenericPivotItem() { Header = "p-platser", Source = "örebro" };
            var rxorebroparkings = new SearchCriterias.Orebro.Parkings().Execute()
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() =>
                {
                    PivotItems.Add(orebroparkings);
                    IsDataLoading = false;
                })
                .Subscribe(
                // result
                    x =>
                    {
                        orebroparkings.Items.Add(x);
                    },
                // exception
                    ex =>
                    {
                        MessageBox.Show(ex.Message);
                    });

            IsDataLoading = true;
            GenericPivotItem orebroparks = new GenericPivotItem() { Header = "parker", Source = "örebro" };
            var rxorebroparks = new SearchCriterias.Orebro.Parks().Execute()
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() =>
                {
                    PivotItems.Add(orebroparks);
                    IsDataLoading = false;
                })
                .Subscribe(
                // result
                    x =>
                    {
                        orebroparks.Items.Add(x);
                    },
                // exception
                    ex =>
                    {
                        MessageBox.Show(ex.Message);
                    });

            IsDataLoading = true;
            GenericPivotItem orebrobaths = new GenericPivotItem() { Header = "badplatser", Source = "örebro" };
            var rxorebrobaths = new SearchCriterias.Orebro.Baths().Execute()
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() =>
                {
                    PivotItems.Add(orebrobaths);
                    IsDataLoading = false;
                })
                .Subscribe(
                // result
                    x =>
                    {
                        orebrobaths.Items.Add(x);
                    },
                // exception
                    ex =>
                    {
                        MessageBox.Show(ex.Message);
                    });

            IsDataLoading = true;
            GenericPivotItem orebrorecycling = new GenericPivotItem() { Header = "återvinn", Source = "örebro" };
            var rxorebrorecycling = new SearchCriterias.Orebro.Recycling().Execute()
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() =>
                {
                    PivotItems.Add(orebrorecycling);
                    IsDataLoading = false;
                })
                .Subscribe(
                // result
                    x =>
                    {
                        orebrorecycling.Items.Add(x);
                    },
                // exception
                    ex =>
                    {
                        MessageBox.Show(ex.Message);
                    });
        }

        private void WireGoteborgPivotItem()
        {
            IsDataLoading = true;
            GenericPivotItem gbgparkingmeters = new GenericPivotItem() { Header = "automater", Source = "göteborg stad" };
            var rxggbparkingmeters = new SearchCriterias.Goteborg.Parking.PublicPayMachinesByRadius(500, new GeoCoordinate(57.69962, 11.97654)).Execute()
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
            var rxgbgpublictime = new SearchCriterias.Goteborg.Parking.PublicTimeParkingsByRadius(500, new GeoCoordinate(57.69962, 11.97654)).Execute()
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
            GenericPivotItem gbgbikestations = new GenericPivotItem() { Header = "cykelställ", Source = "göteborg stad" };
            var rxgbgbikestations = new SearchCriterias.Goteborg.StyrOchStall.BikeStationsByRadius(500, new GeoCoordinate(57.69962, 11.97654)).Execute()
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() =>
                {
                    PivotItems.Add(gbgbikestations);
                    IsDataLoading = false;
                })
                .Subscribe(
                // result
                    x =>
                    {
                        gbgbikestations.Items.Add(x);
                    },
                // exception
                    ex =>
                    {
                        MessageBox.Show(ex.Message);
                    });

            IsDataLoading = true;
            GenericPivotItem gbgcameras = new GenericPivotItem() { Header = "kameror", Source = "göteborg stad" };
            var rxgbgcameras = new SearchCriterias.Goteborg.TrafficCamera.TrafficCameras().Execute()
                .Take(20)
                .ObserveOnDispatcher()
                .Finally(() =>
                {
                    PivotItems.Add(gbgcameras);
                    IsDataLoading = false;
                })
                .Subscribe(
                // result
                    x =>
                    {
                        gbgcameras.Items.Add(x);
                    },
                // exception
                    ex =>
                    {
                        MessageBox.Show(ex.Message);
                    });
        }

        private void WireStockholmPivotItem()
        {
            IsDataLoading = true;
            GenericPivotItem parkings = new GenericPivotItem() { Header = "p-platser", Source = "stockholm stad" };
            var rxlocations = new Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.Parking.ParkingLocation.ParkingLocationsByStreet("Odengatan", Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.VehicleTypeEnum.Car).Execute()
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
            var rxmeters = new Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.Parking.ParkingMeter.ParkingMeter().Execute()
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
            var rxguides = new Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.ServiceGuide.ServiceUnitTypes().Execute()
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
            var rxplaceguides = new Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.Place.ServiceUnitTypes().Execute()
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