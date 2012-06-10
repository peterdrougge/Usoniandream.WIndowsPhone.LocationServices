
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
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Usoniandream.WindowsPhone.LocationServices.Service.Eniro.Reactive
{
    public class ServiceLayer : LocationServices.Service.Reactive.GenericServiceLayer
    {
        public IObservable<Models.Eniro.Company> SearchCompanies(SearchCriterias.Eniro.CompanySearch criteria, int maxhits, int pagesize)
        {
            ObservableCollection<Models.Eniro.Company> list = new ObservableCollection<Models.Eniro.Company>();
            var pagedresult = ExecuteRequestReturnPagedObservable<Models.Eniro.Company, Models.JSON.Eniro.CompanySearch.RootObject>(criteria);

            if (pagedresult.FirstOrDefault().HasMorePages && criteria.AutoFillToMaxLimit)
            {
                var observable = Observable.Generate(1,
                                                     x => x < maxhits,
                                                     x => x + pagesize,
                                                     x => x);

                observable
                    .ForEach(i =>
                    {
                        criteria.From = i;
                        criteria.To = i + (pagesize-1);
                        ExecuteRequestReturnObservable<Models.Eniro.Company, Models.JSON.Eniro.CompanySearch.RootObject>(criteria)
                        .Subscribe(
                            // result
                            x =>
                            {
                                list.Add(x);
                            },
                            // exception
                            ex =>
                            {
                                Debug.WriteLine(ex.Message);
                            });
                    }
                );
            }

            return list.ToObservable();
        }

        public IObservable<Models.Eniro.Company> SearchCompaniesByRadius(SearchCriterias.Eniro.CompanySearchByRadius criteria)
        {
            return ExecuteRequestReturnObservable<Models.Eniro.Company, Models.JSON.Eniro.CompanySearch.RootObject>(criteria);
        }
    
public  int fetchcount { get; set; }}
}
