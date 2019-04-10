using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioLibrary
{
    public class DataCardio

    {
        public static void Metodo_1()
        {
            int età;
            int battiti_max;
            double Frequenza_max;
            double frequenza_max_consigliata;
            double frequenza_min_consigliata;
            double frequenza_min;
            Console.WriteLine("inserisci l' età");
            età = Convert.ToInt32(Console.ReadLine());
            Frequenza_max= 220 - età;
            frequenza_max_consigliata =Frequenza_max *  0.9;
           
           

        }
        
    }
}
