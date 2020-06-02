using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesJs.Tasks.TaskEleven.Models
{

    public class VideoForTaskEleven
    {
        public string Name { get; set; }

        public VideoElement[] Videos { get; set; }
    }

    public class VideoElement
    {
        public int Id { get; set; }

        public string Title { get; set; }
    }
}
