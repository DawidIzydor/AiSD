using CSharp.Kolekcje;
using System;
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

            Console.WriteLine("Wyszukiwanie");

            int ZnalezionyIndex;
            int Szukaj;

            Console.WriteLine("Przygotowane wczesniej dane");

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




            Console.WriteLine("Losowe dane");

            var ListaDanych = Dane.LosowaLista(25);
            Console.WriteLine("\nLista danych");
            Wyswietl(ListaDanych);

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

        public void SortowanieTest()
        {
            Console.WriteLine("Sortowanie");

            int[] TestowaTablica;

            int[] PosortowanaTablica;
            
            Sortowanie sort = new Sortowanie();

            Console.WriteLine("Przygotowane wczesniej dane");

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



            Console.WriteLine("\nSortowanie babelkowe");

            Console.WriteLine("Przed sortowaniem");
            TestowaTablica = Dane.ListaDanych.ToArray();
            Wyswietl(TestowaTablica);

            PosortowanaTablica = sort.Babelkowe(TestowaTablica);

            Console.WriteLine("Po posortowaniu");
            Wyswietl(PosortowanaTablica);



            Console.WriteLine("\nSortowanie szybkie");

            Console.WriteLine("Przed sortowaniem");
            TestowaTablica = Dane.ListaDanych.ToArray();
            Wyswietl(TestowaTablica);

            PosortowanaTablica = new Sortowanie.QuickSort().Sortuj(TestowaTablica);

            Console.WriteLine("Po posortowaniu");
            Wyswietl(PosortowanaTablica);



            int iloscElementow = 25;
            Console.WriteLine("Losowe dane (" + iloscElementow + " elementow)");

            Console.WriteLine("\nSortowanie przez proste wybieranie");

            Console.WriteLine("Przed sortowaniem");
            TestowaTablica = Dane.LosowaLista(iloscElementow).ToArray();
            Wyswietl(TestowaTablica);

            PosortowanaTablica = sort.PrzezProsteWybieranie(TestowaTablica);

            Console.WriteLine("Po posortowaniu");
            Wyswietl(PosortowanaTablica);


            Console.WriteLine("\nSortowanie przez proste wstawianie");

            Console.WriteLine("Przed sortowaniem");
            TestowaTablica = Dane.LosowaLista(iloscElementow).ToArray();
            Wyswietl(TestowaTablica);

            PosortowanaTablica = sort.PrzezProsteWstawianie(TestowaTablica);

            Console.WriteLine("Po posortowaniu");
            Wyswietl(PosortowanaTablica);



            Console.WriteLine("\nSortowanie babelkowe");

            Console.WriteLine("Przed sortowaniem");
            TestowaTablica = Dane.LosowaLista(iloscElementow).ToArray();
            Wyswietl(TestowaTablica);

            PosortowanaTablica = sort.Babelkowe(TestowaTablica);

            Console.WriteLine("Po posortowaniu");
            Wyswietl(PosortowanaTablica);



            Console.WriteLine("\nSortowanie szybkie");

            Console.WriteLine("Przed sortowaniem");
            TestowaTablica = Dane.LosowaLista(iloscElementow).ToArray();
            Wyswietl(TestowaTablica);

            PosortowanaTablica = new Sortowanie.QuickSort().Sortuj(TestowaTablica);

            Console.WriteLine("Po posortowaniu");
            Wyswietl(PosortowanaTablica);


            Console.WriteLine("\nSortowanie kubełkowe");

            Console.WriteLine("Przed sortowaniem");
            TestowaTablica = Dane.LosowaLista(iloscElementow).ToArray();
            Wyswietl(TestowaTablica);

            PosortowanaTablica = sort.Kubelkowe(TestowaTablica);

            Console.WriteLine("Po posortowaniu");
            Wyswietl(PosortowanaTablica);
        }

        public void RunAllTests()
        {
            WyszukiwanieTest();
            SortowanieTest();
            
        }

        public void KolekcjaTest()
        {
            Console.WriteLine("Test Listy");

            Lista<int> lista = new Lista<int>();

            int dlugosc = 0;

            if (lista.Get(0) == default(int))
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Blad");
            }

            lista.DodajNaKoniec(1); dlugosc++;

            if(lista.Get(0) == 1)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Blad");
            }

            lista.DodajNaKoniec(2); dlugosc++;

            if (lista.Get(1) == 2)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Blad");
            }

            lista.DodajNaKoniec(3); dlugosc++;

            if (lista.Get(2) == 3)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Blad");
            }

            lista.DodajNaPozycje(20, 1); dlugosc++;

            if (lista.Get(1) == 20)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Blad");
            }

            lista.DodajNaPozycje(21, 0); dlugosc++;

            if (lista.Get(0) == 21)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Blad");
            }

            lista.DodajNaPoczatek(55); dlugosc++;

            if (lista.Get(0) == 55)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Blad");
            }

            if(lista.Dlugosc == dlugosc)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Blad");
            }

            Console.WriteLine("\nZawartosc listy");
            foreach (var el in lista)
            {
                Console.WriteLine(el);
            }

            lista.UsunZPoczatku();
            if (lista.Get(0) == 21)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Blad");
            }

            lista.UsunZKonca();
            if(lista.Get(lista.Dlugosc-1) == 2)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Blad");
            }

            Console.WriteLine("\nZawartosc listy po kasowaniu");
            foreach (var el in lista)
            {
                Console.WriteLine(el);
            }

        }

        public Program()
        {
              
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            //program.RunAllTests();

            program.KolekcjaTest();

            Console.ReadKey();
        }
    }
}
