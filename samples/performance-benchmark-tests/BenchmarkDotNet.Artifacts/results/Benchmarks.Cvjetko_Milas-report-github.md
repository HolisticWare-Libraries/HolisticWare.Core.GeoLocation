``` ini

BenchmarkDotNet=v0.13.5, OS=macOS 14.3.1 (23D60) [Darwin 23.3.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK=8.0.101
  [Host]     : .NET 8.0.2 (8.0.224.6711), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.2 (8.0.224.6711), Arm64 RyuJIT AdvSIMD


```
|                                                                                                    Method |       Mean |     Error |    StdDev |
|---------------------------------------------------------------------------------------------------------- |-----------:|----------:|----------:|
|       EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateWithRadiusAtLatitude |  14.764 ns | 0.1423 ns | 0.1331 ns |
| EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateSphericalProjectionToPlane |   5.571 ns | 0.0462 ns | 0.0433 ns |
|                        EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaConverginglMeridians_Calculate |   5.820 ns | 0.1128 ns | 0.1055 ns |
|                               EuclidianPlanarFlatEarth_Distance_FederalCommunicationsCommission_Calculate |  21.585 ns | 0.2764 ns | 0.2586 ns |
|                                                             Spherical_Distance_Haversine_CalculateCopilot |  24.456 ns | 0.3000 ns | 0.2807 ns |
|                                                                Spherical_Distance_Haversine_CalculateMAUI |  20.547 ns | 0.1495 ns | 0.1398 ns |
|                                                       Spherical_Distance_Haversine_CalculateMAUIOptimized |  20.489 ns | 0.1381 ns | 0.1154 ns |
|                                                                   Spherical_Distance_Haversine_Calculate3 |  54.428 ns | 0.3620 ns | 0.3386 ns |
|                                                                   Spherical_Distance_Haversine_Calculate4 |  21.208 ns | 0.1280 ns | 0.1135 ns |
|                                                                  Spherical_Distance_GreatCircle_Calculate |   5.716 ns | 0.0502 ns | 0.0470 ns |
|                                                                 Spherical_Distance_LawOfCosines_Calculate |  27.397 ns | 0.1705 ns | 0.1594 ns |
|                                                     Spherical_Distance_EquirectangularPytagoras_Calculate |   5.638 ns | 0.0445 ns | 0.0416 ns |
|                                                       Ellipsoidal_Distance_Vincenty_CalculateHeriHermawan |  24.077 ns | 0.1574 ns | 0.1473 ns |
|                                         Ellipsoidal_Distance_Vincenty_CalculateIterativeNathanRooyArticle | 179.918 ns | 2.5142 ns | 2.3518 ns |
|                                                                                             EarthRadius_R |   9.048 ns | 0.0753 ns | 0.0704 ns |
