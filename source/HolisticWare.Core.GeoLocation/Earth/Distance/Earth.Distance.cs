using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.GeoLocation;

/// <summary>
/// Earth Model abstraction
/// </summary> 
/// <href="https://www.nco.ncep.noaa.gov/pmb/docs/grib2/grib2_doc/grib2_table3-2.shtml" />
/// <href="https://www.movable-type.co.uk/scripts/latlong-vincenty.html" />
/// <href="https://gis.stackexchange.com/questions/4906/why-is-law-of-cosines-more-preferable-than-haversine-when-calculating-distance-b" />
public partial class 
                                        Earth
{
    public partial class                
                                        Distance
    {        
        public static
            Func<double, double, double, double, double>
                                        Calculate
                                        =>
                                        Spherical.Distance.Haversine.CalculateCopilot
                                        ;
    }
}
