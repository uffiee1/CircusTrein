using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrein;

namespace UnitiTests
{
    [TestClass]
    public class AnimalTest
    {
        [TestMethod]
        public void ToStringTest()
        {
            Animal animal = new Animal(GrootteTypes.Groot, true, "TestGrootVleesEterAnimal");

            Assert.AreEqual("Groot (Vlees)", animal.ToString());
        }
    }
}
