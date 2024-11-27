using System;

namespace Core.GeoLocation.Planar;

/// <summary>
///
/// </summary>
public partial class
                                        DistanceEuclidian
{
    public partial class
                                        Utilities
    {
        public static
            double
                                        CalculateDistance
                                        (
                                            double x,
                                            double y
                                        )
        {
            double distance = System.Math.Sqrt(x * x + y * y);

            return distance;
        }

        public static
            double
                                        CalculateDistance
                                        (
                                            (double x, double y) data
                                        )
        {
            return CalculateDistance(data.x, data.y);
        }
    }
}

