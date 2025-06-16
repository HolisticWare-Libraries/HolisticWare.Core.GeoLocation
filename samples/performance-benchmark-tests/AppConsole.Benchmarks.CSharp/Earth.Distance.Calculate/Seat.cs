namespace Benchmarks.Earth.Distance.Calculate;

[BenchmarkDotNet.Attributes.MemoryDiagnoser]
/*
[ThreadingDiagnoser]
[ExceptionDiagnoser]
[BenchmarkDotNet.Attributes.AsciiDocExporter]
[BenchmarkDotNet.Attributes.CsvExporter]
[BenchmarkDotNet.Attributes.CsvMeasurementsExporter]
[BenchmarkDotNet.Attributes.HtmlExporter]
[BenchmarkDotNet.Attributes.PlainExporter]
[BenchmarkDotNet.Attributes.RPlotExporter]
[BenchmarkDotNet.Attributes.JsonExporterAttribute.Brief]
[BenchmarkDotNet.Attributes.JsonExporterAttribute.BriefCompressed]
[BenchmarkDotNet.Attributes.JsonExporterAttribute.Full]
[BenchmarkDotNet.Attributes.JsonExporterAttribute.FullCompressed]
[BenchmarkDotNet.Attributes.MarkdownExporterAttribute.Default]
[BenchmarkDotNet.Attributes.MarkdownExporterAttribute.GitHub]
[BenchmarkDotNet.Attributes.MarkdownExporterAttribute.StackOverflow]
[BenchmarkDotNet.Attributes.MarkdownExporterAttribute.Atlassian]
[BenchmarkDotNet.Attributes.XmlExporterAttribute.Brief]
[BenchmarkDotNet.Attributes.XmlExporterAttribute.BriefCompressed]
[BenchmarkDotNet.Attributes.XmlExporterAttribute.Full]
[BenchmarkDotNet.Attributes.XmlExporterAttribute.FullCompressed]
*/
public partial class
                                        Seat
{
    static string description = "// moljac's/mel's (zagreb) Mom's car ???? m";
    static string description_colors = "// yella dots";
    static double lat1 = 45.761023067164665;
    static double lon1 = 16.00474018363232;
    static double lat2 = 45.761009968412004;
    static double lon2 = 16.00479449836392;

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
