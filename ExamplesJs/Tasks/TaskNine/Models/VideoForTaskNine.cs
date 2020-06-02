using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesJs.Tasks.TaskNine.Models
{
    public class VideoForTaskNine
    {
        public string Name { get; set; }

        public List<VideoElement> Videos { get; set; }
    }

    public class VideoElement
    {
        public long Id { get; set; }

        public string Title { get; set; }
    }
}
