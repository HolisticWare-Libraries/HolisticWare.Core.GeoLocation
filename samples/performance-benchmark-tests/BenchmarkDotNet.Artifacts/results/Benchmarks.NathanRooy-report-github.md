``` ini

BenchmarkDotNet=v0.13.5, OS=macOS 14.3.1 (23D60) [Darwin 23.3.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK=8.0.101
  [Host]     : .NET 8.0.2 (8.0.224.6711), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.2 (8.0.224.6711), Arm64 RyuJIT AdvSIMD


```
|                                                                                                    Method |       Mean |     Error |    StdDev |
|---------------------------------------------------------------------------------------------------------- |-----------:|----------:|----------:|
|       EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateWithRadiusAtLatitude |   9.921 ns | 0.1052 ns | 0.0984 ns |
| EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateSphericalProjectionToPlane |   3.529 ns | 0.0407 ns | 0.0381 ns |
|                        EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaConverginglMeridians_Calculate |   3.968 ns | 0.0700 ns | 0.0655 ns |
|                               EuclidianPlanarFlatEarth_Distance_FederalCommunicationsCommission_Calculate |  20.469 ns | 0.2790 ns | 0.2610 ns |
|                                                             Spherical_Distance_Haversine_CalculateCopilot |  20.401 ns | 0.1973 ns | 0.1845 ns |
|                                                                Spherical_Distance_Haversine_CalculateMAUI |  17.825 ns | 0.1822 ns | 0.1615 ns |
|                                                       Spherical_Distance_Haversine_CalculateMAUIOptimized |  19.632 ns | 0.2096 ns | 0.1961 ns |
|                                                                   Spherical_Distance_Haversine_Calculate3 |  49.557 ns | 0.4757 ns | 0.4450 ns |
|                                                                   Spherical_Distance_Haversine_Calculate4 |  17.716 ns | 0.1980 ns | 0.1755 ns |
|                                                                  Spherical_Distance_GreatCircle_Calculate |   3.787 ns | 0.0558 ns | 0.0522 ns |
|                                                                 Spherical_Distance_LawOfCosines_Calculate |  19.012 ns | 0.2501 ns | 0.2340 ns |
|                                                     Spherical_Distance_EquirectangularPytagoras_Calculate |   3.909 ns | 0.0440 ns | 0.0412 ns |
|                                                       Ellipsoidal_Distance_Vincenty_CalculateHeriHermawan |  20.391 ns | 0.2614 ns | 0.2445 ns |
|                                         Ellipsoidal_Distance_Vincenty_CalculateIterativeNathanRooyArticle | 118.155 ns | 1.2159 ns | 1.1373 ns |
