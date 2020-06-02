using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesJs.Extentions
{
    public static class ImplementConcatAll
    {
        public static IEnumerable<T> ConcatAll<T>(this IEnumerable<IEnumerable<T>> list)
        {
            List<T> newList = new List<T>();

            foreach (var item in list)
            {
                foreach (var item2 in item)
                {
                    newList.Add(item2);
                }
            }

            return newList;
        }
    }
}
