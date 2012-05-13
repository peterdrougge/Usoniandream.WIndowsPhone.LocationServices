
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
// The code in this class is originally created by Andrius Bentkus and taken from https://gist.github.com/1095252 
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

namespace Usoniandream.WindowsPhone.LocationServices.Extensions
{
    public class Epoch
    {
        static readonly DateTime epochStart = new DateTime(1970, 1, 1, 0, 0, 0);

        static readonly DateTimeOffset epochDateTimeOffset = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);

        public static DateTime FromUnix(int secondsSinceepoch)
        {
            return epochStart.AddSeconds(secondsSinceepoch);
        }

        public static DateTimeOffset FromUnix(int secondsSinceEpoch, int timeZoneOffsetInMinutes)
        {
            var utcDateTime = epochDateTimeOffset.AddSeconds(secondsSinceEpoch);
            var offset = TimeSpan.FromMinutes(timeZoneOffsetInMinutes);
            return new DateTimeOffset(utcDateTime.DateTime.Add(offset), offset);
        }

        public static int ToUnix(DateTime dateTime)
        {
            return (int)(dateTime - epochStart).TotalSeconds;
        }

        public static int Now
        {
            get
            {
                return (int)(DateTime.UtcNow - epochStart).TotalSeconds;
            }
        }
    }
    public static class DateTimeExtensions
    {
        public static int ToUnix(this DateTime dateTime)
        {
            return Epoch.ToUnix(dateTime);
        }

        public static DateTime FromUnix(this int secondsSinceEpoch)
        {
            return Epoch.FromUnix(secondsSinceEpoch);
        }

        public static DateTimeOffset FromUnix(this int secondsSinceEpoch, int timeZoneOffsetInMinutes)
        {
            return Epoch.FromUnix(secondsSinceEpoch, timeZoneOffsetInMinutes);
        }
    }
}
