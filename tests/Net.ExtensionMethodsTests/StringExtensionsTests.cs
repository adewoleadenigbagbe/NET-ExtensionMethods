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
    public class StringExtensionsTests
    {
        [TestMethod()]
        public void Should_Be_True_When_String_Is_Null()
        {
            //Arrange
            string word = null;

            //Act
            var isNull = word.IsNullOrEmpty();

            //Assert
           Assert.AreEqual(true, isNull);
        }

        [TestMethod()]
        public void Should_Be_True_When_String_Is_Empty()
        {
            //Arrange
            string word = string.Empty;

            //Act
            var isNull = word.IsNullOrEmpty();

            //Assert
            Assert.AreEqual(true, isNull);
        }

        [TestMethod()]
        public void Should_Be_False_When_String_Is_Not_Empty()
        {
            //Arrange
            string word = "Hey there";

            //Act
            var isNull = word.IsNullOrEmpty();

            //Assert
            Assert.AreEqual(false, isNull);
        }

    }
}