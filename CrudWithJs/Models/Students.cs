using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithJs.Views.Models
{
    public class Students
    {
        public int id { get; set; }

        public string FirsName { set; get; }

        public string Lastname { get; set; }

        public int Age { get; set; }

        public University University { get; set; }
    }
}
