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
                                        Ellipsoidal
    {
        /// <href="https://www.movable-type.co.uk/scripts/latlong-vincenty.html" />
        /// <href="https://gis.stackexchange.com/questions/4906/why-is-law-of-cosines-more-preferable-than-haversine-when-calculating-distance-b" />
        /// <href="https://gist.github.com/jhmt/f57c44139cf09a532c7efa60c6158913" />
        /// <href="https://en.wikipedia.org/wiki/Vincenty%27s_formulae" />
        /// <href="https://gist.github.com/jhmt/f57c44139cf09a532c7efa60c6158913" />
        /// <href="https://medium.com/@herihermawan/comparing-the-haversine-and-vincenty-algorithms-for-calculating-great-circle-distance-5a2165857666" />
        /// https://www.neovasolutions.com/2019/10/04/haversine-vs-vincenty-which-is-the-best/
        /// 
        public partial class
                                        Distance
        {
            public partial class
                                        Vincenty
                                        
            {
                /// <summary>
                /// 
                /// </summary>
                /// <param name="lat1"></param>
                /// <param name="lon1"></param>
                /// <param name="lat2"></param>
                /// <param name="lon2"></param>
                /// <returns></returns>
                /// <href="https://en.wikipedia.org/wiki/Vincenty%27s_formulae" />
                /// <href="https://medium.com/@herihermawan/comparing-the-haversine-and-vincenty-algorithms-for-calculating-great-circle-distance-5a2165857666"
                public static
                    double
                                        CalculateHeriHermawan
                                        (
                                            double lat1,
                                            double lon1,
                                            double lat2,
                                            double lon2
                                        )
                {
                    double lat1rad             = Radian.FromDegrees(lat1);
                    double lat2rad             = Radian.FromDegrees(lat2);
                    double lon1rad             = Radian.FromDegrees(lon1);
                    double lon2rad             = Radian.FromDegrees(lon2);

                    double dlat = lat2rad - lat1rad;
                    double dlon = lon2rad - lon1rad;

                    double a =
                                Math.Sin(dlat / 2) * Math.Sin(dlat / 2)
                                +
                                Math.Cos(lat1rad) * Math.Cos(lat2rad) * Math.Sin(dlon / 2) * Math.Sin(dlon / 2)
                                ;
                    double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

                    // Calculate the ellipsoid parameters
                    double b = 
                                (1 - Earth.Radius.Flattening) 
                                * 
                                // Earth.Radius.Average             // semi-minor axis of the Earth's ellipsoid
                                                                    // error in article using 6371 which is average radius
                                                                    // 
                                Earth.Radius.Equatorial
                                ;
                    double d = c * b;

                    return d;
                }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="lat1"></param>
                /// <param name="lon1"></param>
                /// <param name="lat2"></param>
                /// <param name="lon2"></param>
                /// <param name="max_iterations"></param>
                /// <param name="tolerance"></param>
                /// <returns></returns>
                /// <href="https://en.wikipedia.org/wiki/Vincenty%27s_formulae" />
                /// <href="https://nathanrooy.github.io/posts/2016-12-18/vincenty-formula-with-python/" />
                /// <href="https://en.wikipedia.org/wiki/Vincenty%27s_formulae" />
                /// <href="https://nathanrooy.github.io/posts/2016-12-18/vincenty-formula-with-python/" />
                public static
                    double
                                        CalculateIterativeNathanRooyArticle
                                        (
                                            double lat1,
                                            double lon1,
                                            double lat2,
                                            double lon2,
                                            int max_iterations = 200,
                                            double tolerance = 10e-12
                                        )
                {
                    double a = Earth.Radius.Equatorial;
                    double f = Earth.Radius.Flattening;
                    double b = (1 - f) * a;
                    
                    double phi_1 = lat1;
                    double L_1 = lon1;
                    double phi_2 = lat2;
                    double L_2 = lon2;

                    double u_1 = Math.Atan((1 - f) * Math.Tan(Radian.FromDegrees(phi_1)));
                    double u_2 = Math.Atan((1 - f) * Math.Tan(Radian.FromDegrees(phi_2)));

                    double L = Radian.FromDegrees(L_2 - L_1);

                    double sin_u1 = Math.Sin(u_1);
                    double cos_u1 = Math.Cos(u_1);
                    double sin_u2 = Math.Sin(u_2);
                    double cos_u2 = Math.Cos(u_2);

                    double Lambda = L;                  // # set initial value of lambda to L

                    double cos_sigma = 0;
                    double cos_sq_alpha = 0;
                    double sigma = 0;
                    double sin_sigma = 0;
                    double cos2_sigma_m = 0;
                    
                    int iterations = 0;
                    while (iterations < max_iterations)
                    {
                        iterations++;

                        double cos_lambda = Math.Cos(Lambda);
                        double sin_lambda = Math.Sin(Lambda);
                        sin_sigma = Math.Sqrt
                                            (
                                                (cos_u2 * Math.Sin(Lambda)) 
                                                * 
                                                (cos_u2 * Math.Sin(Lambda)) 
                                                +
                                                (cos_u1 * sin_u2 - sin_u1 * cos_u2 * cos_lambda) 
                                                * 
                                                (cos_u1 * sin_u2 - sin_u1 * cos_u2 * cos_lambda)
                                            );
                        cos_sigma = sin_u1 * sin_u2 + cos_u1 * cos_u2 * cos_lambda;
                        sigma = Math.Atan2(sin_sigma, cos_sigma);
                        double sin_alpha = (cos_u1 * cos_u2 * sin_lambda) / sin_sigma;
                        cos_sq_alpha = 1 - sin_alpha * sin_alpha;
                        cos2_sigma_m = cos_sigma - ((2 * sin_u1 * sin_u2) / cos_sq_alpha);
                        double C = 
                                    (Earth.Radius.Flattening / 16) 
                                    * 
                                    cos_sq_alpha 
                                    * 
                                    (4 + Earth.Radius.Flattening * (4 - 3 * cos_sq_alpha))
                                    ;
                        double Lambda_prev = Lambda;
                        Lambda = 
                                    L 
                                    + 
                                    (1 - C) * Earth.Radius.Flattening * sin_alpha 
                                    *
                                    (
                                        sigma 
                                        + 
                                        C * sin_sigma 
                                        * 
                                        (
                                            cos2_sigma_m 
                                            + 
                                            C * cos_sigma * (-1 + 2 * cos2_sigma_m * cos2_sigma_m)
                                        )
                                    );

                        // successful convergence
                        double diff = Math.Abs(Lambda_prev - Lambda);
                        if (diff <= tolerance)
                        {
                            break;
                        }
                    }

                    double b_squared = b * b;
                    double u_sq = cos_sq_alpha * ((a * a - b_squared) / b_squared);
                    double A =
                                1
                                +
                                (u_sq / 16384)
                                * 
                                (
                                    4096 
                                    + 
                                    u_sq 
                                    *
                                    (
                                        -768 + u_sq * (320 - 175 * u_sq)
                                    )
                                );
                    double B =
                                (u_sq / 1024)
                                * 
                                (
                                    256 
                                    + 
                                    u_sq * (-128 + u_sq * (74 - 47 * u_sq))
                                );
                    double delta_sig =
                                        B * sin_sigma 
                                        * 
                                        (
                                            cos2_sigma_m 
                                            + 
                                            0.25 * B 
                                            * 
                                            (
                                                cos_sigma * (-1 + 2 * cos2_sigma_m * cos2_sigma_m) 
                                                -
                                                (1 / 6) * B 
                                                * 
                                                cos2_sigma_m * (-3 + 4 * sin_sigma * sin_sigma) 
                                                *
                                                (-3 + 4 * cos2_sigma_m * cos2_sigma_m)
                                            )
                                        );

                    double distance = b * A * (sigma - delta_sig);

                    return distance;
                }
            }
        }
    }
}