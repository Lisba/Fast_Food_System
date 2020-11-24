using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entities;

namespace Tests
{
    [TestClass]
    public class StringsValidations
    {
        [TestMethod]
        public void TestValidateStringValid()
        {
            string testString = "Go";

            bool actualBool = Validations.ValidateString(testString);

            Assert.IsTrue(actualBool);
        }
        
        [TestMethod]
        public void TestValidateStringInvalid()
        {
            string testString = "A";

            bool actualBool = Validations.ValidateString(testString);

            Assert.IsFalse(actualBool);
        }
    }
}
