using ExamplesJs.Tasks.TaskSix.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesJs.Tasks.TaskSix
{
    public class TaskFilterJson
    {
        public static List<VideoAndRating> FilterArray(List<VideoRelease> list)
        {
            List<VideoAndRating> videoAndRating = new List<VideoAndRating>();

            var enu = list.GetEnumerator();

            while (enu.MoveNext())
            {
                if (enu.Current.Rating == 5)
                {
                    videoAndRating.Add(new VideoAndRating
                    {
                        Id = enu.Current.Id,
                        Rating = enu.Current.Rating
                    });
                }
            }

            return videoAndRating;
        }
    }
}
