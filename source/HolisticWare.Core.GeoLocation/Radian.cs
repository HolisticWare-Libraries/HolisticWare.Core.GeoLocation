using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.GeoLocation;

public partial class
                                        Radian
{
    public static readonly 
        double
                                        FactorInverse 
                                        = 0.01745329251
                                        ;
    
    public static readonly 
        double
                                        Factor = 180.0 / System.Math.PI
                                        ;

    public static 
        double
                                        FromDegrees
                                        (
                                            double degrees
                                        )
    {
        return degrees * FactorInverse;
    }
}
