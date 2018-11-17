using AiSD;
using CSharp.Kolekcje;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Testy
{
    class KolekcjaTest : ITest
    {
        public void RunTest()
        {
            ListaTest();
            KolejkaTest();
            StosTest();
        }

        public void ListaTest()
        {
            Console.WriteLine("Test Listy");

            Lista<int> lista = new Lista<int>();

            int dlugosc = 0;

            Console.WriteLine("\nTest dodawania");

            if (lista.Get(0) == default(int))
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Blad");
            }

            lista.DodajNaKoniec(1); dlugosc++;

            if (lista.Get(0) == 1)
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

            if (lista.Dlugosc == dlugosc)
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

            Console.WriteLine("\nTest usuwania");

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
            if (lista.Get(lista.Dlugosc - 1) == 2)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Blad");
            }

            lista.UsunZPozycji(1);
            if (lista.Get(1) == 20)
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

        public void KolejkaTest()
        {
            Console.WriteLine("\nTest kolejki");

            Kolejka<int> kolejka = new Kolejka<int>();

            kolejka.Zakolejkuj(1);
            if(kolejka.Dlugosc == 1)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("BLAD");
            }

            kolejka.Zakolejkuj(2);

            if(kolejka.Odkolejkuj() == 1)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("BLAD");
            }


            if (kolejka.Odkolejkuj() == 2)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("BLAD");
            }

            var listaDoDodania = new List<int>() { 1, 22, 33 };
            Console.WriteLine("Dodawanie elementow");
            foreach(var el in listaDoDodania)
            {
                kolejka.Zakolejkuj(el);
                Console.WriteLine(el);
            }

            for(int i = 0; i < listaDoDodania.Count; ++i)
            {
                var odk = kolejka.Odkolejkuj();
                Console.WriteLine("Odkolejkowano: " + odk);
                if (listaDoDodania[i] == odk)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("BLAD");
                }
            }
        }

        public void StosTest()
        {
            Console.WriteLine("\nTest Stosu");

            Stos<int> kolejka = new Stos<int>();

            kolejka.Zakolejkuj(1);
            if (kolejka.Dlugosc == 1)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("BLAD");
            }

            kolejka.Zakolejkuj(2);

            if (kolejka.Odkolejkuj() == 2)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("BLAD");
            }


            if (kolejka.Odkolejkuj() == 1)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("BLAD");
            }

            var listaDoDodania = new List<int>() { 1, 22, 33 };
            Console.WriteLine("Dodawanie elementow");
            foreach (var el in listaDoDodania)
            {
                kolejka.Zakolejkuj(el);
                Console.WriteLine(el);
            }

            for (int i = 0; i < listaDoDodania.Count; ++i)
            {
                var odk = kolejka.Odkolejkuj();
                Console.WriteLine("Odkolejkowano: " + odk);
                if (listaDoDodania[listaDoDodania.Count - i - 1] == odk)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("BLAD");
                }
            }
        }
    }
}
