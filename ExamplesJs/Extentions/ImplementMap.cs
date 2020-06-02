using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesJs.Extentions
{
    public static class ImplementMap
    {
        public static IEnumerable<E> Map<T, E>(this IEnumerable<T> list, Func<T, E> func)
        {
            List<E> newList = new List<E>();

            foreach (var item in list)
            {
                newList.Add(func(item));
            }

            return newList;
        }
    }
}
