using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Kolekcje
{
    //FILO
    class Stos<T>
    {
        private class StosElement
        {
            public T Element { get; }
            public StosElement Poprzedni { get;}

            public StosElement(T Element, StosElement Poprzedni)
            {
                this.Element = Element;
                this.Poprzedni = Poprzedni;
            }
        }


        StosElement Gorny = null;
        public int Dlugosc { get; private set; } = 0;

        public int Zakolejkuj(T element)
        {
            Gorny = new StosElement(element, Gorny);

            return ++Dlugosc;
        }

        public T Odkolejkuj()
        {
            if(Dlugosc < 1)
            {
                return default(T);
            }

            T ret = Gorny.Element;

            Gorny = Gorny.Poprzedni;

            --Dlugosc;

            return ret;
        }
    }
}
