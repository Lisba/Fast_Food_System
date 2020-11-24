using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entities;

namespace Tests
{
    [TestClass]
    public class NumbersValidations
    {
        [TestMethod]
        public void TestValidateIntValid()
        {
            string testString = "123";
            int expectedInt = 123;

            int actualInt = Validations.ValidateInt(testString);

            Assert.AreEqual(expectedInt, actualInt);
        }
        
        [TestMethod]
        public void TestValidateIntInvalid()
        {
            string testString = "19A";
            int expectedInt = -1;

            int actualInt = Validations.ValidateInt(testString);

            Assert.AreEqual(expectedInt, actualInt);
        }
        
        [TestMethod]
        public void TestValidateDoubleValid()
        {
            string testString = "12,4";
            double expectedInt = 12.4;

            double actualInt = Validations.ValidateDouble(testString);

            Assert.AreEqual(expectedInt, actualInt);
        }

        [TestMethod]
        public void TestValidateDoubleInvalid()
        {
            string testString = "A23";
            double expectedInt = -1;

            double actualInt = Validations.ValidateDouble(testString);

            Assert.AreEqual(expectedInt, actualInt);
        }
    }
}
