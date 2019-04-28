using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioLibrary
{
    public class DataCardio
    {
        public static string Freq(int età)
        {
            //si inizializza la varaibile del risultato
            string analisi = "";
            //l'età deve avere un valore accettabile
            if (età > 0 && età < 130)
            {
                //si calcola frequenza massima
                int Freq_Max;
                Freq_Max = 220 - età;

                //si calcolano gli estremi delle frequanze per un allenamento efficace
                double Freq_Max_Eff;
                double Freq_Min_Eff;

                Freq_Max_Eff = Freq_Max * 0.9;
                Freq_Min_Eff = Freq_Max * 0.7;
                
                //si mette il risultato in un messaggio
                analisi = $"la frequenza massima efficace è {Convert.ToInt32(Freq_Max_Eff)}, quella minima è {Convert.ToInt32(Freq_Min_Eff)}";
            }
            //messaggi di errore
            else if (età <= 0)
                analisi = "inserire un numero maggiore di zero";
            else
                analisi = "inserire un numero minore di 130";

            return analisi;

        }

        public static string Tipo_Battiti(int battiti)
        {
            //si inizializza la varaibile del risultato
            string analisi = "";
            //i battiti devono avere un valore accettabile
            if (battiti > 0)
            {
                if (battiti < 250)
                {
                    //vari casi in base al valore dato
                    if (battiti < 60)
                        analisi = "bradicardia";
                    else if (battiti >100)
                        analisi = "tachicardia";
                    else
                        analisi = "normale";
                }
                //messaggi di errore
                else
                    analisi = "inserire un valore ragionevole";
            } 
            else
                analisi = "inserire un valore maggiore di zero";
            return analisi;
        }

        public static string Kcal(char sesso, double freq, double peso, double età, double tempo)
        {
            //si inizializza la varaibile del risultato
            string analisi = "";

            if(sesso=='M' || sesso=='F')
            {
                if (freq > 0 && freq < 300)
                {
                    if (peso > 0 && peso < 400)
                    {
                        if (età > 0 && età < 130)
                        {
                            if (tempo > 0 && tempo < 400)
                            {
                                if (sesso == 'F')
                                {
                                    età *= 0.074;
                                    peso *= 0.126;
                                    freq *= 0.4472;
                                    tempo /= 4.184;
                                    //si esegue il calcolo finale arrotndando alla terza cifra
                                    analisi = ( Math.Round( (età - peso + freq - 20.4022) * tempo , 3 ) ).ToString();
                                }
                                else
                                {
                                    età *= 0.2107;
                                    peso *= 0.199;
                                    freq *= 0.6309;
                                    tempo /= 4.184;
                                    //si esegue il calcolo finale arrotndando alla terza cifra
                                    analisi = (Math.Round( (età + peso + freq - 55.0969) * tempo, 3) ).ToString();
                                }
                            }
                            else
                                analisi = "inserire un tempo accettabile";
                        }
                        else
                            analisi = "inserire un'età accettabile";
                    }
                    else
                        analisi = "inserire un peso accettabile";
                }
                else
                    analisi = "inserire una frequanza accettabile";
            }
            else
                analisi = "inserire solo 'M' o 'F'";
            
            return analisi;
        }

        public static string Spesa(double km, double peso, bool corsa, bool camminata)
        {
            //si inizializza la varaibile del risultato
            string analisi = "";

            //si controlla la accettbilità delle variabili
            if (km > 0 && km < 100)
            {
                if (peso > 0 && peso < 400)
                {
                    //si fanno due calcoli diversi a seconda che sia stata scelta la corsa o la camminata
                    if (camminata)
                        analisi = (0.5 * km * peso).ToString();
                    if (corsa)
                        analisi = (0.9 * km * peso).ToString();
                }
                else
                    analisi = "inserire un peso accettabile";
            }
            else
                analisi = "inserire una distanza accettabile";

            return analisi;
        }

        public static string Media(int[] battiti)
        {
            //si inizializza la varaibile del risultato
            string media ;
            //si inizializza la varaibile del risultato numerico
            int calcolo = 0;
            //si inizializza un contatore
            int ctr = 0;
            //si inizializza una flag di avvertimento
            bool flag=false;

            foreach(int battito in battiti)
            {
                if (battito > 0 && battito < 200)
                {
                    calcolo+= battito;
                    ctr++;
                }
                else
                    flag = true;
            }

            if (!flag)
                media = Convert.ToInt32(calcolo / ctr).ToString();
            else
                media = "inserire battiti accettabili";

            return media;
        }
    }
}
