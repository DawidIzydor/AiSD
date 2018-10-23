using CSharp.Kolekcje;
using CSharp.Testy;
using System;
using System.Collections.Generic;

namespace AiSD
{
    class Program
    {
        public static void Wyswietl<T, Q>(T lista) where T: IEnumerable<Q> 
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

        public static void Wyswietl<T>(T lista) where T:IEnumerable<int>
        {
            Wyswietl<List<int>, int>(new List<int>(lista));
        }

        public static void Wyswietl<T>(T[] lista)
        {
            Wyswietl<List<T>, T>(new List <T> (lista));
        }

        public void RunAllTests()
        {
            List<ITest> tests = new List<ITest>()
            {
                new WyszukiwanieTest(),
                new SortTest(),
                new KolekcjaTest()
            };

            foreach(var test in tests)
            {
                test.RunTest();
            }
        }

        static void Main(string[] args)
        {
            // Odkomentuj aby uruchomi© wszystkie testy
            //RunAllTests();

            Program program = new Program();

            KolekcjaTest kolekcjaTest = new KolekcjaTest();
            kolekcjaTest.RunTest();

            Console.ReadKey();
        }
    }
}
