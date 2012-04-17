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
using System.Device.Location;

namespace Usoniandream.WindowsPhone.Extensions
{
    public static class GeoHelper
    {
        private static GeoCoordinateWatcher watcher;
        public static GeoCoordinateWatcher Watcher 
        { 
            get
            {
                if (watcher == null)
                {
                    watcher = new GeoCoordinateWatcher( GeoPositionAccuracy.High);
                }
                return watcher;
            }
        }


        public static bool IsCoordinatesValid(double latitude, double longitude)
        {
            if (latitude!=null && longitude!=null)
            {
                try
                {
                    GeoCoordinate gc = new GeoCoordinate(latitude, longitude);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

        public static bool Start()
        {
            if (watcher.Status!=GeoPositionStatus.Initializing && watcher.Status!=GeoPositionStatus.Ready)
            {
                return watcher.TryStart(false, new TimeSpan(0,0,30));
            }
            return true;
        }
        public static void Stop()
        {
            watcher.Stop();
        }
    }
}
