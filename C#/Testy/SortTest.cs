using AiSD;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Testy
{
    class SortTest : ITest
    {
        public void RunTest()
        {
            Console.WriteLine("Sortowanie");

            int[] TestowaTablica;

            int[] PosortowanaTablica;

            Sortowanie sort = new Sortowanie();

            Console.WriteLine("Przygotowane wczesniej dane");

            Console.WriteLine("\nSortowanie przez proste wybieranie");

            Console.WriteLine("Przed sortowaniem");
            TestowaTablica = Dane.ListaDanych.ToArray();
            Program.Wyswietl(TestowaTablica);

            PosortowanaTablica = sort.PrzezProsteWybieranie(TestowaTablica);

            Console.WriteLine("Po posortowaniu");
            Program.Wyswietl(PosortowanaTablica);


            Console.WriteLine("\nSortowanie przez proste wstawianie");

            Console.WriteLine("Przed sortowaniem");
            TestowaTablica = Dane.ListaDanych.ToArray();
            Program.Wyswietl(TestowaTablica);

            PosortowanaTablica = sort.PrzezProsteWstawianie(TestowaTablica);

            Console.WriteLine("Po posortowaniu");
            Program.Wyswietl(PosortowanaTablica);



            Console.WriteLine("\nSortowanie babelkowe");

            Console.WriteLine("Przed sortowaniem");
            TestowaTablica = Dane.ListaDanych.ToArray();
            Program.Wyswietl(TestowaTablica);

            PosortowanaTablica = sort.Babelkowe(TestowaTablica);

            Console.WriteLine("Po posortowaniu");
            Program.Wyswietl(PosortowanaTablica);



            Console.WriteLine("\nSortowanie szybkie");

            Console.WriteLine("Przed sortowaniem");
            TestowaTablica = Dane.ListaDanych.ToArray();
            Program.Wyswietl(TestowaTablica);

            PosortowanaTablica = new Sortowanie.QuickSort().Sortuj(TestowaTablica);

            Console.WriteLine("Po posortowaniu");
            Program.Wyswietl(PosortowanaTablica);



            int iloscElementow = 25;
            Console.WriteLine("Losowe dane (" + iloscElementow + " elementow)");

            Console.WriteLine("\nSortowanie przez proste wybieranie");

            Console.WriteLine("Przed sortowaniem");
            TestowaTablica = Dane.LosowaLista(iloscElementow).ToArray();
            Program.Wyswietl(TestowaTablica);

            PosortowanaTablica = sort.PrzezProsteWybieranie(TestowaTablica);

            Console.WriteLine("Po posortowaniu");
            Program.Wyswietl(PosortowanaTablica);


            Console.WriteLine("\nSortowanie przez proste wstawianie");

            Console.WriteLine("Przed sortowaniem");
            TestowaTablica = Dane.LosowaLista(iloscElementow).ToArray();
            Program.Wyswietl(TestowaTablica);

            PosortowanaTablica = sort.PrzezProsteWstawianie(TestowaTablica);

            Console.WriteLine("Po posortowaniu");
            Program.Wyswietl(PosortowanaTablica);



            Console.WriteLine("\nSortowanie babelkowe");

            Console.WriteLine("Przed sortowaniem");
            TestowaTablica = Dane.LosowaLista(iloscElementow).ToArray();
            Program.Wyswietl(TestowaTablica);

            PosortowanaTablica = sort.Babelkowe(TestowaTablica);

            Console.WriteLine("Po posortowaniu");
            Program.Wyswietl(PosortowanaTablica);



            Console.WriteLine("\nSortowanie szybkie");

            Console.WriteLine("Przed sortowaniem");
            TestowaTablica = Dane.LosowaLista(iloscElementow).ToArray();
            Program.Wyswietl(TestowaTablica);

            PosortowanaTablica = new Sortowanie.QuickSort().Sortuj(TestowaTablica);

            Console.WriteLine("Po posortowaniu");
            Program.Wyswietl(PosortowanaTablica);


            Console.WriteLine("\nSortowanie kubełkowe");

            Console.WriteLine("Przed sortowaniem");
            TestowaTablica = Dane.LosowaLista(iloscElementow).ToArray();
            Program.Wyswietl(TestowaTablica);

            PosortowanaTablica = sort.Kubelkowe(TestowaTablica);

            Console.WriteLine("Po posortowaniu");
            Program.Wyswietl(PosortowanaTablica);
        }
    }
}
