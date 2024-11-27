using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.GeoLocation;
/// <summary>
/// 
/// </summary>
/// <href>https://en.wikipedia.org/wiki/Earth_radius</href>
/// <href>https://www.physics.unlv.edu/~jeffery/astro/earth/earth_oblate_spheroid.html</href>
/// <href>https://www.jpz.se/Html_filer/wgs_84.html</href>
/// <href>https://nssdc.gsfc.nasa.gov/planetary/factsheet/earthfact.html</href>
public partial class  
                                        Earth
                                        
{
    public partial class
                                        Radius
    {
        public static 
            double 
                                        Mean
        {
            get;
            set;
        }                               = 6371008.8;

        public static 
            double 
                                        Equatorial
        {
            get;
            set;
        }                               = 6378137.0;

        public static 
            double 
                                        Maximum
        {
            get;
            set;
        }                               = 6378137.0;

        public static 
            double 
                                        Polar
        {
            get;
            set;
        }                               = 6356752.3;

        public static 
            double 
                                        Minimum
        {
            get;
            set;
        }                               = 6356752.3;

        public static 
            double 
                                        Average
        {
            get;
            set;
        }                               = 6371008.8;

        public static 
            double 
                                        AverageKilometers
        {
            get;
            set;
        }                               = 6371.0088;

        public static 
            double 
                                        Flattening
        {
            get;
            set;
        }                               = 1.0 / 298.257223563;

        public static
            Func<double, double>
                                        AtLatitudeCalculation
                                        = Calculate
                                        ;

        /// <summary>
        /// Geocentric radius
        /// </summary>
        /// <param name="latitude"></param>
        /// <returns></returns> <summary>
        /// 
        /// </summary>
        /// <param name="latitude"></param>
        /// <returns>
        ///  </returns>
        /// <href>https://en.wikipedia.org/wiki/Earth_radius</href>
        /// <href>https://rechneronline.de/earth-radius/</href>
        /// <href>https://planetcalc.com/7721/</href>
        /// <href>https://www.fxsolver.com/solve/</href>
        public static 
            double
                                        AtLatitude
                                        (
                                            double latitude
                                        )
        {
            return AtLatitudeCalculation(latitude);
        }

        public static 
            double
                                        Calculate
                                        (
                                            double latitude
                                        )
        {
            double a = Earth.Radius.Equatorial;
            double b = Earth.Radius.Polar;
            double latitude_radians = Radian.FromDegrees(latitude);
            double math_cos_latitude = Math.Cos(latitude_radians);
            double math_sin_latitude = Math.Sin(latitude_radians);

            double fraction = 
                                (
                                    ( a * a * math_cos_latitude ) * ( a * a * math_cos_latitude )
                                    +
                                    ( b * b * math_sin_latitude ) * ( b * b * math_sin_latitude )
                                )
                                /
                                (
                                    ( a * math_cos_latitude ) * ( a * math_cos_latitude )
                                    +
                                    ( b * math_sin_latitude ) * ( b * math_sin_latitude )
                                )
                                ;
            double r = Math.Sqrt(fraction);

            return r;
        }

        public static 
            double
                                        Calculate2
                                        (
                                            double latitude
                                        )
        {
            double r = 
                        Radius.Polar 
                        + 
                        ( 90.0 - Math.Abs(latitude) ) 
                        /
                        90.0 * (Radius.Equatorial - Radius.Polar)
                        ; 

            return r;
        }
    }
}
