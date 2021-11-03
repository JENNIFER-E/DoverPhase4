using NUnit.Framework;
using PizzaOnlineStore;
using PizzaOnlineStore.Models;
using System;
using System.Collections.Generic;

namespace NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckingPizzaCount()
        {
            var PizzaStore = new PizzaBO();
            int expectedVal = 10;
            int actualVal = PizzaStore.GetPizzas().Count;
            Assert.AreEqual( expectedVal,actualVal);
        }
        [Test]
        public void CheckingPizzaCategory()
        {
            var PizzaStore = new PizzaBO();
            var expectedVal = new List<String>{ "Vegetarian", "Non-Vegetarian" };
            var actualVal = PizzaStore.GetPizzaCategories();
            Assert.AreEqual(expectedVal, actualVal);
        }
        [Test]
        public void CheckingPizzaPriceById()
        {
            var PizzaStore = new PizzaBO();
            int expectedVal = 200;
            float actualVal = PizzaStore.GetPizzabyId(1).price;
            Assert.AreEqual(expectedVal, actualVal);
        }
        [Test]
        public void CheckingPizzaPriceByIdFail()
        {
            var PizzaStore = new PizzaBO();
            int expectedVal = 250;
            float actualVal = PizzaStore.GetPizzabyId(1).price;
            Assert.AreEqual(expectedVal, actualVal);
        }
    }
}