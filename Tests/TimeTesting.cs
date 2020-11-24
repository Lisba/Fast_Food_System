using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entities;

namespace Tests
{
    [TestClass]
    public class TimeTesting
    {
        [TestMethod]
        [Timeout(80)]
        public void TestTimeDelay()
        {
            ShopCar.GetTotalPrice();   
        }
    }
}
