using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesJs.Class.TaskThree.Models
{
    public class NewReleases
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Boxart { get; set; }

        public string Uri { get; set; }

        public long[] Rating { get; set; }

        public Bookmark[] Bookmark{ get; set; }
    }

    public class Bookmark
    {
        public long Id { get; set; }

        public long Time { get; set; }
    }
}
