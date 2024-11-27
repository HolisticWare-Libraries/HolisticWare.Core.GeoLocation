using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Earth.EuclidianFlatEarth.PythagoreanFormulaParallelMeridians

namespace Core.GeoLocation;

public partial class
                                        Earth
{
    /// <summary>
    /// 
    /// </summary>
    /// https://en.wikipedia.org/wiki/Euclidean_distance
    /// https://en.wikipedia.org/wiki/Geographical_distance
    public partial class
                                        EuclidianPlanarFlatEarth
    {
        public partial class
                                        Distance
        {
            public partial class
                                        PythagoreanFormulaParallelMeridians
                                        
            {
                public static
                    double
                                        CalculateSphericalProjectionToPlane
                                        (
                                            double phi_lat1,
                                            double lmb_lon1,
                                            double phi_lat2,
                                            double lmb_lon2
                                        )
                {
                    double delta_phi_lat    = Radian.FromDegrees(phi_lat2 - phi_lat1);
                    double delta_lmb_lon    = Radian.FromDegrees(lmb_lon2 - lmb_lon1);
                    double mean_phi_lat     = Radian.FromDegrees((phi_lat1 + phi_lat2) * 0.5);
                    double cos_mean_phi_lat = Math.Cos(mean_phi_lat);

                    // double tht_colatitude1   = 0.5 * Math.PI - phi_lat;

                    double lhs = delta_phi_lat * delta_phi_lat;
                    double rhs = delta_lmb_lon * cos_mean_phi_lat;
                    double R = Earth.Radius.Average;

                    double D =
                                R
                                *
                                Math.Sqrt
                                    (
                                        lhs * lhs
                                        +
                                        rhs * rhs
                                    );

                    return D;
                }

                public static
                    double
                                        CalculateWithRadiusAtLatitude
                                        (
                                            double phi_lat1,
                                            double lmb_lon1,
                                            double phi_lat2,
                                            double lmb_lon2
                                        )
                {
                    double delta_phi_lat    = Radian.FromDegrees(phi_lat2 - phi_lat1);
                    double delta_lmb_lon    = Radian.FromDegrees(lmb_lon2 - lmb_lon1);
                    double mean_phi_lat     = Radian.FromDegrees((phi_lat1 + phi_lat2) * 0.5);
                    double cos_mean_phi_lat = Math.Cos(mean_phi_lat);

                    // double tht_colatitude1   = 0.5 * Math.PI - phi_lat;

                    double lhs = delta_phi_lat * delta_phi_lat;
                    double rhs = delta_lmb_lon * cos_mean_phi_lat;
                    double R = Earth.Radius.AtLatitude(phi_lat1);

                    double D =
                                R
                                *
                                Math.Sqrt
                                    (
                                        lhs * lhs
                                        +
                                        rhs * rhs
                                    );

                    return D;
                }
            }
        }
    }
}