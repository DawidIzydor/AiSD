using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Kolekcje
{
    class Kopiec<T> where T : IComparable
    {
        private class KopiecElement
        {
            public KopiecElement Lewy { get; set; }
            public KopiecElement Prawy { get; set; }

            public T Element { get; set; }

            public KopiecElement(T Element)
            {
                this.Element = Element;
            }

            public int ItemsInNode { get; private set; } = 0;

            public bool Add(T Element)
            {
                ItemsInNode++;

                if(this.Element == null)
                {
                    this.Element = Element;

                    return true;
                }
                else
                {
                    T comparing = Element;

                    if(this.Element.CompareTo(comparing) > 0)
                    {
                        comparing = this.Element;
                        this.Element = Element;
                    }

                    if(Lewy == null)
                    {
                        Lewy = new KopiecElement(comparing);
                        return true;
                    }

                    if(Lewy.Element.CompareTo(comparing) > 0)
                    {
                        T temp = Lewy.Element;
                        Lewy.Element = comparing;
                        comparing = temp;
                    }

                    if(Prawy == null)
                    {
                        Prawy = new KopiecElement(comparing);
                        return true;
                    }

                    if(Prawy.ItemsInNode < Lewy.ItemsInNode)
                    {
                        return Prawy.Add(comparing);
                    }
                    else
                    {
                        return Lewy.Add(comparing);
                    }
                }
            }
        }

        private KopiecElement Szczyt;

        public int Dlugosc => Szczyt?.ItemsInNode ?? 0;

        private T Min;

        public int Add(T Element)
        {
            if(Szczyt == null)
            {
                Szczyt = new KopiecElement(Element);
                Min = Element;
            }
            else
            {
                Szczyt.Add(Element);

                if(Element.CompareTo(Min) < 0)
                {
                    Min = Element;
                }
            }

            return Dlugosc;
        }

        public T GetMax()
        {
            if(Szczyt == null)
            {
                return default(T);
            }
            else
            {
                return Szczyt.Element;
            }
        }

        public T GetMin()
        {
            return Min;
        }
    }
}
