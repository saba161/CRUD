using ExamplesJs.Extentions;
using ExamplesJs.Tasks.TaskTwelve.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamplesJs.Execute
{
    public class ExecuteTaskTwelve
    {
        public static IEnumerable<Boxart> Execute()
        {
            List<MovieListsForTaskTwelve> list = new List<MovieListsForTaskTwelve>
            {
                new MovieListsForTaskTwelve
                {
                    Name = "New Releases",
                    Videos = new Video []
                    {
                        new Video
                        {
                            Id = 1,
                            Title = "Bad Boys",
                            Boxarts = new Boxart []
                            {
                                new Boxart
                                {
                                    Height = 200,
                                    Width = 200
                                },
                                new Boxart
                                {
                                    Height = 150,
                                    Width = 200
                                }
                            }

                        },

                        new Video
                        {
                            Id = 2,
                            Title = "Bad Boys2",
                            Boxarts = new Boxart []
                            {
                                new Boxart
                                {
                                    Height = 200,
                                    Width = 200
                                },
                                new Boxart
                                {
                                    Height = 150,
                                    Width = 200
                                }
                            }
                        }
                    }
                },
                new MovieListsForTaskTwelve
                {
                    Name = "New Releases",
                    Videos = new Video []
                    {
                        new Video
                        {
                            Id = 1,
                            Title = "Bad Boys",
                            Boxarts = new Boxart []
                            {
                                new Boxart
                                {
                                    Height = 200,
                                    Width = 200
                                },
                                new Boxart
                                {
                                    Height = 150,
                                    Width = 200
                                }
                            }

                        },

                        new Video
                        {
                            Id = 2,
                            Title = "Bad Boys2",
                            Boxarts = new Boxart []
                            {
                                new Boxart
                                {
                                    Height = 200,
                                    Width = 200
                                },
                                new Boxart
                                {
                                    Height = 150,
                                    Width = 200
                                }
                            }
                        }
                    }
                }
            };

            var result = list.
                Map(x => x.Videos)
                .ConcatAll()
                .Map(x => x.Boxarts)
                .ConcatAll()
                .Filter(x => x.Height == 200 && x.Width == 200);

            return result;

        }
    }
}
