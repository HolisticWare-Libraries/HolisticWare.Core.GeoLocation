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
        public partial class
                                        Distance
        {
            public partial class
                                        LawOfCosines
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
                /// 
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
                    double lat1_r = Radian.FromDegrees( lat1 );
                    double lat2_r = Radian.FromDegrees( lat2 );
                    double delta_lon_r = Radian.FromDegrees( (lon2 - lon1) );
                    double d =
                                Math.Acos
                                        (
                                            Math.Sin(lat1_r) * Math.Sin(lat2_r)
                                            +
                                            Math.Cos(lat1_r) * Math.Cos(lat2_r) 
                                            * 
                                            Math.Cos(delta_lon_r)
                                        )
                                        *
                                        Earth.Radius.Average;
                                        ;

                    return d;
                }
            }
        }
    }
}