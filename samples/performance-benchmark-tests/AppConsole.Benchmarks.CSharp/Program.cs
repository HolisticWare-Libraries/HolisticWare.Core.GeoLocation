
/*
dotnet run \
    --project ./AppConsole.Benchmarks.CSharp/AppConsole.Benchmarks.CSharp.csproj \
        -c Release \
        -f net9.0

dotnet run \
    --project samples/performance-benchmark-tests/AppConsole.Benchmarks.CSharp/AppConsole.Benchmarks.CSharp.csproj \
        -c Release \
        -f net9.0
*/

Benchmarks.Earth.Distance.Calculate.Cvjetko_Milas.Dump();
Benchmarks.Earth.Distance.Calculate.Kombi.Dump();
Benchmarks.Earth.Distance.Calculate.Seat.Dump();
Console.WriteLine("              Correct = 2.7161912585815897");

Benchmarks.Earth.Distance.Calculate.NathanRooy.Dump();
Benchmarks.Earth.Distance.Calculate.MladostTrackField100m.Dump();
Benchmarks.Earth.Distance.Calculate.DinamoField105m.Dump();
Benchmarks.Earth.Distance.Calculate.SveticeTrackField100m.Dump();



/*
*/
BenchmarkDotNet.Reports.Summary summary = null;


summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<Benchmarks.Earth.Distance.Calculate.Cvjetko_Milas>();
summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<Benchmarks.Earth.Distance.Calculate.Kombi>();
summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<Benchmarks.Earth.Distance.Calculate.NathanRooy>();
summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<Benchmarks.Earth.Distance.Calculate.Seat>();
summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<Benchmarks.Earth.Distance.Calculate.MladostTrackField100m>();
summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<Benchmarks.Earth.Distance.Calculate.DinamoField105m>();
summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<Benchmarks.Earth.Distance.Calculate.SveticeTrackField100m>();
System.IO.File.Move
                (
                    summary.LogFilePath,
                    System.IO.Path.Combine
                                        (
                                            "..", "..", "..",
                                            "Basics01.ControlStructures.ControlStructures.log"
                                        ),
                    true
                );

return;
