﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebGame.PhysicsTest
{
    [TestClass]
    public class AllStopTests
    {
        [TestMethod]
        public void TestAllStop()
        {
            var ship = new Ship(4000);
            Assert.AreEqual(0, ship.VelocityMetersPerSecond.Magnitude(), "new ship wasn't stopped");
            ship.ImpulsePercentage = 100;
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            Assert.AreNotEqual(0, ship.VelocityMetersPerSecond.Magnitude(), "ship wasn't moving, after turning on impulse");
            ship.DesiredOrientation = Math.PI / 2;
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            Assert.AreNotEqual(0, ship.VelocityMetersPerSecond.Magnitude(), "ship wasn't moving before telling it to stop");
            ship.TargetSpeedMetersPerSecond = 0; // all stop
            ship.Update(TimeSpan.FromSeconds(0.25));
            Assert.AreNotEqual(0, ship.VelocityMetersPerSecond.Magnitude(), "ship wasn't moving, just after all stop");
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            Assert.AreEqual(0, ship.VelocityMetersPerSecond.Magnitude(), "ship wasn't stopped long after it should have been.");

        }

        [TestMethod]
        public void TestAllStop5Radians()
        {
            var ship = new Ship(4000);
            Assert.AreEqual(0, ship.VelocityMetersPerSecond.Magnitude(), "new ship wasn't stopped");
            ship.DesiredOrientation = 5;
            ship.Update(TimeSpan.FromSeconds(50));
            Assert.AreEqual(5.0, ship.Orientation, "ship wasn't finished turning");
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.ImpulsePercentage = 100;
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            ship.Update(TimeSpan.FromSeconds(0.25));
            Assert.AreEqual(5, ship.Orientation, "ship turned during acceleration");
            ship.TargetSpeedMetersPerSecond = 0;
            ship.Update(TimeSpan.FromSeconds(0.25));
            Assert.IsTrue(Utility.ApproximatelyEqual(5, ship.Orientation), "ship turned during all stop");
        }
    }
}
