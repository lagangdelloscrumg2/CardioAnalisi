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
            string exp;
            string obt;

            età = 21;
            exp = "la frequenza massima efficace è 179,1, quella minima è 139,3";
            obt =  CardioLibrary.DataCardio.Metodo1(età);
            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void TestMethod1_1()
        {
            int età;
            string exp;
            string obt;

            età = -21;
            exp = "inserire un numero maggiore di zero";
            obt = CardioLibrary.DataCardio.Metodo1(età);
            Assert.AreEqual(obt, exp);
        }
    }
}
