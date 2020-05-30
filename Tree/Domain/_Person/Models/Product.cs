using System.ComponentModel.DataAnnotations;

namespace Tree.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string ProductName { get; set; }
    }
}
