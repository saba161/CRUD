using ExamplesJs.Tasks.TaskEleven;
using ExamplesJs.Tasks.TaskEleven.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamplesJs.Execute
{
    public class ExecuteTaskEleven
    {
        public static IEnumerable<int> Execute()
        {
            List<VideoForTaskEleven> list = new List<VideoForTaskEleven>
            {
                new VideoForTaskEleven
                {
                    Name = "New Releases",
                    Videos = new VideoElement []
                    {
                        new VideoElement
                        {
                            Id = 1,
                            Title = "Bad Boys"
                        },

                        new VideoElement
                        {
                            Id = 2,
                            Title = "Bad Boys2"
                        }
                    }
                },
                new VideoForTaskEleven
                {
                    Name = "Dramas",
                    Videos = new VideoElement []
                    {
                        new VideoElement
                        {
                            Id = 3,
                            Title = "Bad Boys3"
                        },

                        new VideoElement
                        {
                            Id = 4,
                            Title = "Bad Boys4"
                        }
                    }
                }
            };

            var result = FlattenWithMapAndConcatAll.Flatten(list);

            return result;
        }
    }
}
