using ExamplesJs.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamplesJs.Tasks.TaskSixsitReduce
{
    public class ReduceLargest
    {
        public static int Max(List<int> list)
        {
            var r = list.Aggregate(new List<int>(), (p, n) =>
            {
                if (n % 2 == 0)
                    p.Add(n);
                return p;
            });

            var max = list.Reduce((x, y) =>
            {
                if (x > y)
                {
                    return x;
                }
                else
                {
                    return y;
                }
            });

            return max;
        }

        public static List<int> FilterWithReduce()
        {
            List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            var filterWithReduce = num.Reduce(new List<int>(), (p, n) =>
            {
                if (n % 2 == 0)
                    p.Add(n);
                return p;
            });

            return filterWithReduce;
        }
    }
}
