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
using Usoniandream.WindowsPhone.GeoConverter.Projections;

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
    public class RT90 : Position
    {
        public enum RT90Projection
        {
            rt90_7_5_gon_v = 0,
            rt90_5_0_gon_v = 1,
            rt90_2_5_gon_v = 2,
            rt90_0_0_gon_v = 3,
            rt90_2_5_gon_o = 4,
            rt90_5_0_gon_o = 5
        }

        /// <summary>
        /// Create a new position using default projection (2.5 gon v);
        /// </summary>
        /// <param name="x">X value</param>
        /// <param name="y">Y value</param>
        public RT90(double x, double y)
            : base(x, y, Grid.RT90)
        {
            Projection = RT90Projection.rt90_2_5_gon_v;
        }

        /// <summary>
        /// Create a new position
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="projection"></param>
        public RT90(double x, double y, RT90Projection projection)
            : base(x, y, Grid.RT90)
        {
            Projection = projection;
        }

        /// <summary>
        /// Create a RT90 position by converting a WGS84 position
        /// </summary>
        /// <param name="position">WGS84 position to convert</param>
        /// <param name="rt90projection">Projection to convert to</param>
        public RT90(WGS84 position, RT90Projection rt90projection)
            : base(Grid.RT90)
        {
            GaussKreuger gkProjection = new GaussKreuger();
            gkProjection.swedish_params(GetProjectionString(rt90projection));
            var lat_lon = gkProjection.geodetic_to_grid(position.Latitude, position.Longitude);
            Latitude = lat_lon[0];
            Longitude = lat_lon[1];
            Projection = rt90projection;
        }



        /// <summary>
        /// Convert the position to WGS84 format
        /// </summary>
        /// <returns></returns>
        public WGS84 ToWGS84()
        {
            GaussKreuger gkProjection = new GaussKreuger();
            gkProjection.swedish_params(ProjectionString);
            var lat_lon = gkProjection.grid_to_geodetic(Latitude, Longitude);

            WGS84 newPos = new WGS84()
            {
                Latitude = lat_lon[0],
                Longitude = lat_lon[1],
                GridFormat = Grid.WGS84
            };

            return newPos;
        }

        private string GetProjectionString(RT90Projection projection)
        {
            string retVal = string.Empty;
            switch (projection)
            {
                case RT90Projection.rt90_7_5_gon_v:
                    retVal = "rt90_7.5_gon_v";
                    break;
                case RT90Projection.rt90_5_0_gon_v:
                    retVal = "rt90_5.0_gon_v";
                    break;
                case RT90Projection.rt90_2_5_gon_v:
                    retVal = "rt90_2.5_gon_v";
                    break;
                case RT90Projection.rt90_0_0_gon_v:
                    retVal = "rt90_0.0_gon_v";
                    break;
                case RT90Projection.rt90_2_5_gon_o:
                    retVal = "rt90_2.5_gon_o";
                    break;
                case RT90Projection.rt90_5_0_gon_o:
                    retVal = "rt90_5.0_gon_o";
                    break;
                default:
                    retVal = "rt90_2.5_gon_v";
                    break;
            }

            return retVal;
        }

        public RT90Projection Projection { get; set; }
        public string ProjectionString
        {
            get
            {
                return GetProjectionString(Projection);
            }
        }

        public override string ToString()
        {
            return string.Format("X: {0} Y: {1} Projection: {2}", Latitude, Longitude, ProjectionString);
        }
    }
}
