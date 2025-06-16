# HolisticWare.Core.GeoLocation

readme.md

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

*   Mladost Track Field 100m

    *   https://www.google.com/maps/@45.78291,15.9423402,58m/data=!3m1!1e3?entry=ttu&g_ep=EgoyMDI1MDYxMS4wIKXMDSoASAFQAw%3D%3D

    *   45.78312417366624, 15.942453523323422

    *   45.78222443736099, 15.942481190386955

*   Dinamo Field 105m

    *   https://www.google.com/maps/place/GNK+Dinamo+Zagreb/@45.8184764,16.0174729,116m    

    *   45.81906101150348, 16.017374318970056

    *   45.818160934977485, 16.01777597974636

*   Svetice Track Field 100m

    *   https://www.google.com/maps/place/%C5%A0RC+Svetice/@45.8167816,16.0136274,169m

    *   45.81790486243052, 16.01416600446859

    *   45.81700539852965, 16.014193032031084

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
              Correct = 2.7161912585815897
========================================================================================================================
NathanRooy
// Nathan Rooy'samplemoljac's/mel's (zagreb) van 5.99 m
// not on picture
lat1 = 39,152501
lon1 = -84,412977
lat2 = 39,152505
lon2 = -84,412946
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaParallelMeridians
         CalculateWithRadiusAtLatitude
             distance = 2,6725075693911533
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaParallelMeridians
         CalculateSphericalProjectionToPlane
             distance = 2,673075575932411
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaConverginglMeridians
         Calculate
             distance = 2,7098270365495907
EuclidianPlanarFlatEarth.Distance
     FederalCommunicationsCommission
         Calculate
             distance = 2,7162579861548597
Spherical.Distance
     Haversine
         CalculateMAUI
             distance = 2,7098270365495765
Spherical.Distance
     Haversine
         CalculateMAUIOptimized
             distance = 2,7098270365495765
Spherical.Distance
     Haversine
         CalculateMAUINonOptimized
             distance = 2,7098270365495765
Spherical.Distance
     Haversine
         CalculateCopilot
             distance = 2,7098270365495765
Spherical.Distance
     Haversine
         Calculate3
             distance = 2,712858925170093
Spherical.Distance
     Haversine
         Calculate4
             distance = 2,7095383863714853
Spherical.Distance
     GreatCircle
         Calculate
             distance = 2,7098270365495907
Spherical.Distance
     LawOfCosines
         Calculate
             distance = 2,7118982888947136
Spherical.Distance
     EquirectangularPytagoras
         Calculate
             distance = 2,7098270365495907
Ellipsoidal.Distance
     Vincenty
         CalculateHeriHermawan
             distance = 2,7037632233913462
Ellipsoidal.Distance
     Vincenty
         CalculateIterativeNathanRooyArticle
             distance = 2,716180489732404
========================================================================================================================
MladostTrackField100m
Mladost Track Field 100m

lat1 = 45,78312417366624
lon1 = 15,942453523323422
lat2 = 45,78222443736099
lon2 = 15,942481190386955
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaParallelMeridians
         CalculateWithRadiusAtLatitude
             distance = 2,144171411091537
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaParallelMeridians
         CalculateSphericalProjectionToPlane
             distance = 2,14545495884224
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaConverginglMeridians
         Calculate
             distance = 100,06925218313263
EuclidianPlanarFlatEarth.Distance
     FederalCommunicationsCommission
         Calculate
             distance = 100,0255546036902
Spherical.Distance
     Haversine
         CalculateMAUI
             distance = 100,06925218313064
Spherical.Distance
     Haversine
         CalculateMAUIOptimized
             distance = 100,06925218313064
Spherical.Distance
     Haversine
         CalculateMAUINonOptimized
             distance = 100,06925218313064
Spherical.Distance
     Haversine
         CalculateCopilot
             distance = 100,06925218313064
Spherical.Distance
     Haversine
         Calculate3
             distance = 100,18121461573814
Spherical.Distance
     Haversine
         Calculate4
             distance = 100,06926745441771
Spherical.Distance
     GreatCircle
         Calculate
             distance = 100,06925218313263
Spherical.Distance
     LawOfCosines
         Calculate
             distance = 100,06923779922066
Spherical.Distance
     EquirectangularPytagoras
         Calculate
             distance = 100,06925218313263
