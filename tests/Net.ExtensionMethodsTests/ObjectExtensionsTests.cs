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
    public class ObjectExtensionsTests
    {
        [TestMethod()]
        public void Should_Convert_Object_To_String()
        {
            //Arrange
            object obj1 = "A book";

            //Act
            var str1 = obj1.ConvertToType<string>();

            //Assert
            Assert.AreEqual(str1.GetType(), typeof(string));

        }

        [TestMethod()]
        public void Should_Convert_Object_To_Int()
        {
            //Arrange
            object obj1 = 34;

            //Act
            var num = obj1.ConvertToAnyType<int>();

            //Assert
            Assert.AreEqual(num.GetType(), typeof(int));

        }
    }
}