using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio.Tests
{
    [TestClass]
    public class UnitTest1
    {
        //test primo metodo, deve poter calcolare le frequanze massima e minima per un allenamento efficace

        [TestMethod]
        public void TestMethod1()
        {
            //inizializzazione variabili
            //variabili di calcolo
            int età;
            //risultato previsto
            string exp;
            //risultato del metodo
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
            //inizializzazione variabili
            //variabili di calcolo
            int età;
            //risultato previsto
            string exp;
            //risultato del metodo
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
            //inizializzazione variabili
            //variabili di calcolo
            int età;
            //risultato previsto
            string exp;
            //risultato del metodo
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
            //inizializzazione variabili
            //variabili di calcolo
            int età;
            //risultato previsto
            string exp;
            //risultato del metodo
            string obt;

            //valore appena troppo grande
            età = 130;
            exp = "inserire un numero minore di 130";
            obt = CardioLibrary.DataCardio.Metodo1(età);
            Assert.AreEqual(obt, exp);
        }

        //test secondo metodo deve capire se il soggeto analizzato sia brachicardico, abbia un battito normale o sia tachicardico
        [TestMethod]
        public void TestMethod2()
        {
            //inizializzazione variabili
            //variabili di calcolo
            int battiti;
            //risultato previsto
            string exp;
            //risultato del metodo
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
            //inizializzazione variabili
            //variabili di calcolo
            int battiti;
            //risultato previsto
            string exp;
            //risultato del metodo
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
            //inizializzazione variabili
            //variabili di calcolo
            int battiti;
            //risultato previsto
            string exp;
            //risultato del metodo
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
            //inizializzazione variabili
            //variabili di calcolo
            int battiti;
            //risultato previsto
            string exp;
            //risultato del metodo
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
            //inizializzazione variabili
            //variabili di calcolo
            int battiti;
            //risultato previsto
            string exp;
            //risultato del metodo
            string obt;

            //valore troppo grande
            battiti = 500;
            exp = "inserire un valore ragionevole";
            obt = CardioLibrary.DataCardio.Metodo2(battiti);
            Assert.AreEqual(obt, exp);
        }

        //test terzo metodo, deve calcolare le calorie bruciate
        [TestMethod]
        public void TestMethod3()
        {
            //inizializzazione variabili
            //risultato previsto
            string exp;
            //risultato del metodo
            string obt;

            //variabili di calcolo
            char sesso='M';
            double freq =100 ;
            double peso = 80;
            double età = 27;
            double tempo = 45;

            exp = "318,377";
            obt = CardioLibrary.DataCardio.Metodo3(sesso, freq, peso,  età, tempo);

            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void TestMethod3_1()
        {
            //inizializzazione variabili
            //risultato previsto
            string exp;
            //risultato del metodo
            string obt;

            //variabili di calcolo
            char sesso = 'F';
            double freq = 100;
            double peso = 80;
            double età = 27;
            double tempo = 45;

            exp = "174,62";
            obt = CardioLibrary.DataCardio.Metodo3(sesso, freq, peso, età, tempo);

            Assert.AreEqual(obt, exp);
        }
    }
}
