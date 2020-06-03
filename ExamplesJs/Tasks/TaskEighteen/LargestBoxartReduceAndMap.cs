using ExamplesJs.Extentions;
using ExamplesJs.Tasks.TaskEighteen.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesJs.Tasks.TaskEighteen
{
    public class LargestBoxartReduceAndMap
    {
        public static long LargestBoxart(List<Boxart> list)
        {
            var result = list.Map((x) => x.Height * x.Width);

            var maxResult = result.Reduce((x, y) => 
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

            return maxResult;
        }
    }
}
