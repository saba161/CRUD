using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework.Models
{
    public class Owners
    {
        public int id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Pets> Pets { get; set; }

        public int Ownersid { get; set; }
    }
}
