using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Video_rental_assignTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Video_rental_assign.Task.Video obj = new Video_rental_assign.Task.Video();
            if (obj.delVideo(1))
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }

        }
    }
}
