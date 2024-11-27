namespace Benchmarks;

public partial class
                                            NathanRooy
{
    static string description = "// Nathan Rooy'samplemoljac's/mel's (zagreb) van 5.99 m";
    static string description_colors = "// not on picture";
    static double lat1 = 39.152501;
    static double lon1 = -84.412977;
    static double lat2 = 39.152505;
    static double lon2 = -84.412946;

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                        EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateWithRadiusAtLatitude
                                        (
                                        )
    {
        return         
            Core.GeoLocation.Earth
                .EuclidianPlanarFlatEarth.Distance.PythagoreanFormulaParallelMeridians
                                        .CalculateWithRadiusAtLatitude
                                                (
                                                    lat1, 
                                                    lon1,
                                                    lat2,
                                                    lon2
                                                );
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                        EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateSphericalProjectionToPlane
                                        (
                                        )
    {
        return         
            Core.GeoLocation.Earth
                .EuclidianPlanarFlatEarth.Distance.PythagoreanFormulaParallelMeridians
                                        .CalculateSphericalProjectionToPlane
                                                (
                                                    lat1, 
                                                    lon1,
                                                    lat2,
                                                    lon2
                                                );
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                        EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaConverginglMeridians_Calculate
                                        (
                                        )
    {
        return         
            Core.GeoLocation.Earth
                .EuclidianPlanarFlatEarth.Distance.PythagoreanFormulaConverginglMeridians
                                        .Calculate
                                                (
                                                    lat1, 
                                                    lon1,
                                                    lat2,
                                                    lon2
                                                );
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                        EuclidianPlanarFlatEarth_Distance_FederalCommunicationsCommission_Calculate
                                        (
                                        )
    {
        return         
            Core.GeoLocation.Earth
                .EuclidianPlanarFlatEarth.Distance.FederalCommunicationsCommission
                                        .Calculate
                                                (
                                                    lat1, 
                                                    lon1,
                                                    lat2,
                                                    lon2
                                                );
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                        Spherical_Distance_Haversine_CalculateCopilot
                                        (
                                        )
    {
        return         
            Core.GeoLocation.Earth
                .Spherical.Distance.Haversine.CalculateCopilot
                                                            (
                                                                lat1, 
                                                                lon1,
                                                                lat2,
                                                                lon2
                                                            );
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                        Spherical_Distance_Haversine_CalculateMAUI
                                        (
                                        )
    {
        return         
            Core.GeoLocation.Earth
                .Spherical.Distance.Haversine.CalculateMAUI
                                                            (
                                                                lat1, 
                                                                lon1,
                                                                lat2,
                                                                lon2
                                                            );
    }
    

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                        Spherical_Distance_Haversine_CalculateMAUIOptimized
                                        (
                                        )
    {
        return         
            Core.GeoLocation.Earth
                .Spherical.Distance.Haversine.CalculateMAUIOptimized
                                                            (
                                                                lat1, 
                                                                lon1,
                                                                lat2,
                                                                lon2
                                                            );
    }
    
    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                        Spherical_Distance_Haversine_Calculate3
                                        (
                                        )
    {
        return         
            Core.GeoLocation.Earth
                .Spherical.Distance.Haversine.Calculate3
                                                            (
                                                                lat1, 
                                                                lon1,
                                                                lat2,
                                                                lon2
                                                            );
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                        Spherical_Distance_Haversine_Calculate4
                                        (
                                        )
    {
        return         
            Core.GeoLocation.Earth
                .Spherical.Distance.Haversine
                                        .Calculate4
                                                (
                                                    lat1, 
                                                    lon1,
                                                    lat2,
                                                    lon2
                                                );
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                        Spherical_Distance_GreatCircle_Calculate
                                        (
                                        )
    {
        return         
            Core.GeoLocation.Earth
                .Spherical.Distance.GreatCircle
                                        .Calculate
                                                (
                                                    lat1, 
                                                    lon1,
                                                    lat2,
                                                    lon2
                                                );
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                        Spherical_Distance_LawOfCosines_Calculate
                                        (
                                        )
    {
        return         
            Core.GeoLocation.Earth
                .Spherical.Distance.LawOfCosines
                                        .Calculate
                                                (
                                                    lat1, 
                                                    lon1,
                                                    lat2,
                                                    lon2
                                                );
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                        Spherical_Distance_EquirectangularPytagoras_Calculate
                                        (
                                        )
    {
        return         
            Core.GeoLocation.Earth
                .Spherical.Distance.EquirectangularPytagoras
                                        .Calculate
                                                (
                                                    lat1, 
                                                    lon1,
                                                    lat2,
                                                    lon2
                                                );
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                        Ellipsoidal_Distance_Vincenty_CalculateHeriHermawan
                                        (
                                        )
    {
        return         
            Core.GeoLocation.Earth
                .Ellipsoidal.Distance.Vincenty
                                        .CalculateHeriHermawan
                                                (
                                                    lat1, 
                                                    lon1,
                                                    lat2,
                                                    lon2
                                                );
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                        Ellipsoidal_Distance_Vincenty_CalculateIterativeNathanRooyArticle
                                        (
                                        )
    {
        return         
            Core.GeoLocation.Earth
                .Ellipsoidal.Distance.Vincenty
                                        .CalculateIterativeNathanRooyArticle
                                                (
                                                    lat1, 
                                                    lon1,
                                                    lat2,
                                                    lon2
                                                );
    }

    public static
        void
                                        Dump
                                        (                                            
                                        )
    {
        double distance;

        Console.WriteLine(new string('=', 120));
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name}");
        Console.WriteLine(description);
        Console.WriteLine(description_colors);
        Console.WriteLine($"lat1 = {lat1}");
        Console.WriteLine($"lon1 = {lon1}");
        Console.WriteLine($"lat2 = {lat2}");
        Console.WriteLine($"lon2 = {lon2}");

        distance = Core.GeoLocation.Earth
                                        .EuclidianPlanarFlatEarth.Distance
                                            .PythagoreanFormulaParallelMeridians
                                                .CalculateWithRadiusAtLatitude
                                                                        (
                                                                            lat1, 
                                                                            lon1,
                                                                            lat2,
                                                                            lon2
                                                                        );
        Console.WriteLine("EuclidianPlanarFlatEarth.Distance");
        Console.WriteLine("     PythagoreanFormulaParallelMeridians");
        Console.WriteLine("         CalculateWithRadiusAtLatitude");
        Console.WriteLine($"             distance = {distance}");

        distance = Core.GeoLocation.Earth
                                        .EuclidianPlanarFlatEarth.Distance
                                            .PythagoreanFormulaParallelMeridians
                                                .CalculateSphericalProjectionToPlane
                                                                        (
                                                                            lat1, 
                                                                            lon1,
                                                                            lat2,
                                                                            lon2
                                                                        );
        Console.WriteLine("EuclidianPlanarFlatEarth.Distance");
        Console.WriteLine("     PythagoreanFormulaParallelMeridians");
        Console.WriteLine("         CalculateSphericalProjectionToPlane");
        Console.WriteLine($"             distance = {distance}");

        distance = Core.GeoLocation.Earth
                                        .EuclidianPlanarFlatEarth.Distance
                                            .PythagoreanFormulaConverginglMeridians
                                                .Calculate
                                                                        (
                                                                            lat1, 
                                                                            lon1,
                                                                            lat2,
                                                                            lon2
                                                                        );
        Console.WriteLine("EuclidianPlanarFlatEarth.Distance");
        Console.WriteLine("     PythagoreanFormulaConverginglMeridians");
        Console.WriteLine("         Calculate");
        Console.WriteLine($"             distance = {distance}");

        distance = Core.GeoLocation.Earth
                                        .EuclidianPlanarFlatEarth.Distance
                                            .FederalCommunicationsCommission
                                                .Calculate
                                                                        (
                                                                            lat1, 
                                                                            lon1,
                                                                            lat2,
                                                                            lon2
                                                                        );
        Console.WriteLine("EuclidianPlanarFlatEarth.Distance");
        Console.WriteLine("     FederalCommunicationsCommission");
        Console.WriteLine("         Calculate");
        Console.WriteLine($"             distance = {distance}");

        distance = Core.GeoLocation.Earth
                                        .Spherical.Distance
                                            .Haversine
                                                .CalculateMAUI
                                                                        (
                                                                            lat1, 
                                                                            lon1,
                                                                            lat2,
                                                                            lon2
                                                                        );
        Console.WriteLine("Spherical.Distance");
        Console.WriteLine("     Haversine");
        Console.WriteLine("         CalculateMAUI");
        Console.WriteLine($"             distance = {distance}");

        distance = Core.GeoLocation.Earth
                                        .Spherical.Distance
                                            .Haversine
                                                .CalculateMAUIOptimized
                                                                        (
                                                                            lat1, 
                                                                            lon1,
                                                                            lat2,
                                                                            lon2
                                                                        );
        Console.WriteLine("Spherical.Distance");
        Console.WriteLine("     Haversine");
        Console.WriteLine("         CalculateMAUIOptimized");
        Console.WriteLine($"             distance = {distance}");

        distance = Core.GeoLocation.Earth
                                        .Spherical.Distance
                                            .Haversine
                                                .CalculateMAUINonOptimized
                                                                        (
                                                                            lat1, 
                                                                            lon1,
                                                                            lat2,
                                                                            lon2
                                                                        );
        Console.WriteLine("Spherical.Distance");
        Console.WriteLine("     Haversine");
        Console.WriteLine("         CalculateMAUINonOptimized");
        Console.WriteLine($"             distance = {distance}");

        distance = Core.GeoLocation.Earth
                                        .Spherical.Distance
                                            .Haversine
                                                .CalculateCopilot
                                                                        (
                                                                            lat1, 
                                                                            lon1,
                                                                            lat2,
                                                                            lon2
                                                                        );
        Console.WriteLine("Spherical.Distance");
        Console.WriteLine("     Haversine");
        Console.WriteLine("         CalculateCopilot");
        Console.WriteLine($"             distance = {distance}");

        distance = Core.GeoLocation.Earth
                                        .Spherical.Distance
                                            .Haversine
                                                .Calculate3
                                                                        (
                                                                            lat1, 
                                                                            lon1,
                                                                            lat2,
                                                                            lon2
                                                                        );
        Console.WriteLine("Spherical.Distance");
        Console.WriteLine("     Haversine");
        Console.WriteLine("         Calculate3");
        Console.WriteLine($"             distance = {distance}");

        distance = Core.GeoLocation.Earth
                                        .Spherical.Distance
                                            .Haversine
                                                .Calculate4
                                                                        (
                                                                            lat1, 
                                                                            lon1,
                                                                            lat2,
                                                                            lon2
                                                                        );
        Console.WriteLine("Spherical.Distance");
        Console.WriteLine("     Haversine");
        Console.WriteLine("         Calculate4");
        Console.WriteLine($"             distance = {distance}");

        distance = Core.GeoLocation.Earth
                                        .Spherical.Distance
                                            .GreatCircle
                                                .Calculate
                                                                        (
                                                                            lat1, 
                                                                            lon1,
                                                                            lat2,
                                                                            lon2
                                                                        );
        Console.WriteLine("Spherical.Distance");
        Console.WriteLine("     GreatCircle");
        Console.WriteLine("         Calculate");
        Console.WriteLine($"             distance = {distance}");

        distance = Core.GeoLocation.Earth
                                        .Spherical.Distance
                                            .LawOfCosines
                                                .Calculate
                                                                        (
                                                                            lat1, 
                                                                            lon1,
                                                                            lat2,
                                                                            lon2
                                                                        );
        Console.WriteLine("Spherical.Distance");
        Console.WriteLine("     LawOfCosines");
        Console.WriteLine("         Calculate");
        Console.WriteLine($"             distance = {distance}");

        distance = Core.GeoLocation.Earth
                                        .Spherical.Distance
                                            .EquirectangularPytagoras
                                                .Calculate
                                                                        (
                                                                            lat1, 
                                                                            lon1,
                                                                            lat2,
                                                                            lon2
                                                                        );
        Console.WriteLine("Spherical.Distance");
        Console.WriteLine("     EquirectangularPytagoras");
        Console.WriteLine("         Calculate");
        Console.WriteLine($"             distance = {distance}");

        distance = Core.GeoLocation.Earth
                                        .Ellipsoidal.Distance
                                            .Vincenty
                                                .CalculateHeriHermawan
                                                                        (
                                                                            lat1, 
                                                                            lon1,
                                                                            lat2,
                                                                            lon2
                                                                        );
        Console.WriteLine("Ellipsoidal.Distance");
        Console.WriteLine("     Vincenty");
        Console.WriteLine("         CalculateHeriHermawan");
        Console.WriteLine($"             distance = {distance}");

        distance = Core.GeoLocation.Earth
                                        .Ellipsoidal.Distance
                                            .Vincenty
                                                .CalculateIterativeNathanRooyArticle
                                                                        (
                                                                            lat1, 
                                                                            lon1,
                                                                            lat2,
                                                                            lon2
                                                                        );
        Console.WriteLine("Ellipsoidal.Distance");
        Console.WriteLine("     Vincenty");
        Console.WriteLine("         CalculateIterativeNathanRooyArticle");
        Console.WriteLine($"             distance = {distance}");

        return;
    }          
}