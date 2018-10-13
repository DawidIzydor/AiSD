using System;
using System.Collections.Generic;
using System.Text;

namespace AiSD
{
    class Dane
    {
        readonly static Random random = new Random();

        public static readonly List<int> ListaDanych = new List<int>() { 0, 1, 6, 7, 12, 2, 3, 6, 7, 8, 8, 8, 9, 10, 44, 1, 55, 65, 12, 512, 2 };

        public static readonly List<int> PosortowanaListaDanych = new List<int>() { 1, 5, 7, 19, 21, 25, 33, 51, 101, 250, 251, 821, 2056, 2222, 4567 };

        public static List<int> LosowaLista(int wielkosc, int? najmniejszy = null, int? najwiekszy = null)
        {
            List<int> ret = new List<int>();
            
            int najmn = najmniejszy ?? 0;
            int najw = najwiekszy ?? wielkosc;

            for(int i = 0; i < wielkosc; ++i)
            {
                ret.Add(random.Next(najmn, najw));
            }

            return ret;
        }
    }
}
