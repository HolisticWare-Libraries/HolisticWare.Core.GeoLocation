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
                                        EuclidianPlanarFlatEarth
    {
        public partial class
                                        Distance
        {
            public partial class
                                        PythagoreanFormulaConverginglMeridians
            {                    
                public static
                    double
                                        Calculate
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

                    // double tht_colatitude1   = 0.5 * Math.PI - phi_lat;

                    double cos_mean_phi_lat = Math.Cos(mean_phi_lat);

                    double D = 
                                Earth.Radius.Average
                                *
                                Math.Sqrt
                                    (
                                        delta_phi_lat * delta_phi_lat
                                        + 
                                        delta_lmb_lon * cos_mean_phi_lat 
                                        * 
                                        delta_lmb_lon * cos_mean_phi_lat
                                    );

                    return D;
                }
            }        
        }        
    }
}