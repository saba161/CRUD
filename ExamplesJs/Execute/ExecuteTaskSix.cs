using ExamplesJs.Tasks.TaskSix.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static ExamplesJs.Tasks.TaskSix.TaskFilterJson;

namespace ExamplesJs.Execute
{
    public class ExecuteTaskSix
    {
        public static List<VideoAndRating> Execute()
        {
            var taskSeven = new List<VideoRelease>
            {
                new VideoRelease
                {
                    Id = 1,
                    Rating = 5,
                },

                new VideoRelease
                {
                    Id = 2,
                    Rating = 1,
                },

                new VideoRelease
                {
                    Id = 3,
                    Rating = 5,
                }
            };

            return FilterArray(taskSeven);
        }
    }
}
