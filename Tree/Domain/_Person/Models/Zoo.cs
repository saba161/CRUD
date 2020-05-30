using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tree.Models
{
    /////

    public class Zoo
    {
        [Key]
        public int Id { get; set; }

        public string Sector { get; set; }

        public List<Animal> Animals { get; set; }
    }
}
