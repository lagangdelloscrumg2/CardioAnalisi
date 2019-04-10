using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int età;
            int exp;
            int obt;

            età = 21;
            exp = 199;
            obt =  CardioLibrary.DataCardio.Metodo1(età);
            Assert.AreEqual(obt, exp);
        }
    }
}
