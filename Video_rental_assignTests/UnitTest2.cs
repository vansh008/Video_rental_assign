using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Video_rental_assignTests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Video_rental_assign.Task.Rental obj = new Video_rental_assign.Task.Rental();
            if (obj.delRental(1))
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }
    }
}
