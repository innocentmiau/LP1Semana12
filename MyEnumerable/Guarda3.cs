using System;
using System.Collections;
using System.Collections.Generic;

namespace MyEnumerable
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T item0;
        private T item1;
        private T item2;

        public Guarda3()
        {
            item0 = default(T);
            item1 = default(T);
            item2 = default(T);
        }

        public T GetItem(int i)
        {
            return i switch
            {
                0 => item0,
                1 => item1,
                2 => item2,
                _ => throw new IndexOutOfRangeException("Índice deve ser 0, 1 ou 2.")
            };
        }

        public void SetItem(int i, T item)
        {
            switch (i)
            {
                case 0: item0 = item; break;
                case 1: item1 = item; break;
                case 2: item2 = item; break;
                default: throw new IndexOutOfRangeException("Índice deve ser 0, 1 ou 2.");
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}