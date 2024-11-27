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
        /// <summary>
        /// 
        /// </summary>
        /// https://stackoverflow.com/questions/66716361/gps-distance-pythagoras-on-an-equirectangular-approximation-vs-haversine-fomul
        /// https://blog.mapbox.com/fast-geodesic-approximations-with-cheap-ruler-106f229ad016
        /// https://stackoverflow.com/questions/27231148/equirectangular-approximation-in-php
        /// 
        public partial class
                                        Distance
        {
            public partial class
                                        EquirectangularPytagoras
                                        
            {
                public static
                    double
                                        Calculate
                                        (
                                            double lat1,
                                            double lon1,
                                            double lat2,
                                            double lon2
                                        )
                {
                    double lat1_r = Radian.FromDegrees( lat1 ); // φ, λ in radians
                    double lat2_r = Radian.FromDegrees( lat2 );
                    // double λ1 = lon1; 
                    // double λ2 = lon2;
                    //double Δφ = Radian.FromDegrees( (lat2-lat1) );
                    //double Δλ = Radian.FromDegrees( (lon2-lon1) );

                    double x = 
                                Radian.FromDegrees( lon2 - lon1 ) 
                                * 
                                Math.Cos( ( lat1_r + lat2_r ) * 0.5 )
                                ;
                    double y =  Radian.FromDegrees( lat2 - lat1 );
                    double d = Math.Sqrt( x * x + y * y ) * Earth.Radius.Average;

                    return d;
                }
            }
        }
    }
}