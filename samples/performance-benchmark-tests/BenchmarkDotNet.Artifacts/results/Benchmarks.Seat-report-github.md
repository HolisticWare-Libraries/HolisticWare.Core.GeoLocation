``` ini

BenchmarkDotNet=v0.13.5, OS=macOS 14.3.1 (23D60) [Darwin 23.3.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK=8.0.101
  [Host]     : .NET 8.0.2 (8.0.224.6711), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.2 (8.0.224.6711), Arm64 RyuJIT AdvSIMD


```
|                                                                                                    Method |       Mean |     Error |    StdDev |
|---------------------------------------------------------------------------------------------------------- |-----------:|----------:|----------:|
|       EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateWithRadiusAtLatitude |  14.981 ns | 0.2515 ns | 0.2230 ns |
| EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateSphericalProjectionToPlane |   5.525 ns | 0.0582 ns | 0.0545 ns |
|                        EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaConverginglMeridians_Calculate |   5.715 ns | 0.0514 ns | 0.0481 ns |
|                               EuclidianPlanarFlatEarth_Distance_FederalCommunicationsCommission_Calculate |  21.509 ns | 0.1445 ns | 0.1352 ns |
|                                                             Spherical_Distance_Haversine_CalculateCopilot |  24.475 ns | 0.1577 ns | 0.1398 ns |
|                                                                Spherical_Distance_Haversine_CalculateMAUI |  21.831 ns | 0.1476 ns | 0.1381 ns |
|                                                       Spherical_Distance_Haversine_CalculateMAUIOptimized |  20.514 ns | 0.2238 ns | 0.2094 ns |
|                                                                   Spherical_Distance_Haversine_Calculate3 |  55.163 ns | 0.4106 ns | 0.3640 ns |
|                                                                   Spherical_Distance_Haversine_Calculate4 |  21.382 ns | 0.2175 ns | 0.2035 ns |
|                                                                  Spherical_Distance_GreatCircle_Calculate |   5.758 ns | 0.0539 ns | 0.0504 ns |
|                                                                 Spherical_Distance_LawOfCosines_Calculate |  27.622 ns | 0.3193 ns | 0.2987 ns |
|                                                     Spherical_Distance_EquirectangularPytagoras_Calculate |   5.821 ns | 0.0497 ns | 0.0440 ns |
|                                                       Ellipsoidal_Distance_Vincenty_CalculateHeriHermawan |  24.415 ns | 0.4118 ns | 0.3852 ns |
|                                         Ellipsoidal_Distance_Vincenty_CalculateIterativeNathanRooyArticle | 137.897 ns | 1.4328 ns | 1.3402 ns |
