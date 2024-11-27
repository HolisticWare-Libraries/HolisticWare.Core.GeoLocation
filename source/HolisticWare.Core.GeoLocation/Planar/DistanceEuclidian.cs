using System;

namespace Core.GeoLocation.Spatial;

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
                                            double y,
                                            double z
                                        )
        {
            double distance = System.Math.Sqrt(x * x + y * y + z * z);

            return distance;
        }

        public static
            double
                                        CalculateDistance
                                        (
                                            (double x, double y, double z) data
                                        )
        {
            return CalculateDistance(data.x, data.y, data.z);
        }
    }
}
