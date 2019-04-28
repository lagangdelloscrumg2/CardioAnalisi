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
        public void Test_Freq_Norm()
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
            obt =  CardioLibrary.DataCardio.Freq(età);
            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void Test_Freq_Neg()
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
            obt = CardioLibrary.DataCardio.Freq(età);
            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void Test_Freq_Gran()
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
            obt = CardioLibrary.DataCardio.Freq(età);
            Assert.AreEqual(obt, exp);
        }

        //test secondo metodo deve capire se il soggeto analizzato sia brachicardico, abbia un battito normale o sia tachicardico
        [TestMethod]
        public void Test_Tipo_Battiti_Brac()
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
            exp = "bradicardia";
            obt = CardioLibrary.DataCardio.Tipo_Battiti(battiti);
            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void Test_Tipo_Battiti_Norm()
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
            obt = CardioLibrary.DataCardio.Tipo_Battiti(battiti);
            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void Test_Tipo_Battiti_tach()
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
            obt = CardioLibrary.DataCardio.Tipo_Battiti(battiti);
            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void Test_Tipo_Battiti_Neg()
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
            obt = CardioLibrary.DataCardio.Tipo_Battiti(battiti);
            Assert.AreEqual(obt, exp);
        }

        [TestMethod]
        public void Test_Tipo_Battiti_Gran()
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
            obt = CardioLibrary.DataCardio.Tipo_Battiti(battiti);
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
            char sesso='M';
            double freq =100 ;
            double peso = 80;
            double età = 27;
            double tempo = 45;

            exp = "318,377";
            obt = CardioLibrary.DataCardio.Kcal(sesso, freq, peso,  età, tempo);

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
    }
}
