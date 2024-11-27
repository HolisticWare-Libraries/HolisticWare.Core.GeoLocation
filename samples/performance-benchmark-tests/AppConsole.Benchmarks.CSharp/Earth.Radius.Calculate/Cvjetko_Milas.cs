namespace Benchmarks;

public partial class
                                            Cvjetko_Milas
{
    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                        EarthRadius_R
                                        (
                                        )
    {
        return         
            Core.GeoLocation.Earth.Radius.AtLatitude
                                        (
                                            45.76087009225421
                                        );
    }
}
