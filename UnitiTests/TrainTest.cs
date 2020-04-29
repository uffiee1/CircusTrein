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
            Train train = new Train();

            Animal animal1 = new Animal(GrootteTypes.Geen, false, "nvt");
            Animal animal2 = new Animal(GrootteTypes.Middelgroot, false, "MiddelgrootDier");
            Animal animal3 = new Animal(GrootteTypes.Klein, true, "KleinVleesEterDier");

            train.AnimalToNewWagon(animal1);
            train.AnimalToNewWagon(animal2);
            train.AnimalToNewWagon(animal3);

            Assert.AreEqual(3, train.Wagons.Count);
        }

        //[TestMethod]
        //public void AlgoritmeTest()
        //{
        //    //Arrange
        //    Train train = new Train();
        //    List<Animal> Animals = new List<Animal>();
        //    int expectedRemainingPlaats = 7;

        //    // 5 Plaats over
        //    Animals.Add(new Animal(GrootteTypes.Groot, true, "GrootVleesEterDier"));

        //    ////

        //    // Maak 10 Kleine PlantEneters
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Animals.Add(new Animal(GrootteTypes.Klein, false, "KleinPlantEterDier"));
        //    }

        //    ////

        //    // 2 Plaats over
        //    Animals.Add(new Animal(GrootteTypes.Groot, false, "GrootPlantEterDier"));
        //    Animals.Add(new Animal(GrootteTypes.Middelgroot, true, "MiddelgrootVleesEterDier"));

        //    //Act
        //    train.FillWagons(Animals);

        //    int RemainingPlaats = train.Wagons.Sum(Wagon => Wagon.Plaats);

        //    //Assert
        //    //Assert.AreEqual(2, wagon);
        //    Assert.AreEqual(expectedRemainingPlaats, RemainingPlaats);
        //}
    }
}
