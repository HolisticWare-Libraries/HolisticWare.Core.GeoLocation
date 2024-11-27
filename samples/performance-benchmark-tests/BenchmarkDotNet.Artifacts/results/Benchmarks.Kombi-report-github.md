``` ini

BenchmarkDotNet=v0.13.5, OS=macOS 14.3.1 (23D60) [Darwin 23.3.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK=8.0.101
  [Host]     : .NET 8.0.2 (8.0.224.6711), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.2 (8.0.224.6711), Arm64 RyuJIT AdvSIMD


```
|                                                                                                    Method |       Mean |     Error |    StdDev |
|---------------------------------------------------------------------------------------------------------- |-----------:|----------:|----------:|
|       EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateWithRadiusAtLatitude |  14.731 ns | 0.1493 ns | 0.1324 ns |
| EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateSphericalProjectionToPlane |   5.516 ns | 0.0531 ns | 0.0470 ns |
|                        EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaConverginglMeridians_Calculate |   5.903 ns | 0.0367 ns | 0.0344 ns |
|                               EuclidianPlanarFlatEarth_Distance_FederalCommunicationsCommission_Calculate |  21.487 ns | 0.1659 ns | 0.1552 ns |
|                                                             Spherical_Distance_Haversine_CalculateCopilot |  24.340 ns | 0.1492 ns | 0.1395 ns |
|                                                                Spherical_Distance_Haversine_CalculateMAUI |  20.519 ns | 0.1229 ns | 0.1089 ns |
|                                                       Spherical_Distance_Haversine_CalculateMAUIOptimized |  20.465 ns | 0.1375 ns | 0.1219 ns |
|                                                                   Spherical_Distance_Haversine_Calculate3 |  53.282 ns | 0.4314 ns | 0.4036 ns |
|                                                                   Spherical_Distance_Haversine_Calculate4 |  21.252 ns | 0.1897 ns | 0.1774 ns |
|                                                                  Spherical_Distance_GreatCircle_Calculate |   6.269 ns | 0.1459 ns | 0.2880 ns |
|                                                                 Spherical_Distance_LawOfCosines_Calculate |  28.981 ns | 0.5932 ns | 0.8507 ns |
|                                                     Spherical_Distance_EquirectangularPytagoras_Calculate |   5.693 ns | 0.0421 ns | 0.0394 ns |
|                                                       Ellipsoidal_Distance_Vincenty_CalculateHeriHermawan |  24.373 ns | 0.2486 ns | 0.2325 ns |
|                                         Ellipsoidal_Distance_Vincenty_CalculateIterativeNathanRooyArticle | 138.740 ns | 1.3626 ns | 1.2746 ns |
