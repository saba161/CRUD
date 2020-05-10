using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithJs.Views.Models
{
    public class University
    {
        public int id { get; set; }

        public string UniversityName { get; set; }

        public ICollection<Students> Students { get; set; }
    }
}
