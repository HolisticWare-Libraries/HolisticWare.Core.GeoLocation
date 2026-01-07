    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Earth.EuclidianFlatEarth.PythagoreanFormulaParallelMeridians

namespace Core.GeoLocation;

public partial class
                                        Earth
{
    public partial class
                                        Spherical
    {
        /// <href="https://en.wikipedia.org/wiki/Haversine_formula" />
        /// <href="https://www.movable-type.co.uk/scripts/latlong-vincenty.html" />
        /// <href="https://gis.stackexchange.com/questions/4906/why-is-law-of-cosines-more-preferable-than-haversine-when-calculating-distance-b" />
        /// https://gis.stackexchange.com/questions/4906/why-is-law-of-cosines-more-preferable-than-haversine-when-calculating-distance-b
        /// 
        public partial class
                                        Distance
        {
            public partial class
                                        Haversine
            {
                /// <summary>
                /// 
                /// </summary>
                /// <param name="lat1"></param>
                /// <param name="lon1"></param>
                /// <param name="lat2"></param>
                /// <param name="lon2"></param>
                /// <returns></returns>
                /// https://www.movable-type.co.uk/scripts/latlong.html
                /// <href="https://github.com/xamarin/Essentials/blob/7218ab88f7fbe00ec3379bd54e6c0ce35ffc0c22/Xamarin.Essentials/Types/UnitConverters.shared.cs" />
                public static
                    double
                                        CalculateMAUI
                                        (
                                            double lat1,
                                            double lon1,
                                            double lat2,
                                            double lon2
                                        )
                {
                    if (lat1 == lat2 && lon1 == lon2)
                        return 0;

                    var dLat = Radian.FromDegrees(lat2 - lat1);
                    var dLon = Radian.FromDegrees(lon2 - lon1);

                    lat1 = Radian.FromDegrees(lat1);
                    lat2 = Radian.FromDegrees(lat2);

                    var dLat2 = Math.Sin(dLat / 2) * Math.Sin(dLat / 2);
                    var dLon2 = Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

                    var a = dLat2 + dLon2 * Math.Cos(lat1) * Math.Cos(lat2);
                    var c = 2 * Math.Asin(Math.Sqrt(a));

                    return 
                        //  meanEarth.RadiusInKilometers * c * 1000
                        Earth.Radius.Average * c
                        ;
                }
                
                public static
                    double
                                        CalculateMAUIOptimized
                                        (
                                            double lat1,
                                            double lon1,
                                            double lat2,
                                            double lon2
                                        )
                {
                    if (lat1 == lat2 && lon1 == lon2)
                        return 0;

                    var dLat = Radian.FromDegrees(lat2 - lat1);
                    var dLon = Radian.FromDegrees(lon2 - lon1);

                    var lat1_r = Radian.FromDegrees(lat1);
                    var lat2_r = Radian.FromDegrees(lat2);
                    var dlat2_half = dLat / 2.0;
                    var dlon2_half = dLon / 2.0;
                    var dLat2 = Math.Sin(dlat2_half) * Math.Sin(dlat2_half);
                    var dLon2 = Math.Sin(dlon2_half) * Math.Sin(dlon2_half);

                    var a = dLat2 + dLon2 * Math.Cos(lat1_r) * Math.Cos(lat2_r);
                    var c = 2.0 * Math.Asin(Math.Sqrt(a));

                    return 
                        //  meanEarth.RadiusInKilometers * c * 1000
                        Earth.Radius.Average * c
                        ;
                }

                public static
                    double
                                        CalculateMAUINonOptimized
                                        (
                                            double lat1,
                                            double lon1,
                                            double lat2,
                                            double lon2
                                        )
                {
                    if (lat1 == lat2 && lon1 == lon2)
                        return 0;

                    var dLat = Radian.FromDegrees(lat2 - lat1);
                    var dLon = Radian.FromDegrees(lon2 - lon1);

                    var lat1_r = Radian.FromDegrees(lat1);
                    var lat2_r = Radian.FromDegrees(lat2);
                    var dlat2_half = dLat / 2.0;
                    var dlon2_half = dLon / 2.0;
                    var dLat2 = Math.Sin(dlat2_half) * Math.Sin(dlat2_half);
                    var dLon2 = Math.Sin(dlon2_half) * Math.Sin(dlon2_half);

                    var a = dLat2 + dLon2 * Math.Cos(lat1_r) * Math.Cos(lat2_r);
                    var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1-a));

                    return 
                        //  meanEarth.RadiusInKilometers * c * 1000
                        Earth.Radius.Average * c
                        ;
                }

            public static
                double
                                        CalculateCopilotOptimized
                                        (
                                            double lat1,
                                            double lon1,
                                            double lat2,
                                            double lon2
                                        )
            {
                double dLat             = Radian.FromDegrees(lat2 - lat1);
                double dLon             = Radian.FromDegrees(lon2 - lon1);
                double dLat_2           = dLat / 2.0;
                double dLon_2           = dLon / 2.0;
                double sin_dlat_2       = Math.Sin(dLat_2);
                double sin_dlon_2       = Math.Sin(dLon_2);
                
                double a = 
                            sin_dlat_2 * sin_dlat_2 
                            +
                            // Math.Cos(lat1.ToRadians()) 
                            Math.Cos(Radian.FromDegrees(lat1)) 
                            * 
                            // Math.Cos(lat2.ToRadians()) 
                            Math.Cos(Radian.FromDegrees(lat2)) 
                            *
                            sin_dlon_2
                            * 
                            sin_dlon_2
                            ;

                double c = 
                            2.0 
                            * 
                            Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a))
                            ;

                double d = 
                            // Mean * c
                            Earth.Radius.Average * c
                            ;

                return d;        
            }

            public static
                double
                                        CalculateCopilot
                                        (
                                            double lat1,
                                            double lon1,
                                            double lat2,
                                            double lon2
                                        )
            {
                double dLat             = Radian.FromDegrees(lat2 - lat1);
                double dLon             = Radian.FromDegrees(lon2 - lon1);

                double a = 
                        Math.Sin(dLat / 2.0) * Math.Sin(dLat / 2.0) 
                        +
                        // Math.Cos(lat1.ToRadians()) * Math.Cos(lat2.ToRadians()) *
                        Math.Cos(Radian.FromDegrees(lat1)) 
                        * 
                        Math.Cos(Radian.FromDegrees(lat2)) 
                        *
                        Math.Sin(dLon / 2.0) 
                        * 
                        Math.Sin(dLon / 2.0)
                        ;
                double c = 2.0 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
                double d = 
                            // Mean * c
                            Earth.Radius.Average * c
                            ;

                return d;        
            }


            public static
                double
                                        Calculate3
                                        (
                                            double lat1,
                                            double lon1,
                                            double lat2,
                                            double lon2
                                        )
            {
                double dlong = (lon2 - lon1) * Radian.FactorInverse;
                double dlat = (lat2 - lat1) * Radian.FactorInverse;
                double a = 
                            Math.Pow(Math.Sin(dlat / 2.0), 2.0) 
                            + 
                            Math.Cos(lat1 * Radian.FactorInverse) 
                            *
                            Math.Cos(lat2 * Radian.FactorInverse) 
                            * 
                            Math.Pow(Math.Sin(dlong / 2.0), 2.0)
                            ;
                double c = 2D * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1D - a));
                double d = 
                            // _eQuatorialEarth.Radius * c
                            Earth.Radius.Equatorial * c
                            ;

                return d;
            }

            public static
                double
                                        Calculate4
                                        (
                                            double lat1,
                                            double lon1,
                                            double lat2,
                                            double lon2
                                        )
            {
                double a = 
                        0.5 
                        - 
                        Math.Cos((lat2 - lat1) * Radian.FactorInverse) / 2.0
                        + 
                        Math.Cos(lat1 * Radian.FactorInverse) 
                        * 
                        Math.Cos(lat2 * Radian.FactorInverse) 
                        *
                        (1 - Math.Cos((lon2 - lon1) * Radian.FactorInverse)) / 2.0
                        ;

                return 2.0 * Earth.Radius.Average * Math.Asin(Math.Sqrt(a));
            }
            }
        }
    }
}