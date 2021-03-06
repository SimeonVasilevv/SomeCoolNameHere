using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCoolNameHere.Infrastructure.Data.Models
{
    public class User
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; }= Guid.NewGuid().ToString();

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [StringLength(64)]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        public string WalletId { get; set; }

        [ForeignKey(nameof(WalletId))]
        public Wallet Wallet { get; set; }

    }
}
