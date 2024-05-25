using Microsoft.VisualStudio.TestTools.UnitTesting;
using Net.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.ExtensionMethodsTests
{
    [TestClass()]
    public class DictionaryExtensionsTests
    {
        [TestMethod()]
        public void Should_Get_Default_Value_Test()
        {
            //Arrange
            var key = 1;
            var dictionary = new Dictionary<int, List<int>>
            {
                { key, null }
            };

            //Act
           var value = dictionary.GetOrDefaultValue(key);

            //Asset
            Assert.IsNull(value);
        }

        [TestMethod()]
        public void Should_Get_Value_Test()
        {
            //Arrange
            var key = 1;
            var dictionary = new Dictionary<int, List<int>>
            {
                { key, new List<int>() }
            };

            //Act
            var value = dictionary.GetOrDefaultValue(key);

            //Asset
            Assert.IsNotNull(value);
        }

        [TestMethod()]
        public void Should_Add_Item_ToList_Test()
        {
            //Arrange
            var key = 1;
            var value = 1;
            var dictionary = new Dictionary<int, List<int>>();

            //Act
            dictionary.AddToList(key, value);

            //Asset
            Assert.IsTrue(dictionary.ContainsKey(key));
            Assert.IsTrue(dictionary[key].Contains(value));
        }

        [TestMethod()]
        public void Should_Add_Item_Many_ToList_Test()
        {
            //Arrange
            var key = 1;
            var values = new List<int> { 1, 2, 3, 4 };
            var dictionary = new Dictionary<int, List<int>>();

            //Act
            dictionary.AddManyToList(key, values);

            //Asset
            Assert.IsTrue(dictionary.ContainsKey(key));
            Assert.IsTrue(dictionary[key].Any());
        }

    }
}
