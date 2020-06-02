using ExamplesJs.Tasks.TaskEleven.Models;
using ExamplesJs.Tasks.TaskTwelve.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExamplesJs.Extentions
{
    public static class ImplementConcatMap
    {
        public static IEnumerable<T> ConcatMap<T>(this IEnumerable<T> list)
        {
            var resultMap = list.Map(x => x);

            return resultMap;
        }

        public static void Chek()
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

            var s = list.Map(x => x.Videos).ConcatAll();

            var r = list.ConcatMap();
        }

        public static IEnumerable<R> ConcatMap2<T, R>(this IEnumerable<IEnumerable<T>> arr, Func<T, R> mapper)
        {
            return arr.Map(m => m.Map(mapper)).ConcatAll();
        }
    }
}
