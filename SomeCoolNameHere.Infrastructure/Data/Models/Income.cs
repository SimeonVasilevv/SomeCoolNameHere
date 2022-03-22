using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomeCoolNameHere.Infrastructure.Data.Models
{
    public class Income
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public DateTime? Date { get; set; }

        public string? Description { get; set; }

        public string WalletId { get; set; }

        [ForeignKey(nameof(WalletId))]
        public Wallet Wallet { get; set; }
    }
}
