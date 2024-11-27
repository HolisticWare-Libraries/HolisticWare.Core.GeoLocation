using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.GeoLocation;

/// <summary>
///
/// </summary>
/// <href="https://en.wikipedia.org/wiki/Haversine_formula" />
/// <href="https://www.movable-type.co.uk/scripts/latlong-vincenty.html" />
/// <href="https://gis.stackexchange.com/questions/4906/why-is-law-of-cosines-more-preferable-than-haversine-when-calculating-distance-b" />
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
                                        FederalCommunicationsCommission
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
                    double lat = Radian.FromDegrees( ( lat1 + lat2 ) * 0.5 );
                    double delta_lat = ( lat1 - lat2 );
                    double delta_lon = ( lon1 - lon2 );

                    // Chebishev
                    double K1 = 111.13209 - 0.56605 * Math.Cos( 2 * lat) + 0.00120 * Math.Cos( 4 * lat);
                    double K2 = 111.41513 * Math.Cos( lat ) - 0.09455 * Math.Cos( 3 * lat ) + 0.00012 * Math.Cos( 5 * lat );
                    double d = 
                                Math.Sqrt
                                    (
                                        // Pow 2x slower 23.322 ns  vs 46.795 ns
                                        // Math.Pow( K1 * ( lat1 - lat2 ), 2 )                                        
                                        K1 * delta_lat * K1 * delta_lat
                                        + 
                                        // Pow 2x slower
                                        // Math.Pow( K2 * ( lon1 - lon2 ), 2 )
                                        K2 * delta_lon * K2 * delta_lon
                                    );

                    return d * 1000;
                }
            }
        }
    }
}
