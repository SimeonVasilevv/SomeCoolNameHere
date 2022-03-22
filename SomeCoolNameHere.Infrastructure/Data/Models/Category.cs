using System.ComponentModel.DataAnnotations;

namespace SomeCoolNameHere.Infrastructure.Data.Models
{
    public class Category
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
