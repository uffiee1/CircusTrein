using System;
using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class WagonTest
    {
        [TestMethod]
        public void WagonFull()
        {
            Wagon wagon = new Wagon();

            Assert.AreEqual(0, wagon.Plaats);
        }

        [TestMethod]
        public void AddTooSmallPlantenEter()
        {
            Wagon wagon = new Wagon();
            Animal plant = new Animal(Animal.GrootteTypes.Klein, false, "nvt");
            Animal vlees = new Animal(Animal.GrootteTypes.Groot, true, "nvt");

            wagon.AddAnimal(vlees);
            bool shouldBeFalse = wagon.AddAnimal(plant);

            Assert.AreEqual(false, shouldBeFalse);
        }
    }
}
