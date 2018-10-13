﻿using System;
using System.Collections.Generic;

namespace AiSD
{
    class Program
    {

        public void Wyswietl<T, Q>(T lista) where T: IEnumerable<Q> 
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

        public void Wyswietl<T>(T lista) where T:IEnumerable<int>
        {
            Wyswietl<List<int>, int>(new List<int>(lista));
        }

        public void Wyswietl<T>(T[] lista)
        {
            Wyswietl<List<T>, T>(new List <T> (lista));
        }

        public void WyszukiwanieTest()
        {
            //TODO przygotowac dane testowe

            Wyszukiwanie wyszukiwanie = new Wyszukiwanie();

            int ZnalezionyIndex;
            int Szukaj;

            Console.WriteLine("\nLista danych");
            Wyswietl(Dane.ListaDanych);

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


        }

        public void SortowanieTest()
        {
            int[] TestowaTablica;

            int[] PosortowanaTablica;
            
            Sortowanie sort = new Sortowanie();


            Console.WriteLine("\nSortowanie przez proste wybieranie");

            Console.WriteLine("Przed sortowaniem");
            TestowaTablica = Dane.ListaDanych.ToArray();
            Wyswietl(TestowaTablica);

            PosortowanaTablica = sort.PrzezProsteWybieranie(TestowaTablica);

            Console.WriteLine("Po posortowaniu");
            Wyswietl(PosortowanaTablica);

            
            Console.WriteLine("\nSortowanie przez proste wstawianie");

            Console.WriteLine("Przed sortowaniem");
            TestowaTablica = Dane.ListaDanych.ToArray();
            Wyswietl(TestowaTablica);

            PosortowanaTablica = sort.PrzezProsteWstawianie(TestowaTablica);

            Console.WriteLine("Po posortowaniu");
            Wyswietl(PosortowanaTablica);
        }

        public void RunAllTests()
        {
            WyszukiwanieTest();
            SortowanieTest();
            
        }

        public Program()
        {
              
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            program.RunAllTests();

            Console.ReadKey();
        }
    }
}