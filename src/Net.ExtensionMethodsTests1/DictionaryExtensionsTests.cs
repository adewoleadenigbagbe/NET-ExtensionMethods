using Microsoft.VisualStudio.TestTools.UnitTesting;
using Net.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.ExtensionMethods.Tests
{
    [TestClass()]
    public class DictionaryExtensionsTests
    {
        [TestMethod()]
        public void AddManyToListTest()
        {
            //Arrange
            var key = 1;
            var value = 1;
            var dictionary = new Dictionary<int, List<int>>();

            //Act
            dictionary.AddToList(key, value);

            //Asset
            Assert.IsTrue(dictionary.ContainsKey(key));
            Assert.AreEqual(value, dictionary[key]);

        }
    }
}