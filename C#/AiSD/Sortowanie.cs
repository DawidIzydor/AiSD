using System;
using System.Collections.Generic;
using System.Text;

namespace AiSD
{
    class Sortowanie
    {
        public int[] PrzezProsteWybieranie(int[] KolecjaDoPosortowania)
        {
            int iloscIteracji = 0;

            for(int i = 0; i <  KolecjaDoPosortowania.Length-1; ++i)
            {
                iloscIteracji++;

                int PozycjaNajmniejszego = i;

                for(int j = i + 1; j < KolecjaDoPosortowania.Length; ++j)
                {
                    iloscIteracji++;

                    if(KolecjaDoPosortowania[j] < KolecjaDoPosortowania[PozycjaNajmniejszego])
                    {
                        PozycjaNajmniejszego = j;
                    }
                }

                int temp = KolecjaDoPosortowania[PozycjaNajmniejszego];
                KolecjaDoPosortowania[PozycjaNajmniejszego] = KolecjaDoPosortowania[i];
                KolecjaDoPosortowania[i] = temp;
            }

            Console.WriteLine("Ilosc iteracji: " + iloscIteracji);

            return KolecjaDoPosortowania;
        }

        public int[] PrzezProsteWstawianie(int[] KolekcjaDoPosortowania)
        {
            int iloscIteracji = 0;

            for (int i = 1; i < KolekcjaDoPosortowania.Length; ++i)
            {
                iloscIteracji++;

                int Klucz = KolekcjaDoPosortowania[i];

                int j = i - 1;

                while(j>=0 && KolekcjaDoPosortowania[j] > Klucz)
                {
                    iloscIteracji++;

                    KolekcjaDoPosortowania[j + 1] = KolekcjaDoPosortowania[j];
                    j--;
                }

                KolekcjaDoPosortowania[j + 1] = Klucz;
            }

            Console.WriteLine("Ilosc iteracji: " + iloscIteracji);

            return KolekcjaDoPosortowania;

        }


    }
}
