using System;
using System.Collections.Generic;
using System.Linq;
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
            //Arrange
            Train train = new Train();

            //Assert
            Assert.IsFalse(train.AddAnimal("test", GrootteTypes.Klein, AnimalTypes.VleesEter));
            Assert.AreEqual(1, train.Wagons.Count);
            Assert.AreEqual(1,train.Wagons[0].AnimalToWagon.Count);
        }

        [TestMethod]
        public void AddNewWagon()
        {
            //Arrange
            Train train = new Train();
            Wagon wagon = new Wagon(3, false);

            //Act
            train.Wagons.Add(wagon);

            //Assert
            Assert.IsFalse(train.AddAnimal("test", GrootteTypes.Groot, AnimalTypes.VleesEter));
            Assert.AreEqual(2,train.Wagons.Count);
            Assert.AreEqual(1, train.Wagons[1].AnimalToWagon.Count);
        }

        [TestMethod()]
        public void AddAnimalIsTrue()
        {
            //Arrange
            Train train = new Train();
            Wagon wagon = new Wagon(10, false);

            //Act
            train.Wagons.Add(wagon);

            //Assert
            train.AddAnimal("test", GrootteTypes.Middelgroot, AnimalTypes.PlantenEter);
            Assert.IsTrue(train.AddAnimal("test", GrootteTypes.Middelgroot, AnimalTypes.PlantenEter));
        }

        [TestMethod()]
        public void AddAnimalIsFalse()
        {
            //Arrange
            Train train = new Train();
            Wagon wagon = new Wagon(10, false);

            //Act
            train.Wagons.Add(wagon);
            train.AddAnimal("test", GrootteTypes.Middelgroot, AnimalTypes.PlantenEter);

            //Assert
            Assert.IsFalse(train.AddAnimal("test", GrootteTypes.Middelgroot, AnimalTypes.VleesEter));
        }
    }
}