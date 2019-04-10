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
            int battitimax;
            int Frequenzamax;
            Console.WriteLine("inserisci l' età");
            età = Convert.ToInt32(Console.ReadLine());
            Frequenzamax = 220 - età;
        }
        
    }
}
