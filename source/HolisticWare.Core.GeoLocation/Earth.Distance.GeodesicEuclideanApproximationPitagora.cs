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
                                        Distance
    {
        public partial class
                                        GeodesicEuclideanApproximationPitagora
        {
            public static
                double
                                        CalculateInitial
                                        (
                                            double lat1,
                                            double lon1,
                                            double lat2,
                                            double lon2
                                        )
            {

                double delta_y_latitude = 
                                            20004146.0 / 180.0 
                                            * 
                                            Math.Abs(lat1 - lat2)
                                            ;

                double delta_x_longitude = 
                                            40074275.0 / 360.0 
                                            * 
                                            Math.Abs(lon1 - lon2) 
                                            * 
                                            Math.Cos(Radian.FromDegrees( 0.5 * (lat1 + lat2)))
                                            ;

                return Math.Sqrt
                            (
                                Math.Pow(delta_x_longitude, 2) 
                                + 
                                Math.Pow(delta_y_latitude, 2)
                            );
            }
        }
    }
}
