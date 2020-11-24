using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entities;

namespace Tests
{
    [TestClass]
    public class ExceptionsTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidStringTypeException))]
        public void TestCustomException()
        {
            throw new InvalidStringTypeException("Testing!");
        }
    }
}
