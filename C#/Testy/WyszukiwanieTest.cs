using AiSD;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Testy
{
    class WyszukiwanieTest : ITest
    {
        public void RunTest()
        {
            //TODO przygotowac dane testowe

            Wyszukiwanie wyszukiwanie = new Wyszukiwanie();

            Console.WriteLine("Wyszukiwanie");

            int ZnalezionyIndex;
            int Szukaj;

            Console.WriteLine("Przygotowane wczesniej dane");

            Console.WriteLine("\nLista danych");
            Program.Wyswietl(Dane.ListaDanych);

            Console.WriteLine("\nLiniowe");

            ZnalezionyIndex = -1;
            Szukaj = 44;
            ZnalezionyIndex = wyszukiwanie.Liniowe(Dane.ListaDanych.ToArray(), Szukaj);
            Console.WriteLine("Szukano " + Szukaj.ToString() + ", " + (ZnalezionyIndex >= 0 ? "Znaleziono na pozycji " + ZnalezionyIndex : "Nie znaleziono"));
            ZnalezionyIndex = -1;
            Szukaj = 777;
            ZnalezionyIndex = wyszukiwanie.Liniowe(Dane.ListaDanych.ToArray(), Szukaj);
            Console.WriteLine("Szukano " + Szukaj.ToString() + ", " + (ZnalezionyIndex >= 0 ? "Znaleziono na pozycji " + ZnalezionyIndex : "Nie znaleziono"));


            Console.WriteLine("\nLista danych");
            Program.Wyswietl(Dane.PosortowanaListaDanych);

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




            Console.WriteLine("Losowe dane");

            var ListaDanych = Dane.LosowaLista(25);
            Console.WriteLine("\nLista danych");
            Program.Wyswietl(ListaDanych);

            Console.WriteLine("\nLiniowe");

            ZnalezionyIndex = -1;
            Szukaj = 44;
            ZnalezionyIndex = wyszukiwanie.Liniowe(ListaDanych.ToArray(), Szukaj);
            Console.WriteLine("Szukano " + Szukaj.ToString() + ", " + (ZnalezionyIndex >= 0 ? "Znaleziono na pozycji " + ZnalezionyIndex : "Nie znaleziono"));
            ZnalezionyIndex = -1;
            Szukaj = 777;
            ZnalezionyIndex = wyszukiwanie.Liniowe(ListaDanych.ToArray(), Szukaj);
            Console.WriteLine("Szukano " + Szukaj.ToString() + ", " + (ZnalezionyIndex >= 0 ? "Znaleziono na pozycji " + ZnalezionyIndex : "Nie znaleziono"));


        }
    }
}
