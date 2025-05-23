using System;
using System.Collections.Generic;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        /*
         * Cria uma classe static chamada BeforeUtils, com um único método static chamado
            GetTheOnesBefore() que:
            Receba um enumerável de itens cujo tipo T seja de valor e que implemente IComparable<T>
            Receba um outro item desse tipo T, à parte dos itens que estão no enumerável
            Devolva um enumerável contendo os itens do enumerável original que, para fins de ordenação,
            apareçam antes do item passado à parte

         */
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T reference)
            where T : struct, IComparable<T>
        {
            foreach (var item in items)
            {
                if (item.CompareTo(reference) < 0)
                {
                    yield return item;
                }
            }
        }
    }
}