Ellipsoidal.Distance
     Vincenty
         CalculateHeriHermawan
             distance = 99,84532597089613
Ellipsoidal.Distance
     Vincenty
         CalculateIterativeNathanRooyArticle
             distance = 100,02619872435633
========================================================================================================================
DinamoField105m
// Dinamo Field 105m

lat1 = 45,81906101150348
lon1 = 16,017374318970056
lat2 = 45,818160934977485
lon2 = 16,01777597974636
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaParallelMeridians
         CalculateWithRadiusAtLatitude
             distance = 31,108187648746245
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaParallelMeridians
         CalculateSphericalProjectionToPlane
             distance = 31,126875246962197
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaConverginglMeridians
         Calculate
             distance = 104,81271737391532
EuclidianPlanarFlatEarth.Distance
     FederalCommunicationsCommission
         Calculate
             distance = 104,79808887086628
Spherical.Distance
     Haversine
         CalculateMAUI
             distance = 104,8127173735086
Spherical.Distance
     Haversine
         CalculateMAUIOptimized
             distance = 104,8127173735086
Spherical.Distance
     Haversine
         CalculateMAUINonOptimized
             distance = 104,8127173735086
Spherical.Distance
     Haversine
         CalculateCopilot
             distance = 104,8127173735086
Spherical.Distance
     Haversine
         Calculate3
             distance = 104,9299870297649
Spherical.Distance
     Haversine
         Calculate4
             distance = 104,81272280883654
Spherical.Distance
     GreatCircle
         Calculate
             distance = 104,81271737391532
Spherical.Distance
     LawOfCosines
         Calculate
             distance = 104,81271228613357
Spherical.Distance
     EquirectangularPytagoras
         Calculate
             distance = 104,81271737391532
Ellipsoidal.Distance
     Vincenty
         CalculateHeriHermawan
             distance = 104,57817664982737
Ellipsoidal.Distance
     Vincenty
         CalculateIterativeNathanRooyArticle
             distance = 104,79841898638729
========================================================================================================================
SveticeTrackField100m
Svetice Track Field 100m
// yella dots
lat1 = 45,81790486243052
lon1 = 16,01416600446859
lat2 = 45,81700539852965
lon2 = 16,014193032031084
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaParallelMeridians
         CalculateWithRadiusAtLatitude
             distance = 2,093299322043384
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaParallelMeridians
         CalculateSphericalProjectionToPlane
             distance = 2,0945566862491383
EuclidianPlanarFlatEarth.Distance
     PythagoreanFormulaConverginglMeridians
         Calculate
             distance = 100,03789048833602
EuclidianPlanarFlatEarth.Distance
     FederalCommunicationsCommission
         Calculate
             distance = 99,99481753899401
Spherical.Distance
     Haversine
         CalculateMAUI
             distance = 100,03789048833411
Spherical.Distance
     Haversine
         CalculateMAUIOptimized
             distance = 100,03789048833411
Spherical.Distance
     Haversine
         CalculateMAUINonOptimized
             distance = 100,03789048833411
Spherical.Distance
     Haversine
         CalculateCopilot
             distance = 100,03789048833411
Spherical.Distance
     Haversine
         Calculate3
             distance = 100,14981783192513
Spherical.Distance
     Haversine
         Calculate4
             distance = 100,03787703179454
Spherical.Distance
     GreatCircle
         Calculate
             distance = 100,03789048833602
Spherical.Distance
     LawOfCosines
         Calculate
             distance = 100,03789026999284
Spherical.Distance
     EquirectangularPytagoras
         Calculate
             distance = 100,03789048833602
Ellipsoidal.Distance
     Vincenty
         CalculateHeriHermawan
             distance = 99,81403445494868
Ellipsoidal.Distance
     Vincenty
         CalculateIterativeNathanRooyArticle
             distance = 99,99545476570887
```

## Benchmarks

### 20250616

```
Cvjetko_Milas

