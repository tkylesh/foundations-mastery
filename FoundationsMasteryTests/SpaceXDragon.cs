using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class SpaceXDragon
    {
        [TestMethod]
        public void EnsureSpaceXDragonInstance()
        {
            SpaceXDragon Dragon = new SpaceXDragon();

            Assert.IsNotNull(Dragon);
        }
    }
}
