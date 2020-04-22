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
            //Arrange
            Wagon wagon = new Wagon();

            //Act

            //Assert
            Assert.IsNotNull(wagon);
            Assert.AreEqual(0, wagon.Plaats);
        }

        [TestMethod]
        public void AddAnimalToWagon()
        {
            //Arrange
            Wagon wagon = new Wagon();

            //Bij 'false' kijkt of het dier VleesEter is of niet, 'nvt' is naam van het dier.
            Animal plant = new Animal(GrootteTypes.Klein, false, "KleinPlantenEtendeDier");
            Animal vlees = new Animal(GrootteTypes.Groot, true, "GrootVleesEtendeDier");
            wagon.AddAnimal(vlees);

            //Act
            bool shouldBeFalse = wagon.AddAnimal(plant);

            //Assert
            Assert.AreEqual(false, shouldBeFalse);
        }


    }
}