BenchmarkDotNet=v0.13.5, OS=macOS 15.5 (24F74) [Darwin 24.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK=10.0.100-preview.5.25277.114
  [Host]     : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
```


|                                                                                                    Method |       Mean |     Error |    StdDev |     Median | Allocated |
|---------------------------------------------------------------------------------------------------------- |-----------:|----------:|----------:|-----------:|----------:|
|       EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateWithRadiusAtLatitude |  19.197 ns | 0.4009 ns | 1.1175 ns |  19.518 ns |         - |
| EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateSphericalProjectionToPlane |   6.885 ns | 0.0266 ns | 0.0249 ns |   6.883 ns |         - |
|                        EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaConverginglMeridians_Calculate |   7.250 ns | 0.0821 ns | 0.0768 ns |   7.229 ns |         - |
|                               EuclidianPlanarFlatEarth_Distance_FederalCommunicationsCommission_Calculate |  29.438 ns | 0.2906 ns | 0.2718 ns |  29.505 ns |         - |
|                                                             Spherical_Distance_Haversine_CalculateCopilot |  31.936 ns | 0.0674 ns | 0.0631 ns |  31.941 ns |         - |
|                                                                Spherical_Distance_Haversine_CalculateMAUI |  26.732 ns | 0.0829 ns | 0.0775 ns |  26.721 ns |         - |
|                                                       Spherical_Distance_Haversine_CalculateMAUIOptimized |  27.514 ns | 0.0601 ns | 0.0562 ns |  27.512 ns |         - |
|                                                                   Spherical_Distance_Haversine_Calculate3 |  69.120 ns | 0.2101 ns | 0.1966 ns |  69.119 ns |         - |
|                                                                   Spherical_Distance_Haversine_Calculate4 |  28.072 ns | 0.0670 ns | 0.0560 ns |  28.065 ns |         - |
|                                                                  Spherical_Distance_GreatCircle_Calculate |   7.067 ns | 0.0253 ns | 0.0225 ns |   7.075 ns |         - |
|                                                                 Spherical_Distance_LawOfCosines_Calculate |  37.368 ns | 0.1788 ns | 0.1672 ns |  37.338 ns |         - |
|                                                     Spherical_Distance_EquirectangularPytagoras_Calculate |   7.911 ns | 0.0238 ns | 0.0211 ns |   7.911 ns |         - |
|                                                       Ellipsoidal_Distance_Vincenty_CalculateHeriHermawan |  31.578 ns | 0.1067 ns | 0.0998 ns |  31.554 ns |         - |
|                                         Ellipsoidal_Distance_Vincenty_CalculateIterativeNathanRooyArticle | 231.523 ns | 0.1930 ns | 0.1711 ns | 231.495 ns |         - |



```
Kombi

BenchmarkDotNet=v0.13.5, OS=macOS 15.5 (24F74) [Darwin 24.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK=10.0.100-preview.5.25277.114
  [Host]     : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
```


|                                                                                                    Method |       Mean |     Error |    StdDev | Allocated |
|---------------------------------------------------------------------------------------------------------- |-----------:|----------:|----------:|----------:|
|       EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateWithRadiusAtLatitude |  19.575 ns | 0.0299 ns | 0.0279 ns |         - |
| EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateSphericalProjectionToPlane |   6.926 ns | 0.0226 ns | 0.0212 ns |         - |
|                        EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaConverginglMeridians_Calculate |   7.146 ns | 0.0241 ns | 0.0226 ns |         - |
|                               EuclidianPlanarFlatEarth_Distance_FederalCommunicationsCommission_Calculate |  29.093 ns | 0.0874 ns | 0.0775 ns |         - |
|                                                             Spherical_Distance_Haversine_CalculateCopilot |  31.963 ns | 0.0640 ns | 0.0598 ns |         - |
|                                                                Spherical_Distance_Haversine_CalculateMAUI |  26.736 ns | 0.0352 ns | 0.0312 ns |         - |
|                                                       Spherical_Distance_Haversine_CalculateMAUIOptimized |  26.855 ns | 0.0610 ns | 0.0570 ns |         - |
|                                                                   Spherical_Distance_Haversine_Calculate3 |  66.913 ns | 0.3198 ns | 0.2992 ns |         - |
|                                                                   Spherical_Distance_Haversine_Calculate4 |  27.933 ns | 0.0536 ns | 0.0475 ns |         - |
|                                                                  Spherical_Distance_GreatCircle_Calculate |   7.130 ns | 0.0207 ns | 0.0194 ns |         - |
|                                                                 Spherical_Distance_LawOfCosines_Calculate |  37.206 ns | 0.1520 ns | 0.1422 ns |         - |
|                                                     Spherical_Distance_EquirectangularPytagoras_Calculate |   7.951 ns | 0.0246 ns | 0.0218 ns |         - |
|                                                       Ellipsoidal_Distance_Vincenty_CalculateHeriHermawan |  31.577 ns | 0.0947 ns | 0.0886 ns |         - |
|                                         Ellipsoidal_Distance_Vincenty_CalculateIterativeNathanRooyArticle | 169.462 ns | 0.4309 ns | 0.4031 ns |         - |


```
NathanRooy

BenchmarkDotNet=v0.13.5, OS=macOS 15.5 (24F74) [Darwin 24.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK=10.0.100-preview.5.25277.114
  [Host]     : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
```

|                                                                                                    Method |       Mean |     Error |    StdDev | Allocated |
|---------------------------------------------------------------------------------------------------------- |-----------:|----------:|----------:|----------:|
|       EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateWithRadiusAtLatitude |  14.466 ns | 0.0799 ns | 0.0747 ns |         - |
| EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateSphericalProjectionToPlane |   4.864 ns | 0.0093 ns | 0.0082 ns |         - |
|                        EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaConverginglMeridians_Calculate |   5.091 ns | 0.0105 ns | 0.0098 ns |         - |
|                               EuclidianPlanarFlatEarth_Distance_FederalCommunicationsCommission_Calculate |  27.616 ns | 0.0614 ns | 0.0544 ns |         - |
|                                                             Spherical_Distance_Haversine_CalculateCopilot |  26.965 ns | 0.0537 ns | 0.0502 ns |         - |
|                                                                Spherical_Distance_Haversine_CalculateMAUI |  23.254 ns | 0.0540 ns | 0.0505 ns |         - |
|                                                       Spherical_Distance_Haversine_CalculateMAUIOptimized |  24.042 ns | 0.0502 ns | 0.0469 ns |         - |
|                                                                   Spherical_Distance_Haversine_Calculate3 |  61.723 ns | 0.2110 ns | 0.1871 ns |         - |
|                                                                   Spherical_Distance_Haversine_Calculate4 |  23.587 ns | 0.0647 ns | 0.0605 ns |         - |
|                                                                  Spherical_Distance_GreatCircle_Calculate |   5.040 ns | 0.0162 ns | 0.0151 ns |         - |
|                                                                 Spherical_Distance_LawOfCosines_Calculate |  28.558 ns | 0.1426 ns | 0.1333 ns |         - |
|                                                     Spherical_Distance_EquirectangularPytagoras_Calculate |   5.934 ns | 0.0118 ns | 0.0105 ns |         - |
|                                                       Ellipsoidal_Distance_Vincenty_CalculateHeriHermawan |  26.540 ns | 0.0545 ns | 0.0509 ns |         - |
|                                         Ellipsoidal_Distance_Vincenty_CalculateIterativeNathanRooyArticle | 145.635 ns | 0.3237 ns | 0.3027 ns |         - |


```
Seat

BenchmarkDotNet=v0.13.5, OS=macOS 15.5 (24F74) [Darwin 24.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK=10.0.100-preview.5.25277.114
  [Host]     : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
```

|                                                                                                    Method |       Mean |     Error |    StdDev | Allocated |
|---------------------------------------------------------------------------------------------------------- |-----------:|----------:|----------:|----------:|
|       EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateWithRadiusAtLatitude |  19.535 ns | 0.0544 ns | 0.0509 ns |         - |
| EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateSphericalProjectionToPlane |   6.945 ns | 0.0246 ns | 0.0230 ns |         - |
|                        EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaConverginglMeridians_Calculate |   7.140 ns | 0.0249 ns | 0.0233 ns |         - |
|                               EuclidianPlanarFlatEarth_Distance_FederalCommunicationsCommission_Calculate |  29.072 ns | 0.0456 ns | 0.0404 ns |         - |
|                                                             Spherical_Distance_Haversine_CalculateCopilot |  31.945 ns | 0.0763 ns | 0.0676 ns |         - |
|                                                                Spherical_Distance_Haversine_CalculateMAUI |  26.707 ns | 0.0502 ns | 0.0445 ns |         - |
|                                                       Spherical_Distance_Haversine_CalculateMAUIOptimized |  26.755 ns | 0.0242 ns | 0.0215 ns |         - |
|                                                                   Spherical_Distance_Haversine_Calculate3 |  69.118 ns | 0.1155 ns | 0.1024 ns |         - |
|                                                                   Spherical_Distance_Haversine_Calculate4 |  27.913 ns | 0.0465 ns | 0.0388 ns |         - |
|                                                                  Spherical_Distance_GreatCircle_Calculate |   7.047 ns | 0.0214 ns | 0.0200 ns |         - |
|                                                                 Spherical_Distance_LawOfCosines_Calculate |  37.015 ns | 0.1485 ns | 0.1390 ns |         - |
|                                                     Spherical_Distance_EquirectangularPytagoras_Calculate |   7.951 ns | 0.0259 ns | 0.0242 ns |         - |
|                                                       Ellipsoidal_Distance_Vincenty_CalculateHeriHermawan |  31.454 ns | 0.1921 ns | 0.1797 ns |         - |
|                                         Ellipsoidal_Distance_Vincenty_CalculateIterativeNathanRooyArticle | 169.186 ns | 0.3190 ns | 0.2984 ns |         - |


```
MladostTrackField100m

BenchmarkDotNet=v0.13.5, OS=macOS 15.5 (24F74) [Darwin 24.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK=10.0.100-preview.5.25277.114
  [Host]     : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
```

|                                                                                                    Method |       Mean |     Error |    StdDev | Allocated |
|---------------------------------------------------------------------------------------------------------- |-----------:|----------:|----------:|----------:|
| EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateSphericalProjectionToPlane |   6.883 ns | 0.0363 ns | 0.0339 ns |         - |
|                                                                  Spherical_Distance_GreatCircle_Calculate |   7.053 ns | 0.0383 ns | 0.0358 ns |         - |
|                        EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaConverginglMeridians_Calculate |   7.185 ns | 0.0256 ns | 0.0240 ns |         - |
|                                                     Spherical_Distance_EquirectangularPytagoras_Calculate |   8.052 ns | 0.0221 ns | 0.0196 ns |         - |
|       EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateWithRadiusAtLatitude |  19.270 ns | 0.0721 ns | 0.0674 ns |         - |
|                                                                Spherical_Distance_Haversine_CalculateMAUI |  26.750 ns | 0.0752 ns | 0.0703 ns |         - |
|                                                       Spherical_Distance_Haversine_CalculateMAUIOptimized |  26.878 ns | 0.0557 ns | 0.0521 ns |         - |
|                                                                   Spherical_Distance_Haversine_Calculate4 |  27.945 ns | 0.1053 ns | 0.0985 ns |         - |
|                               EuclidianPlanarFlatEarth_Distance_FederalCommunicationsCommission_Calculate |  29.246 ns | 0.1001 ns | 0.0936 ns |         - |
|                                                       Ellipsoidal_Distance_Vincenty_CalculateHeriHermawan |  31.481 ns | 0.1290 ns | 0.1207 ns |         - |
|                                                             Spherical_Distance_Haversine_CalculateCopilot |  31.836 ns | 0.1139 ns | 0.1066 ns |         - |
|                                                                 Spherical_Distance_LawOfCosines_Calculate |  37.053 ns | 0.2078 ns | 0.1944 ns |         - |
|                                                                   Spherical_Distance_Haversine_Calculate3 |  68.534 ns | 0.2777 ns | 0.2597 ns |         - |
|                                         Ellipsoidal_Distance_Vincenty_CalculateIterativeNathanRooyArticle | 170.160 ns | 0.9136 ns | 0.8546 ns |         - |


```
DinamoField105m

BenchmarkDotNet=v0.13.5, OS=macOS 15.5 (24F74) [Darwin 24.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK=10.0.100-preview.5.25277.114
  [Host]     : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
```

|                                                                                                    Method |       Mean |     Error |    StdDev | Allocated |
|---------------------------------------------------------------------------------------------------------- |-----------:|----------:|----------:|----------:|
| EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateSphericalProjectionToPlane |   6.957 ns | 0.0490 ns | 0.0458 ns |         - |
|                                                                  Spherical_Distance_GreatCircle_Calculate |   7.004 ns | 0.0344 ns | 0.0321 ns |         - |
|                        EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaConverginglMeridians_Calculate |   7.155 ns | 0.0316 ns | 0.0296 ns |         - |
|                                                     Spherical_Distance_EquirectangularPytagoras_Calculate |   7.868 ns | 0.0070 ns | 0.0065 ns |         - |
|       EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateWithRadiusAtLatitude |  19.546 ns | 0.0743 ns | 0.0695 ns |         - |
|                                                                Spherical_Distance_Haversine_CalculateMAUI |  26.793 ns | 0.1051 ns | 0.0877 ns |         - |
|                                                       Spherical_Distance_Haversine_CalculateMAUIOptimized |  26.793 ns | 0.1081 ns | 0.1011 ns |         - |
|                                                                   Spherical_Distance_Haversine_Calculate4 |  27.845 ns | 0.1077 ns | 0.1008 ns |         - |
|                               EuclidianPlanarFlatEarth_Distance_FederalCommunicationsCommission_Calculate |  29.064 ns | 0.1218 ns | 0.1017 ns |         - |
|                                                       Ellipsoidal_Distance_Vincenty_CalculateHeriHermawan |  31.262 ns | 0.0949 ns | 0.0888 ns |         - |
|                                                             Spherical_Distance_Haversine_CalculateCopilot |  31.882 ns | 0.1341 ns | 0.1120 ns |         - |
|                                                                 Spherical_Distance_LawOfCosines_Calculate |  37.382 ns | 0.1374 ns | 0.1285 ns |         - |
|                                                                   Spherical_Distance_Haversine_Calculate3 |  68.356 ns | 0.3388 ns | 0.3169 ns |         - |
|                                         Ellipsoidal_Distance_Vincenty_CalculateIterativeNathanRooyArticle | 230.994 ns | 0.9708 ns | 0.9081 ns |         - |


```
SveticeTrackField100m

BenchmarkDotNet=v0.13.5, OS=macOS 15.5 (24F74) [Darwin 24.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK=10.0.100-preview.5.25277.114
  [Host]     : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
```

|                                                                                                    Method |       Mean |     Error |    StdDev | Allocated |
|---------------------------------------------------------------------------------------------------------- |-----------:|----------:|----------:|----------:|
| EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateSphericalProjectionToPlane |   6.901 ns | 0.0282 ns | 0.0236 ns |         - |
|                                                                  Spherical_Distance_GreatCircle_Calculate |   7.056 ns | 0.0376 ns | 0.0352 ns |         - |
|                        EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaConverginglMeridians_Calculate |   7.169 ns | 0.0386 ns | 0.0361 ns |         - |
|                                                     Spherical_Distance_EquirectangularPytagoras_Calculate |   7.949 ns | 0.0119 ns | 0.0105 ns |         - |
|       EuclidianPlanarFlatEarth_Distance_PythagoreanFormulaParallelMeridians_CalculateWithRadiusAtLatitude |  19.293 ns | 0.0743 ns | 0.0695 ns |         - |
|                                                                Spherical_Distance_Haversine_CalculateMAUI |  26.747 ns | 0.1310 ns | 0.1225 ns |         - |
|                                                       Spherical_Distance_Haversine_CalculateMAUIOptimized |  26.799 ns | 0.1374 ns | 0.1285 ns |         - |
|                                                                   Spherical_Distance_Haversine_Calculate4 |  27.758 ns | 0.1473 ns | 0.1378 ns |         - |
|                               EuclidianPlanarFlatEarth_Distance_FederalCommunicationsCommission_Calculate |  29.150 ns | 0.1504 ns | 0.1407 ns |         - |
|                                                       Ellipsoidal_Distance_Vincenty_CalculateHeriHermawan |  31.659 ns | 0.0702 ns | 0.0622 ns |         - |
|                                                             Spherical_Distance_Haversine_CalculateCopilot |  31.930 ns | 0.1231 ns | 0.1152 ns |         - |
|                                                                 Spherical_Distance_LawOfCosines_Calculate |  37.064 ns | 0.0921 ns | 0.0862 ns |         - |
|                                                                   Spherical_Distance_Haversine_Calculate3 |  69.606 ns | 0.2221 ns | 0.2077 ns |         - |
|                                         Ellipsoidal_Distance_Vincenty_CalculateIterativeNathanRooyArticle | 169.910 ns | 0.9098 ns | 0.8510 ns |         - |

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
