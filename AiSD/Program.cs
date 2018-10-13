using System;
using System.Collections.Generic;

namespace AiSD
{
    class Program
    {

        public void Wyswietl(List<int> lista)
        {
            string wyswietl = "";
            foreach(var el in lista)
            {
                wyswietl += el.ToString() + ",";
            }
            if(wyswietl.Length > 0)
            {
                wyswietl = wyswietl.Remove(wyswietl.Length - 1);
            }
            Console.WriteLine(wyswietl);
        }

        public Program()
        {
            Wyszukiwanie wyszukiwanie = new Wyszukiwanie();

            int ZnalezionyIndex;
            int Szukaj;

            Console.WriteLine("\nLista danych");
            Wyswietl(Dane.ListaDanych);

            Console.WriteLine("\nLiniowe");

            ZnalezionyIndex = -1;
            Szukaj = 44;
            ZnalezionyIndex = wyszukiwanie.Liniowe(Dane.ListaDanych.ToArray(), Szukaj);
            Console.WriteLine("Szukano " + Szukaj.ToString() + ", " + (ZnalezionyIndex >=0 ? "Znaleziono na pozycji "+ZnalezionyIndex : "Nie znaleziono"));
            ZnalezionyIndex = -1;
            Szukaj = 777;
            ZnalezionyIndex = wyszukiwanie.Liniowe(Dane.ListaDanych.ToArray(), Szukaj);
            Console.WriteLine("Szukano " + Szukaj.ToString() + ", " + (ZnalezionyIndex >= 0 ? "Znaleziono na pozycji " + ZnalezionyIndex : "Nie znaleziono"));


            Console.WriteLine("\nLista danych");
            Wyswietl(Dane.PosortowanaListaDanych);

            Console.WriteLine("\nLiniowe");

            ZnalezionyIndex = -1;
            Szukaj = 251;
            ZnalezionyIndex = wyszukiwanie.Liniowe(Dane.PosortowanaListaDanych.ToArray(), Szukaj);
            Console.WriteLine("Szukano " + Szukaj.ToString() + ", " + (ZnalezionyIndex >= 0 ? "Znaleziono na pozycji " + ZnalezionyIndex : "Nie znaleziono"));
            ZnalezionyIndex = -1;
            Szukaj = 777;
            ZnalezionyIndex = wyszukiwanie.Liniowe(Dane.PosortowanaListaDanych.ToArray(), Szukaj);
            Console.WriteLine("Szukano " + Szukaj.ToString() + ", " + (ZnalezionyIndex >= 0 ? "Znaleziono na pozycji " + ZnalezionyIndex : "Nie znaleziono"));


            Console.WriteLine("\nBinarne");

            ZnalezionyIndex = -1;
            Szukaj = 251;
            ZnalezionyIndex = wyszukiwanie.Binarne(Dane.PosortowanaListaDanych.ToArray(), Szukaj);
            Console.WriteLine("Szukano " + Szukaj.ToString() + ", " + (ZnalezionyIndex >= 0 ? "Znaleziono na pozycji " + ZnalezionyIndex : "Nie znaleziono"));
            ZnalezionyIndex = -1;
            Szukaj = 777;
            ZnalezionyIndex = wyszukiwanie.Binarne(Dane.PosortowanaListaDanych.ToArray(), Szukaj);
            Console.WriteLine("Szukano " + Szukaj.ToString() + ", " + (ZnalezionyIndex >= 0 ? "Znaleziono na pozycji " + ZnalezionyIndex : "Nie znaleziono"));

            Console.WriteLine("\nInterpolacyjne");

            ZnalezionyIndex = -1;
            Szukaj = 251;
            ZnalezionyIndex = wyszukiwanie.Interpolacyjne(Dane.PosortowanaListaDanych.ToArray(), Szukaj);
            Console.WriteLine("Szukano " + Szukaj.ToString() + ", " + (ZnalezionyIndex >= 0 ? "Znaleziono na pozycji " + ZnalezionyIndex : "Nie znaleziono"));
            ZnalezionyIndex = -1;
            Szukaj = 777;
            ZnalezionyIndex = wyszukiwanie.Interpolacyjne(Dane.PosortowanaListaDanych.ToArray(), Szukaj);
            Console.WriteLine("Szukano " + Szukaj.ToString() + ", " + (ZnalezionyIndex >= 0 ? "Znaleziono na pozycji " + ZnalezionyIndex : "Nie znaleziono"));


            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program program = new Program();
        }
    }
}
