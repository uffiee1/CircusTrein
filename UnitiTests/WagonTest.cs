using System;
using System.Linq;
using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass()]
    public class WagonTests
    {
        [TestMethod()]
        public void WagonTest()
        {
            //Arrange
            Wagon wagon = new Wagon(10, false);

            //Act
            int count = wagon.AnimalToWagon.Count();

            //Assert
            Assert.AreEqual(0, count);
        }

        [TestMethod()]
        public void AddAnimalToWagon()
        {
            //Arrange
            Wagon wagon = new Wagon(10, false);
            Animal animal = new Animal("test", GrootteTypes.Klein, AnimalTypes.VleesEter);

            //Act
            wagon.AddToWagon(animal);
            int count = wagon.AnimalToWagon.Count();

            //Assert
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void CheckWeightIsTrue()
        {
            //Arrange
            //Door de wagen leeg te laten zal de compatibiliteitstest automatisch slagen, dus dit zal alleen gericht zijn op de gewichtstest
            Wagon wagon = new Wagon(6, false);
            Animal animal = new Animal("test", GrootteTypes.Groot, AnimalTypes.PlantenEter);
            //Act
            bool test = wagon.AddToWagon(animal);
            //Assert
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void CheckWeightFalseIsTrue()
        {
            //Arrange
            Wagon wagon = new Wagon(4, false);
            Animal animal = new Animal("test", GrootteTypes.Groot, AnimalTypes.PlantenEter);

            //Act
            bool test = wagon.AddToWagon(animal);

            //Assert
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void CheckCompatibilityTrue()
        {

            //Arrange
            //Door de wagon een enorme capaciteit te geven, kunnen we de gewichtstest veilig omzeilen en hoeven we alleen de compatibiliteitstest te doorstaan.
            //Deze test gaat na of we een grotere PlantenEter kunnen toevoegen aan een wagon met een kleinere VleesEter.
            Wagon wagon = new Wagon(100, false);
            Animal animal = new Animal("test", GrootteTypes.Middelgroot, AnimalTypes.VleesEter);
            Animal animal2 = new Animal("test", GrootteTypes.Groot, AnimalTypes.PlantenEter);

            //Act
            wagon.AddToWagon(animal);
            bool test = wagon.AddToWagon(animal2);

            //Assert
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void CheckCompatibilityFalse()
        {
            //Arrange
            //Door de wagon een enorme capaciteit te geven, kunnen we de gewichtstest veilig omzeilen en hoeven we alleen de compatibiliteitstest te doorstaan.
            //Deze test controleert of de methode voorkomt dat een kleinere PlantenEter wordt toegevoegd aan een wagon met een grotere VleesEter.
            Wagon wagon = new Wagon(100, false);
            Animal animal = new Animal("test", GrootteTypes.Groot, AnimalTypes.VleesEter);
            Animal animal2 = new Animal("test", GrootteTypes.Middelgroot, AnimalTypes.PlantenEter);

            //Act
            wagon.AddToWagon(animal);
            bool test = wagon.AddToWagon(animal2);

            //Assert
            Assert.IsFalse(test);
        }
    }
}
