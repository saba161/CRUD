using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Entity_Framework.Models
{
    public class Pets
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        public int Age { get; set; }
    }
}