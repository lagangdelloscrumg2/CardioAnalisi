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
        //test terzo metodo, deve calcolare le calorie bruciate
        [TestMethod]
        public void Test_Kcal_Norm_M()
        {
            //inizializzazione variabili
            //risultato previsto
            string exp;
            //risultato del metodo
            string obt;

            //variabili di calcolo
            char sesso = 'M';
            double freq = 100;
            double peso = 80;
            double età = 27;
            double tempo = 45;

            exp = "318,377";
            obt = CardioLibrary.DataCardio.Kcal(sesso, freq, peso, età, tempo);

            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void Test_Kcal_Norm_F()
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
            obt = CardioLibrary.DataCardio.Kcal(sesso, freq, peso, età, tempo);

            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void Test_Kcal_Sex_NotAcc()
        {
            //inizializzazione variabili
            //risultato previsto
            string exp;
            //risultato del metodo
            string obt;

            //variabili di calcolo
            //sesso non accettabile
            char sesso = 'c';
            double freq = 100;
            double peso = 80;
            double età = 27;
            double tempo = 45;

            exp = "inserire solo 'M' o 'F'";
            obt = CardioLibrary.DataCardio.Kcal(sesso, freq, peso, età, tempo);

            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void Test_Kcal_Freq_Neg()
        {
            //inizializzazione variabili
            //risultato previsto
            string exp;
            //risultato del metodo
            string obt;

            //variabili di calcolo
            char sesso = 'M';
            //frequenza negativa
            double freq = -100;
            double peso = 80;
            double età = 27;
            double tempo = 45;

            exp = "inserire una frequanza accettabile";
            obt = CardioLibrary.DataCardio.Kcal(sesso, freq, peso, età, tempo);

            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void Test_Kcal_Freq_Gran()
        {
            //inizializzazione variabili
            //risultato previsto
            string exp;
            //risultato del metodo
            string obt;

            //variabili di calcolo
            char sesso = 'M';
            //frequenza troppo grande
            double freq = 500;
            double peso = 80;
            double età = 27;
            double tempo = 45;

            exp = "inserire una frequanza accettabile";
            obt = CardioLibrary.DataCardio.Kcal(sesso, freq, peso, età, tempo);

            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void Test_Kcal_Peso_Neg()
        {
            //inizializzazione variabili
            //risultato previsto
            string exp;
            //risultato del metodo
            string obt;

            //variabili di calcolo
            char sesso = 'M';
            double freq = 100;
            //peso negativo
            double peso = -80;
            double età = 27;
            double tempo = 45;

            exp = "inserire un peso accettabile";
            obt = CardioLibrary.DataCardio.Kcal(sesso, freq, peso, età, tempo);

            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void Test_Kcal_Peso_Gran()
        {
            //inizializzazione variabili
            //risultato previsto
            string exp;
            //risultato del metodo
            string obt;

            //variabili di calcolo
            char sesso = 'M';
            double freq = 100;
            //peso troppo grande
            double peso = 800;
            double età = 27;
            double tempo = 45;

            exp = "inserire un peso accettabile";
            obt = CardioLibrary.DataCardio.Kcal(sesso, freq, peso, età, tempo);

            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void Test_Kcal_Eta_Neg()
        {
            //inizializzazione variabili
            //risultato previsto
            string exp;
            //risultato del metodo
            string obt;

            //variabili di calcolo
            char sesso = 'M';
            double freq = 100;
            double peso = 90;
            //età neagtiva
            double età = -27;
            double tempo = 45;

            exp = "inserire un'età accettabile";
            obt = CardioLibrary.DataCardio.Kcal(sesso, freq, peso, età, tempo);

            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void Test_Kcal_Eta_Gran()
        {
            //inizializzazione variabili
            //risultato previsto
            string exp;
            //risultato del metodo
            string obt;

            //variabili di calcolo
            char sesso = 'M';
            double freq = 100;
            double peso = 90;
            //età troppo grande
            double età = 207;
            double tempo = 45;

            exp = "inserire un'età accettabile";
            obt = CardioLibrary.DataCardio.Kcal(sesso, freq, peso, età, tempo);

            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void Test_Kcal_Tampo_Neg()
        {
            //inizializzazione variabili
            //risultato previsto
            string exp;
            //risultato del metodo
            string obt;

            //variabili di calcolo
            char sesso = 'M';
            double freq = 100;
            double peso = 90;
            double età = 27;
            //tempo negativo
            double tempo = -45;

            exp = "inserire un tempo accettabile";
            obt = CardioLibrary.DataCardio.Kcal(sesso, freq, peso, età, tempo);

            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void Test_Kcal_Tampo_Gran()
        {
            //inizializzazione variabili
            //risultato previsto
            string exp;
            //risultato del metodo
            string obt;

            //variabili di calcolo
            char sesso = 'M';
            double freq = 100;
            double peso = 90;
            double età = 27;
            //tempo troppo grande
            double tempo = 450;

            exp = "inserire un tempo accettabile";
            obt = CardioLibrary.DataCardio.Kcal(sesso, freq, peso, età, tempo);

            Assert.AreEqual(obt, exp);
        }



        [TestMethod]
        public void Test_Spesa()
        {
            bool corsa = false;
            bool camminata = true;
            double km = 10;
            double peso = 60;

            double aspettativa = 300;
            double risultato = CardioLibrary.DataCardio.Spesa(corsa, camminata, km, peso);

            Assert.AreEqual(aspettativa, risultato);




        }
        [TestMethod]
        public void Test_Spesa2()
        {
            bool corsa = false;
            bool camminata = true;
            double km = 10;
            double peso = 70;

            double aspettativa = 350;
            double risultato = CardioLibrary.DataCardio.Spesa(corsa, camminata, km, peso);

            Assert.AreEqual(aspettativa, risultato);




        }
        [TestMethod]
        public void Test_Spesa3()
        {
            bool corsa = false;
            bool camminata = true;
            double km = 10;
            double peso = 70;

            double aspettativa = 630;
            double risultato = CardioLibrary.DataCardio.Spesa(corsa, camminata, km, peso);

            Assert.AreEqual(aspettativa, risultato);




        }

    }
}
