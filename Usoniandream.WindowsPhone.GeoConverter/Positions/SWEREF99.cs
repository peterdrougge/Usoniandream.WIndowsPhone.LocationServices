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
    public class SWEREF99 : Position
    {
        public enum SWEREFProjection
        {
            sweref_99_tm = 0,
            sweref_99_12_00 = 1,
            sweref_99_13_30 = 2,
            sweref_99_15_00 = 3,
            sweref_99_16_30 = 4,
            sweref_99_18_00 = 5,
            sweref_99_14_15 = 6,
            sweref_99_15_45 = 7,
            sweref_99_17_15 = 8,
            sweref_99_18_45 = 9,
            sweref_99_20_15 = 10,
            sweref_99_21_45 = 11,
            sweref_99_23_15 = 12
        }

        /// <summary>
        /// Create a Sweref99 position from double values with 
        /// Sweref 99 TM as default projection.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="e"></param>
        public SWEREF99(double n, double e)
            : base(n, e, Grid.SWEREF99)
        {
            Projection = SWEREFProjection.sweref_99_tm;
        }

        /// <summary>
        /// Create a Sweref99 position from double values. Supply the projection
        /// for values other than Sweref 99 TM
        /// </summary>
        /// <param name="n"></param>
        /// <param name="e"></param>
        /// <param name="projection"></param>
        public SWEREF99(double n, double e, SWEREFProjection projection)
            : base(n, e, Grid.SWEREF99)
        {
            Projection = projection;
        }

        /// <summary>
        /// Create a RT90 position by converting a WGS84 position
        /// </summary>
        /// <param name="position">WGS84 position to convert</param>
        /// <param name="rt90projection">Projection to convert to</param>
        public SWEREF99(WGS84 position, SWEREFProjection projection)
            : base(Grid.SWEREF99)
        {
            GaussKreuger gkProjection = new GaussKreuger();
            gkProjection.swedish_params(GetProjectionString(projection));
            var lat_lon = gkProjection.geodetic_to_grid(position.Latitude, position.Longitude);
            Latitude = lat_lon[0];
            Longitude = lat_lon[1];
            Projection = projection;
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


        private string GetProjectionString(SWEREFProjection projection)
        {
            string retVal = string.Empty;
            switch (projection)
            {
                case SWEREFProjection.sweref_99_tm:
                    retVal = "sweref_99_tm";
                    break;
                case SWEREFProjection.sweref_99_12_00:
                    retVal = "sweref_99_1200";
                    break;
                case SWEREFProjection.sweref_99_13_30:
                    retVal = "sweref_99_1330";
                    break;
                case SWEREFProjection.sweref_99_14_15:
                    retVal = "sweref_99_1415";
                    break;
                case SWEREFProjection.sweref_99_15_00:
                    retVal = "sweref_99_1500";
                    break;
                case SWEREFProjection.sweref_99_15_45:
                    retVal = "sweref_99_1545";
                    break;
                case SWEREFProjection.sweref_99_16_30:
                    retVal = "sweref_99_1630";
                    break;
                case SWEREFProjection.sweref_99_17_15:
                    retVal = "sweref_99_1715";
                    break;
                case SWEREFProjection.sweref_99_18_00:
                    retVal = "sweref_99_1800";
                    break;
                case SWEREFProjection.sweref_99_18_45:
                    retVal = "sweref_99_1845";
                    break;
                case SWEREFProjection.sweref_99_20_15:
                    retVal = "sweref_99_2015";
                    break;
                case SWEREFProjection.sweref_99_21_45:
                    retVal = "sweref_99_2145";
                    break;
                case SWEREFProjection.sweref_99_23_15:
                    retVal = "sweref_99_2315";
                    break;
                default:
                    retVal = "sweref_99_tm";
                    break;
            }

            return retVal;
        }

        public SWEREFProjection Projection { get; set; }
        public string ProjectionString
        {
            get
            {
                return GetProjectionString(Projection);
            }
        }

        public override string ToString()
        {
            return string.Format("N: {0} E: {1} Projection: {2}", Latitude, Longitude, ProjectionString);
        }
    }
}
