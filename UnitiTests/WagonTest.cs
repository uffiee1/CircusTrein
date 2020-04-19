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
            Assert.AreEqual(6, wagon.Plaats);
        }

        [TestMethod]
        public void AddAnimalToWagon()
        {
            //Arrange
            Wagon wagon = new Wagon();

            //Bij 'false' kijkt of het dier VleesEter is of niet, 'nvt' is naam van het dier.
            Animal plant = new Animal(Animal.GrootteTypes.Klein, false, "nvt");
            Animal vlees = new Animal(Animal.GrootteTypes.Groot, true, "nvt");
            wagon.AddAnimal(vlees);

            //Act
            bool shouldBeFalse = wagon.AddAnimal(plant);

            //Assert
            Assert.AreEqual(false, shouldBeFalse);
        }
    }
}
