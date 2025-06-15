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
