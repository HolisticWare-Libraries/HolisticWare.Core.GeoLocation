# HolisticWare.Core.GeoLocation


Essentials Location for distance calculations uses spherical Haversine optimized algorithm (optimized, because does not
use Atan, but Asin), which is general purpose algorithm suitable for middle range displacements, but is quite complex
for small displacments which are mostly used in mobile apps, such as geo tracking apps.

Tracking (usually mobile) apps in most cases track small displacements. Rarely will user request Location, sit on the
plane, fly over big pond, land and then request destination Location and then calculate distance between the two.

Some algorithms are 4x faster than currently used by MAUI and that means - processor time reduction, thus battery saving
and more.


Func<> (delegate) to select algorithm for distance calculation

several algorithms for GeoLocation/Geodesic calculations for following Earth models:

1. Eucliedian/Planar/Flat-Earth

    a. Pythagora's Algorithm for Model with converging meridians
    
    b. FCC Algorithm

    c. Equirectangular Pythagora's Algorithm

2. Spherical

    a. GreatCircle

    b. Haversine

    c. Law of Cosines

3. Ellipsoidal

    a. Vincenty optimized

    b. Vincenty iterative


These algorithms were proposed in MAUI PR, but closed in order not to clutter MAUI repo with GeoLocation APIs

*   https://github.com/dotnet/maui/pull/20663

## Tests 

### Accuracy

## TODO:

*   unit-tests

## Samples for small displacements

### Data

Test data

*   https://www.google.com/maps/@45.7609834,16.0050421,58m/data=!3m1!1e3?entry=ttu

*   from Mom's garden entrance to neighbor

    *   dot color: green

*   length of a van

    *   dot color: red

*   length of a car

    *   dot color: yellow

<img width="1689" alt="Screenshot2024-02-17at21 00 03" src="https://github.com/dotnet/maui/assets/1768576/a1d6cdf3-3a55-415f-af67-7591b74b0647">


#### Calculations

```
========================================================================================================================
Cvjetko_Milas
// moljac's/mel's (zagreb) Mom's to neighbors 60 m
// green dots
lat1 = 45,76087009225421
lon1 = 16,005469744473892
lat2 = 45,76103944060098
lon2 = 16,00473213700773
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaParallelMeridians
         CalculateWithRadiusAtLatitude
             distance = 57,18621007366878
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaParallelMeridians
         CalculateSphericalProjectionToPlane
             distance = 57,22036835369981
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaConverginglMeridians
         Calculate
             distance = 60,23923912085034
EuclidianPlanarFlatEarth.Distance
     FederalCommunicationsCommission
         Calculate
             distance = 60,392843848244325
Spherical.Distance
     Haversine
         CalculateMAUI
             distance = 60,23923912057531
Spherical.Distance
     Haversine
         CalculateMAUIOptimized
             distance = 60,23923912057531
Spherical.Distance
     Haversine
         CalculateMAUINonOptimized
             distance = 60,23923912057531
Spherical.Distance
     Haversine
         CalculateCopilot
             distance = 60,23923912057531
Spherical.Distance
     Haversine
         Calculate3
             distance = 60,30663776304765
Spherical.Distance
     Haversine
         Calculate4
             distance = 60,23926028497257
Spherical.Distance
     GreatCircle
         Calculate
             distance = 60,23923912085034
Spherical.Distance
     LawOfCosines
         Calculate
             distance = 60,23920420326504
Spherical.Distance
     EquirectangularPytagoras
         Calculate
             distance = 60,23923912085034
Ellipsoidal.Distance
     Vincenty
         CalculateHeriHermawan
             distance = 60,10444102493516
Ellipsoidal.Distance
     Vincenty
         CalculateIterativeNathanRooyArticle
             distance = 60,39124263135653
```


```
========================================================================================================================
Kombi
// moljac's/mel's (zagreb) van 5.99 m
// red dots
lat1 = 45,7610525393467
lon1 = 16,00470531491805
lat2 = 45,761106805546284
lon2 = 16,004720067067375
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaParallelMeridians
         CalculateWithRadiusAtLatitude
             distance = 1,1437216290072365
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaParallelMeridians
         CalculateSphericalProjectionToPlane
             distance = 1,1444048053085327
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaConverginglMeridians
         Calculate
             distance = 6,14169687264418
EuclidianPlanarFlatEarth.Distance
     FederalCommunicationsCommission
         Calculate
             distance = 6,139690147023857
Spherical.Distance
     Haversine
         CalculateMAUI
             distance = 6,141696872644147
Spherical.Distance
     Haversine
         CalculateMAUIOptimized
             distance = 6,141696872644147
Spherical.Distance
     Haversine
         CalculateMAUINonOptimized
             distance = 6,1416968726441485
Spherical.Distance
     Haversine
         CalculateCopilot
             distance = 6,1416968726441485
Spherical.Distance
     Haversine
         Calculate3
             distance = 6,148568507109256
Spherical.Distance
     Haversine
         Calculate4
             distance = 6,141910480472593
Spherical.Distance
     GreatCircle
         Calculate
             distance = 6,14169687264418
Spherical.Distance
     LawOfCosines
         Calculate
             distance = 6,142256232892537
Spherical.Distance
     EquirectangularPytagoras
         Calculate
             distance = 6,14169687264418
Ellipsoidal.Distance
     Vincenty
         CalculateHeriHermawan
             distance = 6,127953521352937
Ellipsoidal.Distance
     Vincenty
         CalculateIterativeNathanRooyArticle
             distance = 6,139721638060542
```

