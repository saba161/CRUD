using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesJs.Tasks.TaskTwelve.Models
{
    public partial class MovieListsForTaskTwelve
    {
        public string Name { get; set; }

        public Video[] Videos { get; set; }
    }

    public partial class Video
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public Boxart[] Boxarts { get; set; }

    }

    public partial class Boxart
    {
        public long Width { get; set; }

        public long Height { get; set; }
    }
}
