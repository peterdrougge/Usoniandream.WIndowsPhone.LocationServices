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

namespace Usoniandream.WindowsPhone.GeoConverter.Positions
{
    /*
     * MightyLittleGeodesy - Björn Sållarp 2009
     * 
     * RT90, SWEREF99 and WGS84 coordinate transformation library
     * 
     * 
     * Read my blog @ http://blog.sallarp.com
     * 
     * License: http://creativecommons.org/licenses/by-nc-sa/3.0/
     */
    public enum Grid
    {
        RT90 = 0,
        WGS84 = 1,
        SWEREF99 = 2
    }

    public abstract class Position
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Grid GridFormat { get; set; }

        public Position(double lat, double lon, Grid format)
        {
            Latitude = lat;
            Longitude = lon;
            GridFormat = format;
        }

        public Position(Grid format)
        {
            GridFormat = format;
        }
    }
}
