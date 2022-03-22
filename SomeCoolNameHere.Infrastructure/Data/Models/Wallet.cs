using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCoolNameHere.Infrastructure.Data.Models
{
    public class Wallet
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Column(TypeName = "money")]
        public decimal Amount { get; set; } = 0;

        public ICollection<Income> Incomes { get; set; } = new List<Income>();

        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
    }
}
