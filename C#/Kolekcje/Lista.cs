using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Kolekcje
{
    class Lista<T> : IEnumerable<T>
    {

        ListElement<T> pierwszy;
        ListElement<T> ostatni;
        public int _dlugosc = 0;
        public int Dlugosc
        {
            private set
            {
                _dlugosc = value;

                if(_dlugosc < 0)
                {
                    _dlugosc = 0;
                }
            }
            get { return _dlugosc; }
        }

        public class ListElement<T>
        {
            private ListElement<T> _nastepny = null;
            private ListElement<T> _poprzedni = null;

            public ListElement<T> Nastepny
            {
                get => _nastepny;
                set
                {
                    if (value != _nastepny)
                    {
                        _nastepny = value;

                        if (_nastepny != null)
                        {
                            _nastepny.Poprzedni = this;
                        }
                    }
                }
            }
            public ListElement<T> Poprzedni
            {
                get => _poprzedni;
                set
                {
                    if (value != _poprzedni)
                    {
                        _poprzedni = value;

                        if (_poprzedni != null)
                        {
                            _poprzedni.Nastepny = this;
                        }
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

            public ListElement(T Wartosc, ListElement<T> Poprzedni, ListElement<T> Nastepny)
            {
                this.Wartosc = Wartosc;
                this.Nastepny = Nastepny;
                this.Poprzedni = Poprzedni;
            }
        }

        public Lista()
        {}
        
        public int PushBack(T element)
        {
            return DodajNaKoniec(element);
        }

        public int DodajNaKoniec(T element)
        {
            if(pierwszy == null)
            {
                pierwszy = new ListElement<T>(element, null, null);
                ostatni = pierwszy;
            }
            else
            {
                ostatni.Nastepny = new ListElement<T>(element, ostatni, null);
                ostatni = ostatni.Nastepny;
            }

            return ++Dlugosc;
        }

        public int DodajNaPoczatek(T element)
        {
            if(pierwszy == null)
            {
                pierwszy = new ListElement<T>(element, null, null);
                ostatni = pierwszy;
            }
            else
            {
                pierwszy = new ListElement<T>(element, null, pierwszy);
            }

            return ++Dlugosc;
        }

        public int UsunZPoczatku()
        {
            if(pierwszy == null)
            {
                return -1;
            }

            pierwszy = pierwszy.Nastepny;

            if(pierwszy != null)
            {
                pierwszy.Poprzedni = null;
            }

            return --Dlugosc;
        }

        public int UsunZKonca()
        {
            if (pierwszy == null)
            {
                return -1;
            }

            ostatni = ostatni.Poprzedni;

            if (ostatni != null)
            {
                ostatni.Nastepny = null;
            }

            return --Dlugosc;
        }

        public int UsunZPozycji(int pozycja)
        {
            if(pozycja > Dlugosc)
            {
                return -1;
            }

            if(pozycja == 0)
            {
                return UsunZPoczatku();
            }
            if(pozycja == Dlugosc-1)
            {
                return UsunZKonca();
            }

            var leatpos = GetLE(pozycja);

            leatpos.Poprzedni.Nastepny = leatpos.Nastepny;

            return --Dlugosc;
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
            if (pozycja > Dlugosc || pierwszy == null)
            {
                return null;
            }

            // dzieki temu dodawanie pesymistycznie jest O(n/2)
            // srednio O(n/4)
            if (pozycja > Dlugosc / 2)
            {
                return ostatni.GetLE(-(Dlugosc - pozycja)+1);
            }
            else
            {
                return pierwszy.GetLE(pozycja);
            }
        }

        public int DodajNaPozycje(T element, int pozycja)
        {
            if(pozycja > Dlugosc || pierwszy == null)
            {
                return -1;
            }

            if(pozycja == 0)
            {
                return DodajNaPoczatek(element);
            }

            if(pozycja == Dlugosc-1)
            {
                return DodajNaKoniec(element);
            }

            var gl = GetLE(pozycja-1);

            gl.Nastepny = new ListElement<T>(element, gl, gl.Nastepny);

            return ++Dlugosc;
        }

        #region IEnumerable
        public class ListaEnumerator : IEnumerator<T>
        {
            public ListElement<T> CurrentLE { get; private set; }
            public ListElement<T> First { get; }

            public T Current => CurrentLE.Wartosc;

            object IEnumerator.Current => CurrentLE.Wartosc;

            public ListaEnumerator(ListElement<T> First)
            {
                this.First = First;
            }
            
            bool IEnumerator.MoveNext()
            {
                if (CurrentLE == null)
                {
                    CurrentLE = First;
                }
                else
                {
                    CurrentLE = CurrentLE.Nastepny;
                }

                return CurrentLE != null;
            }

            public void Reset()
            {
                CurrentLE = null;
            }

            public void Dispose()
            {}
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ListaEnumerator(pierwszy);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
        #endregion
    }
}
