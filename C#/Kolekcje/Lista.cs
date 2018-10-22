using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Kolekcje
{
    class Lista<T>
    {

        ListElement<T> pierwszy;
        ListElement<T> ostatni;
        public int Dlugosc { private set; get; } = 0;

        private class ListElement<T>
        {
            private ListElement<T> _nastepny = null;
            private ListElement<T> _poprzedni = null;

            public ListElement<T> Nastepny
            {
                get => _nastepny;
                set
                {
                    if (_nastepny != value)
                    {
                        if (_nastepny != null)
                        {
                            _nastepny.Poprzedni = value;
                        }

                        _nastepny = value;
                    }
                }
            }
            public ListElement<T> Poprzedni
            {
                get => _poprzedni;
                set
                {
                    if (_poprzedni != value)
                    {
                        if (_poprzedni != null)
                        {
                            _poprzedni.Nastepny = value;
                        }

                        _poprzedni = value;

                    }
                }
            }
            public T Wartosc { get; }

            public T Get(int pozycja)
            {
                var pozLE = GetLE(pozycja);
                if(pozLE == null)
                {
                    return default(T);
                }
                else
                {
                    return pozLE.Wartosc;
                }
            }

            public ListElement<T> GetLE(int pozycja)
            {
                if (pozycja == 0)
                {
                    return this;
                }
                else
                {
                    if (pozycja > 0)
                    {
                        if (Nastepny == null)
                        {
                            return null;
                        }
                        else
                        {
                            return Nastepny.GetLE(pozycja - 1);
                        }
                    }
                    else
                    {
                        if (Poprzedni == null)
                        {
                            return null;
                        }
                        else
                        {
                            return Poprzedni.GetLE(pozycja + 1);
                        }
                    }
                }
            }

            public ListElement(T Wartosc)
            {
                this.Wartosc = Wartosc;
            }

            public ListElement(T Wartosc, ListElement<T> Poprz)
            {
                this.Wartosc = Wartosc;
                this.Poprzedni = Poprz;
            }

            public ListElement(T Wartosc, ListElement<T> Nast, ListElement<T> Poprz)
            {
                this.Wartosc = Wartosc;
                this.Nastepny = Nast;
                this.Poprzedni = Poprz;
            }
        }

        public Lista()
        {

        }
        
        public int PushBack(T element)
        {
            return DodajNaKoniec(element);
        }

        public int DodajNaKoniec(T element)
        {
            if(pierwszy == null)
            {
                pierwszy = new ListElement<T>(element);
                ostatni = pierwszy;
            }
            else
            {
                ostatni.Nastepny = new ListElement<T>(element);
                ostatni = ostatni.Nastepny;
            }

            return ++Dlugosc;
        }

        public T Get(int pozycja)
        {
            var getLE = GetLE(pozycja);
            if(getLE == null)
            {
                return default(T);
            }
            else
            {
                return getLE.Wartosc;
            }
        }

        private ListElement<T> GetLE(int pozycja)
        {
            if (pozycja > Dlugosc)
            {
                return null;
            }

            // dzieki temu dodawanie pesymistycznie jest O(n/2)
            // srednio O(n/4)
            if (pozycja > Dlugosc / 2)
            {
                return ostatni.GetLE(-(Dlugosc - pozycja));
            }
            else
            {
                return pierwszy.GetLE(pozycja);
            }
        }

        public int DodajNaPozycje(T element, int pozycja)
        {
            if(pozycja > Dlugosc)
            {
                return -1;
            }

            GetLE(pozycja).Nastepny = new ListElement<T>(element);

            return ++Dlugosc;
        }
    }
}
