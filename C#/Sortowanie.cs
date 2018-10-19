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

            for (int i = 0; i < KolecjaDoPosortowania.Length - 1; ++i)
            {
                iloscIteracji++;

                int PozycjaNajmniejszego = i;

                for (int j = i + 1; j < KolecjaDoPosortowania.Length; ++j)
                {
                    iloscIteracji++;

                    if (KolecjaDoPosortowania[j] < KolecjaDoPosortowania[PozycjaNajmniejszego])
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

                while (j >= 0 && KolekcjaDoPosortowania[j] > Klucz)
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

        public int[] Babelkowe(int[] KolekcjaDoPosortowania)
        {
            int iloscIteracji = 0;

            int n = KolekcjaDoPosortowania.Length;

            do
            {
                iloscIteracji++;

                for (int i = 0; i < n - 1; ++i)
                {
                    iloscIteracji++;

                    if (KolekcjaDoPosortowania[i] > KolekcjaDoPosortowania[i + 1])
                    {
                        int temp = KolekcjaDoPosortowania[i];
                        KolekcjaDoPosortowania[i] = KolekcjaDoPosortowania[i + 1];
                        KolekcjaDoPosortowania[i + 1] = temp;
                    }
                }

                n--;
            } while (n > 1);

            Console.WriteLine("Ilosc iteracji: " + iloscIteracji);

            return KolekcjaDoPosortowania;
        }

        public int[] Kubelkowe(int[] KolekcjaDoPosortowania)
        {
            int iloscIteracji = 0;

            int[] kubelki = new int[KolekcjaDoPosortowania.Length];

            for(int i = 0; i < kubelki.Length; ++i)
            {
                iloscIteracji++;
                kubelki[i] = 0;
            }

            foreach (var el in KolekcjaDoPosortowania)
            {
                iloscIteracji++;
                kubelki[el]++;
            }

            int k = 0;
            int[] ret = new int[KolekcjaDoPosortowania.Length];

            for(int j = 0; j < kubelki.Length; ++j)
            {
                for (int i = 0; i < kubelki[j]; ++i)
                {
                    iloscIteracji++;
                    ret[k++] = j;
                }
            }

            Console.WriteLine("Ilosc iteracji: " + iloscIteracji);

            return ret;
        }

        public class QuickSort
        {
            int iloscIteracji = 0;

            private int ZnajdzSrodek(int Lewy, int Prawy) => Lewy + (Prawy - Lewy) / 2;

            private int Podziel(ref int[] Tablica, int Lewy, int Prawy)
            {
                iloscIteracji++;

                int Srodek = ZnajdzSrodek(Lewy, Prawy) ;
                int WartoscSrodka = Tablica[Srodek];

                Zamien(ref Tablica, Srodek, Prawy);

                int Pozycja = Lewy;

                for (int i = Lewy; i < Prawy ; ++i)
                {
                    iloscIteracji++;

                    if (Tablica[i] < WartoscSrodka)
                    {
                        Zamien(ref Tablica, i, Pozycja);
                        ++Pozycja;
                    }
                }

                Zamien(ref Tablica, Pozycja, Prawy);
                return Pozycja;
            }

            private void Zamien(ref int[] Tablica, int index1, int index2)
            {
                int temp = Tablica[index1];
                Tablica[index1] = Tablica[index2];
                Tablica[index2] = temp;
            }

            private void Sortuj(ref int[] Tablica, int Lewy, int Prawy)
            {
                if (Lewy < Prawy)
                {
                    int Srodek = Podziel(ref Tablica, Lewy, Prawy);
                    Sortuj(ref Tablica, Lewy, Srodek - 1);
                    Sortuj(ref Tablica, Srodek + 1, Prawy);
                }
            }

            public int[] Sortuj(int[] Tablica)
            {
                iloscIteracji = 0;

                Sortuj(ref Tablica, 0, Tablica.Length - 1);

                Console.WriteLine("Ilosc iteracji: " + iloscIteracji);

                return Tablica;
            }

            public QuickSort()
            { }
        }
    }
}
