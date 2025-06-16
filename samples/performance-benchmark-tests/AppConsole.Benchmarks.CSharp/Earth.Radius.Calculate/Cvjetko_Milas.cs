namespace Benchmarks.Earth.Radius.Calculate;

[BenchmarkDotNet.Attributes.MemoryDiagnoser]
// [ThreadingDiagnoser]
// [ExceptionDiagnoser]
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
