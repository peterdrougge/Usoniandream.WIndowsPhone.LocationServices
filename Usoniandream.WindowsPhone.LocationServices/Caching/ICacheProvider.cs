
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
using System.Collections.ObjectModel;

namespace Usoniandream.WindowsPhone.LocationServices.Caching
{
    /// <summary>
    /// Cache Provider interface
    /// </summary>
    public interface ICacheProvider
    {
        /// <summary>
        /// Determines whether the specified cache is valid.
        /// </summary>
        /// <param name="foundation">The criteria.</param>
        /// <returns>
        ///   <c>true</c> if the specified cache is valid; otherwise, <c>false</c>.
        /// </returns>
        bool IsValid<T>(SearchCriterias.ISearchCriteriaFoundation foundation, int duration);
        /// <summary>
        /// Determines whether the specified criteria is cached.
        /// </summary>
        /// <param name="foundation">The criteria.</param>
        /// <returns>
        ///   <c>true</c> if the specified criteria is cached; otherwise, <c>false</c>.
        /// </returns>
        bool IsCached(SearchCriterias.ISearchCriteriaFoundation foundation);
        /// <summary>
        /// Removes the specified cache.
        /// </summary>
        /// <param name="foundation">The criteria.</param>
        void Remove(SearchCriterias.ISearchCriteriaFoundation foundation);
        /// <summary>
        /// Replaces the specified cached foundation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="foundation">The foundation.</param>
        /// <param name="result">The result.</param>
        void Replace<T>(SearchCriterias.ISearchCriteriaFoundation foundation, IObservable<T> result);
        /// <summary>
        /// Adds the specified criteria result to cache.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="foundation">The criteria.</param>
        /// <param name="result">The result.</param>
        void Add<T>(SearchCriterias.ISearchCriteriaFoundation foundation, IObservable<T> result);
        /// <summary>
        /// Gets the cached data.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="foundation">The criteria.</param>
        /// <returns></returns>
        IObservable<T> GetCachedData<T>(SearchCriterias.ISearchCriteriaFoundation foundation);
    }
}
