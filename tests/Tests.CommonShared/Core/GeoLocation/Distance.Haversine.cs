using System;
using Xunit;

namespace UnitTests.Core.GeoLocation
{
    public class Test_Distance_Haversine
    {
        [Fact]
        public void Test_Haversine_CalculateMAUI()
        {
            // Test case: Same point should return 0 distance
            double distance = Core.GeoLocation.Earth.Spherical.Distance.Haversine.CalculateMAUI(0, 0, 0, 0);
            Assert.Equal(0.0, distance, 10);

            // Test case: Points on equator with 1 degree difference in longitude (approx 111 km)
            distance = Core.GeoLocation.Earth.Spherical.Distance.Haversine.CalculateMAUI(0, 0, 0, 1);
            Assert.True(distance > 100.0 && distance < 120.0);

            // Test case: Points at same longitude with 1 degree difference in latitude (approx 111 km)
            distance = Core.GeoLocation.Earth.Spherical.Distance.Haversine.CalculateMAUI(0, 0, 1, 0);
            Assert.True(distance > 100.0 && distance < 120.0);
        }

        [Fact]
        public void Test_Haversine_CalculateMAUIOptimized()
        {
            // Test case: Same point should return 0 distance
            double distance = Core.GeoLocation.Earth.Spherical.Distance.Haversine.CalculateMAUIOptimized(0, 0, 0, 0);
            Assert.Equal(0.0, distance, 10);

            // Test case: Points on equator with 1 degree difference in longitude (approx 111 km)
            distance = Core.GeoLocation.Earth.Spherical.Distance.Haversine.CalculateMAUIOptimized(0, 0, 0, 1);
            Assert.True(distance > 100.0 && distance < 120.0);
        }

        [Fact]
        public void Test_Haversine_CalculateMAUINonOptimized()
        {
            // Test case: Same point should return 0 distance
            double distance = Core.GeoLocation.Earth.Spherical.Distance.Haversine.CalculateMAUINonOptimized(0, 0, 0, 0);
            Assert.Equal(0.0, distance, 10);

            // Test case: Points on equator with 1 degree difference in longitude (approx 111 km)
            distance = Core.GeoLocation.Earth.Spherical.Distance.Haversine.CalculateMAUINonOptimized(0, 0, 0, 1);
            Assert.True(distance > 100.0 && distance < 120.0);
        }

        [Fact]
        public void Test_Haversine_CalculateCopilotOptimized()
        {
            // Test case: Same point should return 0 distance
            double distance = Core.GeoLocation.Earth.Spherical.Distance.Haversine.CalculateCopilotOptimized(0, 0, 0, 0);
            Assert.Equal(0.0, distance, 10);

            // Test case: Points on equator with 1 degree difference in longitude (approx 111 km)
            distance = Core.GeoLocation.Earth.Spherical.Distance.Haversine.CalculateCopilotOptimized(0, 0, 0, 1);
            Assert.True(distance > 100.0 && distance < 120.0);
        }

        [Fact]
        public void Test_Haversine_CalculateCopilot()
        {
            // Test case: Same point should return 0 distance
            double distance = Core.GeoLocation.Earth.Spherical.Distance.Haversine.CalculateCopilot(0, 0, 0, 0);
            Assert.Equal(0.0, distance, 10);

            // Test case: Points on equator with 1 degree difference in longitude (approx 111 km)
            distance = Core.GeoLocation.Earth.Spherical.Distance.Haversine.CalculateCopilot(0, 0, 0, 1);
            Assert.True(distance > 100.0 && distance < 120.0);
        }

        [Fact]
        public void Test_Haversine_Calculate3()
        {
            // Test case: Same point should return 0 distance
            double distance = Core.GeoLocation.Earth.Spherical.Distance.Haversine.Calculate3(0, 0, 0, 0);
            Assert.Equal(0.0, distance, 10);

            // Test case: Points on equator with 1 degree difference in longitude (approx 111 km)
            distance = Core.GeoLocation.Earth.Spherical.Distance.Haversine.Calculate3(0, 0, 0, 1);
            Assert.True(distance > 100.0 && distance < 120.0);
        }

        [Fact]
        public void Test_Haversine_Calculate4()
        {
            // Test case: Same point should return 0 distance
            double distance = Core.GeoLocation.Earth.Spherical.Distance.Haversine.Calculate4(0, 0, 0, 0);
            Assert.Equal(0.0, distance, 10);

            // Test case: Points on equator with 1 degree difference in longitude (approx 111 km)
            distance = Core.GeoLocation.Earth.Spherical.Distance.Haversine.Calculate4(0, 0, 0, 1);
            Assert.True(distance > 100.0 && distance < 120.0);
        }
    }
}