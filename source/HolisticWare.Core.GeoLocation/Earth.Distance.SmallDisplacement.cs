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
                                        SmallDisplacement
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
                double dx =
                            (
                                lon1 * Math.Cos(lat1)
                                -
                                lon2 * Math.Cos(lat2)
                            )
                            ;
                double dy =
                            (
                                lat1
                                -
                                lat2
                            )
                            ;

                double d = Earth.Radius.AverageKilometers * Math.Sqrt( dx * dx + dy * dy );

                return d;
            }

            public static
                double
                                        CalculatePreciseRadius
                                        (
                                            double lat1,
                                            double lon1,
                                            double lat2,
                                            double lon2
                                        )
            {
                double dx =
                            (
                                lon1 * Math.Cos(lat1)
                                -
                                lon2 * Math.Cos(lat2)
                            )
                            ;
                double dy =
                            (
                                lat1
                                -
                                lat2
                            )
                            ;

                double r = Earth.Radius.AtLatitude(lat1);
                double d = r * Math.Sqrt( dx * dx + dy * dy );

                return d;
            }
        }
    }
}
