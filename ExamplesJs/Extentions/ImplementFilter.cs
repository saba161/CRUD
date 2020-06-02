using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesJs.Extentions
{
    public static class ImplementFilter
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> list, Func<T, bool> predicate)
        {
            List<T> newList = new List<T>();

            foreach (var item in list)
            {
                if (predicate(item))
                {
                    newList.Add(item);
                }
            }

            return newList;
        }
    }
}
