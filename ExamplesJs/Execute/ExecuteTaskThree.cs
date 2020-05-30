using ExamplesJs.Class.TaskThree.Models;
using ExamplesJs.Tasks.TaskThree.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static ExamplesJs.Class.Task;

namespace ExamplesJs.Execute
{
    public class ExecuteTaskThree
    {
        public static List<VideoAndTitlePairs> Execute(List<NewReleases> list)
        {
            return MapList(list);
        }
    }
}
