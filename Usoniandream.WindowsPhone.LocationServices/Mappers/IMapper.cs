﻿//
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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Usoniandream.WindowsPhone.LocationServices.Mappers
{
    /// <summary>
    /// Mapper interface used to define converters from json to model
    /// </summary>
    /// <typeparam name="Ttarget">The type of the target.</typeparam>
    /// <typeparam name="Tsource">The type of the source.</typeparam>
    public interface IMapper<Ttarget, Tsource> : IDisposable
    {
        IEnumerable<Ttarget> JSON2Model(Tsource root);
        IEnumerable<Ttarget> JSON2Model(IEnumerable<Tsource> root);
        Ttarget JSON2FirstModel(Tsource root);
        Ttarget JSON2LastModel(Tsource root);
        Models.GenericPagedResultsContainer<Ttarget> JSON2PagedContainer(Tsource root);
    }
}
