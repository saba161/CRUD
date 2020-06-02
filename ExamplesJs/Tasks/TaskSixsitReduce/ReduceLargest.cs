using ExamplesJs.Extentions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesJs.Tasks.TaskSixsitReduce
{
    public class ReduceLargest
    {
        public static int Max(List<int> list)
        {
            return list.Reduce((x, y) =>
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
        }
    }
}
