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
                                        Lambert
            {
                /// <summary>
                /// Calculate Lambert distance (
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
                                        Calculate
                                        (
                                            double lat1,
                                            double lon1,
                                            double lat2,
                                            double lon2
                                        )
                {
                    double d = 0;
                    
                    double dx = (lon1 - lon2);
                    double dy = (lat2 - lat1);

                    d = Math.Sqrt(dx * dx + dy * dy);
                    
                    return d;
                }
            }
        }
    }
}