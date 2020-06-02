using ExamplesJs.Extentions;
using ExamplesJs.Tasks.TaskFive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamplesJs.Tasks.TaskFive
{
    public class TaskFive
    {
        public static IEnumerable<(int, string)> CollectingItem(List<VideoForTaskFive> list)
        {
            var result = list.Map(x => (x.Id, x.Title));

            return result;
        }
    }
}
