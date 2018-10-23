using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Kolekcje
{
    //FIFO
    class Kolejka<T>
    {
        private class KolejkaElement
        {
            public T Element { get; }
            public KolejkaElement Nastepny { get; set; } = null;

            public KolejkaElement(T Element)
            {
                this.Element = Element;
            }
        }
        
        KolejkaElement Pierwszy = null;
        KolejkaElement Ostatni = null;

        public int Dlugosc { get; private set; } = 0;

        public int Zakolejkuj(T element)
        {
            if (Pierwszy == null)
            {
                Pierwszy = new KolejkaElement(element);
                Ostatni = Pierwszy;
            }
            else
            {
                Ostatni.Nastepny = new KolejkaElement(element);
                Ostatni = Ostatni.Nastepny;
            }

            return ++Dlugosc;
        }

        public T Odkolejkuj()
        {
            if (Dlugosc < 1)
            {
                return default(T);
            }

            T ret = Pierwszy.Element;

            Pierwszy = Pierwszy.Nastepny;

            --Dlugosc;

            return ret;
        }
    }
}