```
========================================================================================================================
Seat
// moljac's/mel's (zagreb) Mom's car ???? m
// yella dots
lat1 = 45,761023067164665
lon1 = 16,00474018363232
lat2 = 45,761009968412004
lon2 = 16,00479449836392
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaParallelMeridians
         CalculateWithRadiusAtLatitude
             distance = 4,210979861589438
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaParallelMeridians
         CalculateSphericalProjectionToPlane
             distance = 4,213495188089796
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaConverginglMeridians
         Calculate
             distance = 4,458136722979392
EuclidianPlanarFlatEarth.Distance
     FederalCommunicationsCommission
         Calculate
             distance = 4,469371429046293
Spherical.Distance
     Haversine
         CalculateMAUI
             distance = 4,45813672297928
Spherical.Distance
     Haversine
         CalculateMAUIOptimized
             distance = 4,45813672297928
Spherical.Distance
     Haversine
         CalculateMAUINonOptimized
             distance = 4,45813672297928
Spherical.Distance
     Haversine
         CalculateCopilot
             distance = 4,45813672297928
Spherical.Distance
     Haversine
         Calculate3
             distance = 4,4631247070154565
Spherical.Distance
     Haversine
         Calculate4
             distance = 4,457673923925613
Spherical.Distance
     GreatCircle
         Calculate
             distance = 4,458136722979392
Spherical.Distance
     LawOfCosines
         Calculate
             distance = 4,457923531577627
Spherical.Distance
     EquirectangularPytagoras
         Calculate
             distance = 4,458136722979392
Ellipsoidal.Distance
     Vincenty
         CalculateHeriHermawan
             distance = 4,4481606945770835
Ellipsoidal.Distance
     Vincenty
         CalculateIterativeNathanRooyArticle
             distance = 4,469243721000804
```

## Benchmarks

### 20250615

```
Kombi sample data

// * Summary *

BenchmarkDotNet=v0.13.5, OS=macOS 15.5 (24F74) [Darwin 24.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK=10.0.100-preview.5.25277.114
  [Host]     : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
```

|                                                                                                    Method |       Mean |     Error |    StdDev |
|---------------------------------------------------------------------------------------------------------- |-----------:|----------:|----------:|
|       EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateWithRadiusAtLatitude |  19.447 ns | 0.0613 ns | 0.0544 ns |
| EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateSphericalProjectionToPlane |   6.937 ns | 0.0479 ns | 0.0424 ns |
|                        EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaConverginglMeridians_Calculate |   7.132 ns | 0.0319 ns | 0.0298 ns |
|                               EuclidianPlanarFlatEarth_Distance_FederalCommunicationsCommission_Calculate |  29.020 ns | 0.0862 ns | 0.0806 ns |
|                                                             Spherical_Distance_Haversine_CalculateCopilot |  31.846 ns | 0.1241 ns | 0.1161 ns |
|                                                                Spherical_Distance_Haversine_CalculateMAUI |  26.668 ns | 0.0906 ns | 0.0847 ns |
|                                                       Spherical_Distance_Haversine_CalculateMAUIOptimized |  26.797 ns | 0.0769 ns | 0.0719 ns |
|                                                                   Spherical_Distance_Haversine_Calculate3 |  67.143 ns | 0.3410 ns | 0.3190 ns |
|                                                                   Spherical_Distance_Haversine_Calculate4 |  27.611 ns | 0.0948 ns | 0.0887 ns |
|                                                                  Spherical_Distance_GreatCircle_Calculate |   6.993 ns | 0.0488 ns | 0.0457 ns |
|                                                                 Spherical_Distance_LawOfCosines_Calculate |  37.234 ns | 0.1021 ns | 0.0853 ns |
|                                                     Spherical_Distance_EquirectangularPytagoras_Calculate |   7.899 ns | 0.0444 ns | 0.0415 ns |
|                                                       Ellipsoidal_Distance_Vincenty_CalculateHeriHermawan |  31.377 ns | 0.1022 ns | 0.0956 ns |
|                                         Ellipsoidal_Distance_Vincenty_CalculateIterativeNathanRooyArticle | 169.128 ns | 0.5697 ns | 0.5329 ns |

