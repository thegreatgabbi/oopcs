using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lecture4;

namespace Lecture4Tests
{
    [TestClass]
    public class MonetaryCoinAppTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            MonetaryCoin C1 = new MonetaryCoin(50, "Singapore");
            MonetaryCoin C2 = new MonetaryCoin(10, "Singapore");
            MonetaryCoin C3 = new MonetaryCoin(50, "US");

            Assert.AreEqual(C2.GetCountry(), "Singapore");
            Console.WriteLine(C2.GetValue());
            Console.WriteLine(C3.GetCountry());
            Console.WriteLine(C1.GetFace());
            Console.WriteLine(C2.GetFace());
            C2.Flip();
            Console.WriteLine(C2.GetFace());
        }
    }
}
