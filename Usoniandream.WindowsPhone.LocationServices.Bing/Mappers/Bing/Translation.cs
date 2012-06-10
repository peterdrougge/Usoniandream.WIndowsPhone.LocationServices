
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

namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Bing
{
    public class Translation : IMapper<Models.Bing.Translation, Models.JSON.Bing.Translation.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Bing.Translation> JSON2Model(Models.JSON.Bing.Translation.RootObject root)
        {
            if (root.SearchResponse.Query.SearchTerms.Contains(" | "))
            {
                List<string> query = new List<string>(root.SearchResponse.Query.SearchTerms.Replace(" | ", "|").Split('|'));
                List<string> result = new List<string>(root.SearchResponse.Translation.Results.FirstOrDefault().TranslatedTerm.Replace(" | ", "|").Split('|'));

                if (query.Count != result.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                for (int i = 0; i < query.Count; i++)
                {
                    yield return new Models.Bing.Translation()
                    {
                        To = result[i],
                        From = query[i]
                    };
                }
            }
            else
            {
                foreach (var item in root.SearchResponse.Translation.Results)
                {
                    yield return new Models.Bing.Translation()
                    {
                        To = item.TranslatedTerm,
                        From = root.SearchResponse.Query.SearchTerms
                    };
                }
            }
        }

        public System.Collections.Generic.IEnumerable<Models.Bing.Translation> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Bing.Translation.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Bing.Translation JSON2FirstModel(Models.JSON.Bing.Translation.RootObject root)
        {
            return new Models.Bing.Translation()
            {
                To = root.SearchResponse.Translation.Results.FirstOrDefault().TranslatedTerm,
                From = root.SearchResponse.Query.SearchTerms
            };
        }

        public Models.Bing.Translation JSON2LastModel(Models.JSON.Bing.Translation.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public Models.GenericPagedResultsContainer<Models.Bing.Translation> JSON2PagedContainer(Models.JSON.Bing.Translation.RootObject root)
        {
            throw new NotImplementedException();
        }
    }
}
