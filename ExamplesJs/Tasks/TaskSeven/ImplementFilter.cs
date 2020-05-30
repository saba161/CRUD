using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesJs.Tasks.TaskSeven
{
    public static class ImplementFilter
    {
        public static List<T> Filter<T>(this List<T> list, Func<T, bool> predicate)
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
