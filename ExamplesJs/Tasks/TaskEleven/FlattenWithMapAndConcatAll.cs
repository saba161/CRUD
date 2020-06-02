using ExamplesJs.Extentions;
using ExamplesJs.Tasks.TaskEleven.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamplesJs.Tasks.TaskEleven
{
    public class FlattenWithMapAndConcatAll
    {
        public static IEnumerable<int> Flatten(IEnumerable<VideoForTaskEleven> list)
        {
            var result = list.
                Map(x => x.Videos.
                    Map(x => x.Id))
                .ConcatAll();

            var result2 = list.Map(x => x.Videos).ConcatMap();

            return result;
        }
    }
}
