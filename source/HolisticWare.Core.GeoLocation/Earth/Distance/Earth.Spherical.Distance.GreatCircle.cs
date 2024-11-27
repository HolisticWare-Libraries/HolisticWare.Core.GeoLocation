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
                                        GreatCircle
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
                    double lat1_r = Radian.FromDegrees(lat1);
                    double lat2_r = Radian.FromDegrees(lat2);
                    double lat_r = Radian.FromDegrees(lat1 -lat2);
                    double lon_r = Radian.FromDegrees(lon1 -lon2);

                    double a = lon_r * Math.Cos( (lat1_r + lat2_r) * 0.5 );
                    double central_angle = Math.Sqrt( a * a + lat_r * lat_r);

                    double d = Earth.Radius.Mean * central_angle;

                    return d;
                }
            }
        }
    }
}