using System;
using System.Collections.Generic;
using System.Text;

namespace AiSD
{
    class Wyszukiwanie
    {
        #region Liniowe
        // Wyszukiwanie liniowe dla typu int
        public int Liniowe(int[] przeszukiwanaKolekcja, int WyszukiwanyElement)
        {
            int iloscIteracji = 0; 

            for(int i = 0; i < przeszukiwanaKolekcja.Length; ++i)
            {
                iloscIteracji++;

                if(przeszukiwanaKolekcja[i] == WyszukiwanyElement)
                {
                    Console.WriteLine("Ilosc iteracji: " + iloscIteracji);
                    return i;
                }
            }

            Console.WriteLine("Ilosc iteracji: " + iloscIteracji);

            return -1;
        }

        // Zgeneralizowane dla typu implementującego IComparable
        public int Liniowe<T>(T[] przeszukiwanaKolekcja, T WyszukiwanyElement) where T: IComparable
        {

            for (int i = 0; i < przeszukiwanaKolekcja.Length; ++i)
            {

                if (przeszukiwanaKolekcja[i].CompareTo(WyszukiwanyElement) == 0)
                {
                    return i;
                }
            }

            return -1;
        }
        #endregion

        #region Binarne

        // Wyszukiwanie binarne, dla posortowanej kolekcji

        public int Binarne(int[] posortowanaKolekcja, int szukanyElement)
        {
            int iloscIteracji = 0;

            int LewyEl = 0;
            int PrawyEl = posortowanaKolekcja.Length - 1;

            while(LewyEl < PrawyEl)
            {
                iloscIteracji++;

                int SrodkowyEl = (LewyEl + PrawyEl) / 2;

                if(posortowanaKolekcja[SrodkowyEl] < szukanyElement)
                {
                    LewyEl = SrodkowyEl + 1;
                }
                else
                {
                    PrawyEl = SrodkowyEl;
                }
            }

            Console.WriteLine("Ilosc iteracji: " + iloscIteracji);

            if (posortowanaKolekcja[LewyEl] == szukanyElement)
            {
                return LewyEl;
            }
            else
            {
                return -1;
            }
        }


        public int Binarne<T>(T[] posortowanaKolekcja, T szukanyElement) where T: IComparable
        {
            int LewyEl = 0;
            int PrawyEl = posortowanaKolekcja.Length - 1;

            while (LewyEl < PrawyEl)
            {
                int SrodkowyEl = (LewyEl + PrawyEl) / 2;

                if (posortowanaKolekcja[SrodkowyEl].CompareTo(szukanyElement) < 0)
                {
                    LewyEl = SrodkowyEl + 1;
                }
                else
                {
                    PrawyEl = SrodkowyEl;
                }
            }

            if (posortowanaKolekcja[LewyEl].CompareTo(szukanyElement) == 0)
            {
                return LewyEl;
            }
            else
            {
                return -1;
            }
        }


        #endregion

        #region Interpolacyjne

        // Wyszukiwanie binarne, dla posortowanej kolekcji

        public int Interpolacyjne(int[] posortowanaKolekcja, int szukanyElement)
        {
            int iloscIteracji = 0;

            int LewyEl = 0;
            int PrawyEl = posortowanaKolekcja.Length - 1;

            while (LewyEl < PrawyEl)
            {
                iloscIteracji++;

                int SrodkowyEl = (LewyEl + PrawyEl) / 2;

                if (posortowanaKolekcja[SrodkowyEl] < szukanyElement)
                {
                    LewyEl = SrodkowyEl + 1;
                }
                else
                {
                    PrawyEl = SrodkowyEl;
                }
            }

            Console.WriteLine("Ilosc iteracji: " + iloscIteracji);

            if (posortowanaKolekcja[LewyEl] == szukanyElement)
            {
                return LewyEl;
            }
            else
            {
                return -1;
            }
        }

        public int Interpolacyjne<T>(T[] posortowanaKolekcja, T szukanyElement) where T: IComparable
        {
            int LewyEl = 0;
            int PrawyEl = posortowanaKolekcja.Length - 1;

            while (LewyEl < PrawyEl)
            {

                int SrodkowyEl = (LewyEl + PrawyEl) / 2;

                if (posortowanaKolekcja[SrodkowyEl].CompareTo(szukanyElement) < 0)
                {
                    LewyEl = SrodkowyEl + 1;
                }
                else
                {
                    PrawyEl = SrodkowyEl;
                }
            }
            

            if (posortowanaKolekcja[LewyEl].CompareTo(szukanyElement) == 0)
            {
                return LewyEl;
            }
            else
            {
                return -1;
            }
        }
   

        #endregion
    }
}
