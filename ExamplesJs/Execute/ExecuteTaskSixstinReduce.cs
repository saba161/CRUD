using ExamplesJs.Extentions;
using ExamplesJs.Tasks.TaskSixsitReduce;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesJs.Execute
{
    public class ExecuteTaskSixstinReduce
    {
        public static int Execute()
        {
            List<int> list = new List<int> { 1, 20, 3, 4, 5 };

            return ReduceLargest.Max(list);
        }
    }
}
