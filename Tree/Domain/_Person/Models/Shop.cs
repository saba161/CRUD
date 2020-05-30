using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tree.Models
{
    public class Shop
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Product> Products { get; set; }

    }
}
