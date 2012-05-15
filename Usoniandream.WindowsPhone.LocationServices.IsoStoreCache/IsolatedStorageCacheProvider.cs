﻿
//
// Copyright (c) 2012 Peter Drougge
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
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
using System.IO.IsolatedStorage;
using System.IO;
using System.Runtime.Serialization;
using System.Linq;
using System.Reactive.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace Usoniandream.WindowsPhone.LocationServices.Caching.IsoStoreCache
{
    public class IsolatedStorageCacheProvider : ICacheProvider
    {

        public bool IsValid<T>(SearchCriterias.ISearchCriteriaFoundation foundation, int duration)
        {
            IsoStoreCacheItem<T> item = null;
            GetItemFromLocalSource<T>(foundation, (o) => { item = o; });
            if (item!=null)
            {
                if (item.Created.AddSeconds(duration)>= DateTime.Now)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsCached(SearchCriterias.ISearchCriteriaFoundation foundation)
        {
            var filename = GetFilename(foundation);
            using (var iso = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (iso.FileExists(filename))
                {
                    Debug.WriteLine("cached entry exists");
                    return true;
                }
            }
            Debug.WriteLine("cached entry does not exists");
            return false;
        }

        public void Remove(SearchCriterias.ISearchCriteriaFoundation foundation)
        {
            var filename = GetFilename(foundation);
            using (var iso = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (iso.FileExists(filename))
                {
                    iso.DeleteFile(filename);
                    Debug.WriteLine("cache entry removed");
                }
            }
        }

        public void Add<T>(SearchCriterias.ISearchCriteriaFoundation foundation, System.IObservable<T> result)
        {
            SaveToLocalSource<T>(foundation, result);
        }

        public System.IObservable<T> GetCachedData<T>(SearchCriterias.ISearchCriteriaFoundation foundation)
        {
            IsoStoreCacheItem<T> ret = null;
            GetItemFromLocalSource<T>(foundation, (o) => { ret = o;});

            if (ret == null)
            {
                Debug.WriteLine("returning null since result wasn't found in cache");
                return null;
            }
            Debug.WriteLine("returning observable result");
            return ret.Data.ToObservable();
        }

        protected virtual string GetFilename(SearchCriterias.ISearchCriteriaFoundation foundation)
        {
            return String.Format("{0}.xml", foundation.Identifier);
        }
        protected virtual void GetItemFromLocalSource<T>(SearchCriterias.ISearchCriteriaFoundation foundation, Action<IsoStoreCacheItem<T>> callback)
        {
            var filename = GetFilename(foundation);
            Object deserialized = null;
            IsoStoreCacheItem<T> result = null;

            using (var iso = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (iso.FileExists(filename))
                {
                    using (IsolatedStorageFileStream file = iso.OpenFile(filename, FileMode.Open))
                    {
                        try
                        {
                            DataContractSerializer serializer = new DataContractSerializer(typeof(IsoStoreCacheItem<T>));
                            deserialized = serializer.ReadObject(file);
                        }
                        catch (Exception ex)
                        {
                            // error, delete the file since we couldn't parse it correctly..
                            Debug.WriteLine(ex.Message);
                        }
                    }
                }
            }

            result = deserialized as IsoStoreCacheItem<T>;
            if (result == null && deserialized != null)
                throw new InvalidCastException(String.Format("{0} is not in the right format.", filename));
            if (result == null)
            {
                Debug.WriteLine("deserialized cache result is null");
                callback(null);
            }
            if (result != null)
            {
                Debug.WriteLine("deserialized cache result, returning object");
                callback(result);
            }
        }
        protected void SaveToLocalSource<T>(SearchCriterias.ISearchCriteriaFoundation foundation, IObservable<T> items)
        {
            if (Busy)
            {
                return;
            }

            // if we never loaded in the data, don't bother saving it
            if (items == null)
                return;

            Busy = true;

                // note we might want to do all this work on another thread in a real system
                var filename = GetFilename(foundation);

            List<T> col = new List<T>(items.ToEnumerable<T>());

            using (var iso = IsolatedStorageFile.GetUserStoreForApplication())
                {
                    try
                    {
                            if (iso.FileExists(filename))
                                iso.DeleteFile(filename);

                            IsoStoreCacheItem<T> item = new IsoStoreCacheItem<T>() { Data = col.ToArray(), Created = DateTime.Now };
                            using (IsolatedStorageFileStream file = iso.CreateFile(filename))
                            {
                                DataContractSerializer serializer = new DataContractSerializer(typeof(IsoStoreCacheItem<T>));
                                serializer.WriteObject(file, item);
                            }
                            Debug.WriteLine("entry written to cache");
                    }
                    catch (Exception ex)
                    {
                        // error, delete the file since we couldn't parse it correctly..
                        Debug.WriteLine(ex.Message);
                        iso.DeleteFile(filename);
                    }
                    finally
                    {
                        Busy = false;
                    }
                }
        }

        public bool Busy { get; set; }
    }
}