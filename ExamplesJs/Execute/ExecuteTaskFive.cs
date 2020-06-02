using ExamplesJs.Tasks.TaskFive;
using ExamplesJs.Tasks.TaskFive.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesJs.Execute
{
    public class ExecuteTaskFive
    {
        public static IEnumerable<(int, string)> Execute()
        {
            List<VideoForTaskFive> list = new List<VideoForTaskFive>
            {
                new VideoForTaskFive
                {
                    Id = 70111470,
                    Title = "Die Hard",
                    bookmark = new int[] {2, 3, 4 }
                },

                new VideoForTaskFive
                {
                    Id = 654356453,
                    Title = "Bad Boys",
                    bookmark = new int[] {2, 3, 4 }
                },

                new VideoForTaskFive
                {
                    Id = 65432445,
                    Title = "Bad Boys 2",
                    bookmark = new int[] {2, 3, 4 }
                }
            };

            var result = TaskFive.CollectingItem(list);

            return result;
        }
    }
}
