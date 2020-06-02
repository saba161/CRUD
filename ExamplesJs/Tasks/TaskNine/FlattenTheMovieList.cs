using ExamplesJs.Tasks.TaskNine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesJs.Tasks.TaskNine
{
    public class FlattenTheMovieList
    {
        public static List<Video> FlattenList(List<VideoForTaskNine> list)
        {
            List<Video> videoList = new List<Video>();

            foreach (var item in list)
            {
                foreach (var i in item.Videos)
                {
                    videoList.Add( 
                        new Video 
                        { 
                            Id = i.Id
                        }
                    );
                }
            }

            return videoList;
        }
    }
}