```
Seat sample data

// * Summary *

BenchmarkDotNet=v0.13.5, OS=macOS 15.5 (24F74) [Darwin 24.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK=10.0.100-preview.5.25277.114
  [Host]     : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
```

|                                                                                                    Method |       Mean |     Error |    StdDev |
|---------------------------------------------------------------------------------------------------------- |-----------:|----------:|----------:|
|       EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateWithRadiusAtLatitude |  19.285 ns | 0.0546 ns | 0.0510 ns |
| EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateSphericalProjectionToPlane |   6.919 ns | 0.0219 ns | 0.0205 ns |
|                        EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaConverginglMeridians_Calculate |   7.119 ns | 0.0158 ns | 0.0132 ns |
|                               EuclidianPlanarFlatEarth_Distance_FederalCommunicationsCommission_Calculate |  29.055 ns | 0.1529 ns | 0.1430 ns |
|                                                             Spherical_Distance_Haversine_CalculateCopilot |  31.832 ns | 0.1641 ns | 0.1535 ns |
|                                                                Spherical_Distance_Haversine_CalculateMAUI |  26.720 ns | 0.0693 ns | 0.0648 ns |
|                                                       Spherical_Distance_Haversine_CalculateMAUIOptimized |  26.722 ns | 0.0437 ns | 0.0409 ns |
|                                                                   Spherical_Distance_Haversine_Calculate3 |  68.355 ns | 0.3125 ns | 0.2923 ns |
|                                                                   Spherical_Distance_Haversine_Calculate4 |  27.812 ns | 0.0713 ns | 0.0667 ns |
|                                                                  Spherical_Distance_GreatCircle_Calculate |   7.001 ns | 0.0180 ns | 0.0160 ns |
|                                                                 Spherical_Distance_LawOfCosines_Calculate |  37.166 ns | 0.1649 ns | 0.1542 ns |
|                                                     Spherical_Distance_EquirectangularPytagoras_Calculate |   7.874 ns | 0.0366 ns | 0.0342 ns |
|                                                       Ellipsoidal_Distance_Vincenty_CalculateHeriHermawan |  31.667 ns | 0.1772 ns | 0.1658 ns |
|                                         Ellipsoidal_Distance_Vincenty_CalculateIterativeNathanRooyArticle | 168.880 ns | 0.6382 ns | 0.5969 ns |


```
NathanRooy sample

// * Summary *

BenchmarkDotNet=v0.13.5, OS=macOS 15.5 (24F74) [Darwin 24.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK=10.0.100-preview.5.25277.114
  [Host]     : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
```

|                                                                                                    Method |       Mean |     Error |    StdDev |
|---------------------------------------------------------------------------------------------------------- |-----------:|----------:|----------:|
|       EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateWithRadiusAtLatitude |  13.290 ns | 0.0194 ns | 0.0172 ns |
| EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateSphericalProjectionToPlane |   4.869 ns | 0.0265 ns | 0.0248 ns |
|                        EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaConverginglMeridians_Calculate |   5.061 ns | 0.0129 ns | 0.0115 ns |
|                               EuclidianPlanarFlatEarth_Distance_FederalCommunicationsCommission_Calculate |  27.636 ns | 0.0534 ns | 0.0499 ns |
|                                                             Spherical_Distance_Haversine_CalculateCopilot |  26.900 ns | 0.0943 ns | 0.0882 ns |
|                                                                Spherical_Distance_Haversine_CalculateMAUI |  23.194 ns | 0.0857 ns | 0.0802 ns |
|                                                       Spherical_Distance_Haversine_CalculateMAUIOptimized |  24.027 ns | 0.0613 ns | 0.0574 ns |
|                                                                   Spherical_Distance_Haversine_Calculate3 |  61.827 ns | 0.3103 ns | 0.2903 ns |
|                                                                   Spherical_Distance_Haversine_Calculate4 |  23.613 ns | 0.0652 ns | 0.0610 ns |
|                                                                  Spherical_Distance_GreatCircle_Calculate |   5.011 ns | 0.0130 ns | 0.0122 ns |
|                                                                 Spherical_Distance_LawOfCosines_Calculate |  28.078 ns | 0.0382 ns | 0.0339 ns |
|                                                     Spherical_Distance_EquirectangularPytagoras_Calculate |   5.914 ns | 0.0090 ns | 0.0080 ns |
|                                                       Ellipsoidal_Distance_Vincenty_CalculateHeriHermawan |  26.581 ns | 0.2357 ns | 0.2089 ns |
|                                         Ellipsoidal_Distance_Vincenty_CalculateIterativeNathanRooyArticle | 145.541 ns | 0.6795 ns | 0.6356 ns |
