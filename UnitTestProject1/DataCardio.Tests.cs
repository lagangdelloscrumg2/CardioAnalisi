using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio.Tests
{
    [TestClass]
    public class UnitTest1
    {
        //test primo metodo

        [TestMethod]
        public void TestMethod1()
        {
            int età;
            string exp;
            string obt;

            //valore casuale
            età = 21;
            exp = "la frequenza massima efficace è 179, quella minima è 139";
            obt =  CardioLibrary.DataCardio.Metodo1(età);
            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void TestMethod1_1()
        {
            int età;
            string exp;
            string obt;

            //valore negativo
            età = -21;
            exp = "inserire un numero maggiore di zero";
            obt = CardioLibrary.DataCardio.Metodo1(età);
            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void TestMethod1_2()
        {
            int età;
            string exp;
            string obt;

            //valore troppo grande
            età = 221;
            exp = "inserire un numero minore di 130";
            obt = CardioLibrary.DataCardio.Metodo1(età);
            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void TestMethod1_3()
        {
            int età;
            string exp;
            string obt;

            //valore appena troppo grande
            età = 130;
            exp = "inserire un numero minore di 130";
            obt = CardioLibrary.DataCardio.Metodo1(età);
            Assert.AreEqual(obt, exp);
        }

        //test secondo metodo
        [TestMethod]
        public void TestMethod2()
        {
            int battiti;
            string exp;
            string obt;

            //valore brachicardico
            battiti = 59;
            exp = "brachicardia";
            obt = CardioLibrary.DataCardio.Metodo2(battiti);
            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void TestMethod2_1()
        {
            int battiti;
            string exp;
            string obt;

            //valore normale
            battiti = 65;
            exp = "normale";
            obt = CardioLibrary.DataCardio.Metodo2(battiti);
            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void TestMethod2_2()
        {
            int battiti;
            string exp;
            string obt;

            //valore tachicardico
            battiti = 111;
            exp = "tachicardia";
            obt = CardioLibrary.DataCardio.Metodo2(battiti);
            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void TestMethod2_3()
        {
            int battiti;
            string exp;
            string obt;

            //valore negativo
            battiti = -59;
            exp = "inserire un valore maggiore di zero";
            obt = CardioLibrary.DataCardio.Metodo2(battiti);
            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void TestMethod2_4()
        {
            int battiti;
            string exp;
            string obt;

            //valore tropp grande
            battiti = 500;
            exp = "inserire un valore ragionevole";
            obt = CardioLibrary.DataCardio.Metodo2(battiti);
            Assert.AreEqual(obt, exp);
        }


    }
}
