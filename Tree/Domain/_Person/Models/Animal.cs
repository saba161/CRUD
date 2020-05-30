using System.ComponentModel.DataAnnotations;

namespace Tree.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
