using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tree.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public List<Shop> Shops { get; set; }

        public List<Zoo> Zoos { get; set; }
    }
}
