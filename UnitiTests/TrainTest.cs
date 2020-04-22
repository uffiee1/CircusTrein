using System;
using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitiTests
{
    [TestClass]
    public class TrainTest
    {
        [TestMethod]
        public void AddWagon()
        {
            Train train = new Train();

            Animal animal1 = new Animal(GrootteTypes.Geen, false, "nvt");
            Animal animal2 = new Animal(GrootteTypes.Middelgroot, false, "MiddelgrootDier");
            Animal animal3 = new Animal(GrootteTypes.Klein, true, "KleinVleesEterDier");

            train.AnimalToNewWagon(animal1);
            train.AnimalToNewWagon(animal2);
            train.AnimalToNewWagon(animal3);

            Assert.AreEqual(3, train.Wagons.Count);
        }
    }
}
