using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesJs.Tasks.TaskFour
{
    public static class ImplementMap
    {
        public static List<T> Map<T>(this List<T> list, Func<T, T> func)
        {
            List<T> newList = new List<T>();

            foreach (var item in list)
            {
                newList.Add(func(item));
            }

            return newList;
        }
    }
}
