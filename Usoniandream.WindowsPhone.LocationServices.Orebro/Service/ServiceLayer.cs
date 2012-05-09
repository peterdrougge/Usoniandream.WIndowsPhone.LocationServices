
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
using RestSharp;

namespace Usoniandream.WindowsPhone.LocationServices.Service.Orebro
{
    public class ServiceLayer : GenericServiceLayer
    {
        /// <summary>
        /// Gets the baths.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetBaths(SearchCriterias.Orebro.Baths criteria, Action<IRestResponse<Models.JSON.Orebro.OrebroJSONModel.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Orebro.Bath, Models.JSON.Orebro.OrebroJSONModel.RootObject>(criteria, callback);
        }
        /// <summary>
        /// Gets the parkings.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetParkings(SearchCriterias.Orebro.Parkings criteria, Action<IRestResponse<Models.JSON.Orebro.OrebroJSONModel.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Orebro.Parking, Models.JSON.Orebro.OrebroJSONModel.RootObject>(criteria, callback);
        }
        /// <summary>
        /// Gets the parks.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetParks(SearchCriterias.Orebro.Parks criteria, Action<IRestResponse<Models.JSON.Orebro.OrebroJSONModel.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Orebro.Park, Models.JSON.Orebro.OrebroJSONModel.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Gets the recycling.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetRecycling(SearchCriterias.Orebro.Recycling criteria, Action<IRestResponse<Models.JSON.Orebro.OrebroJSONModel.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Orebro.Recycling, Models.JSON.Orebro.OrebroJSONModel.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Gets the libraries.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetLibraries(SearchCriterias.Orebro.Libraries criteria, Action<IRestResponse<Models.JSON.Orebro.OrebroJSONModel.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Orebro.Library, Models.JSON.Orebro.OrebroJSONModel.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Gets the recycling centrals.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetRecyclingCentrals(SearchCriterias.Orebro.RecyclingCentrals criteria, Action<IRestResponse<Models.JSON.Orebro.OrebroJSONModel.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Orebro.RecyclingCentral, Models.JSON.Orebro.OrebroJSONModel.RootObject>(criteria, callback);
        }

        /// <summary>
        /// Gets the preschools.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="callback">The callback.</param>
        public void GetPreSchools(SearchCriterias.Orebro.PreSchools criteria, Action<IRestResponse<Models.JSON.Orebro.OrebroJSONModel.RootObject>> callback)
        {
            ExecuteRequestForCallback<Models.Orebro.PreSchools, Models.JSON.Orebro.OrebroJSONModel.RootObject>(criteria, callback);
        }
    }
}
