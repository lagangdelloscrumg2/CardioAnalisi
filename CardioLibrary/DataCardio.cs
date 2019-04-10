using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioLibrary
{
    public class DataCardio
    {
        public static string Metodo1(int età)
        {
            string analisi = "";
            if (età > 0 && età < 220)
            {
                int Freq_Max;
                Freq_Max = 220 - età;

                double Freq_Max_Eff;
                double Freq_Min_Eff;

                Freq_Max_Eff = Freq_Max * 0.9;
                Freq_Min_Eff = Freq_Max * 0.7;

                analisi = $"la frequenza massima efficace è {Freq_Max_Eff}, quella minima è {Freq_Min_Eff}";
            }
            else if (età <= 0)
                analisi = "inserire un numero maggiore di zero";
            else
                analisi = "inserire un numero minore di 220";

            return analisi;
        }
    }
}
