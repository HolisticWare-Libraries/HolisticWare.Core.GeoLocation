
/*
dotnet run \
    --project ./AppConsole.Benchmarks.CSharp/AppConsole.Benchmarks.CSharp.csproj \
        -c Release \
        -f net9.0

*/
Benchmarks.Cvjetko_Milas.Dump();
Benchmarks.Kombi.Dump();
Benchmarks.Seat.Dump();
Benchmarks.NathanRooy.Dump();
Console.WriteLine("              Correct = 2.7161912585815897");


BenchmarkDotNet.Reports.Summary summary = null;


summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<Benchmarks.Cvjetko_Milas>();
summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<Benchmarks.Kombi>();
summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<Benchmarks.Seat>();
summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<Benchmarks.NathanRooy>();

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
