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
namespace Usoniandream.WindowsPhone.LocationServices.Models.Stockholm.Base
{
    public interface IDetailedServiceUnit : ILocation
    {
        string Contact { get; set; }
        string ContactEmail { get; set; }
        string ContactPhone { get; set; }
        string Description { get; set; }
        string GeographicalArea { get; set; }
        string ID { get; set; }
        string ImageId { get; set; }
        string PhoneNumber { get; set; }
        string ShortDescription { get; set; }
        string StreetAddress { get; set; }
    }
}
