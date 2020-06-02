using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamplesJs.Extentions
{
    public static class ImplementReduce
    {
        public static T Reduce<T>(this IEnumerable<T> list, Func<T, T, T> func)
        {
            var result = list.First();

            foreach (var item in list.Skip(1))
            {
                result = func(result, item);
            }

            return result;
        }
    }
}
