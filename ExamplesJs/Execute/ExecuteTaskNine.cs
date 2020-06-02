using ExamplesJs.Tasks.TaskNine;
using ExamplesJs.Tasks.TaskNine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesJs.Execute
{
    public class ExecuteTaskNine
    {
        public static List<Video> Execute()
        {
            List<VideoForTaskNine> list = new List<VideoForTaskNine>
            {
                new VideoForTaskNine
                {
                    Name = "New Releases",
                    Videos = new List<VideoElement>
                    {
                        new VideoElement
                        {
                            Id = 70111470,
                            Title = "Die Hard"
                        },

                        new VideoElement
                        {
                            Id = 654356453,
                            Title = "Bad Boys"
                        }
                    }
                },
                new VideoForTaskNine
                {
                    Name = "Dramas",
                    Videos = new List<VideoElement>
                    {
                        new VideoElement
                        {
                            Id = 65432445,
                            Title = "The Chamber"
                        },

                        new VideoElement
                        {
                            Id = 675465,
                            Title = "Fracture"
                        }
                    }
                }
            };

            var newList = FlattenTheMovieList.FlattenList(list);

            return newList;
        }
    }
}
