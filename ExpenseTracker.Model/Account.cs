using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Model
{
    [Table("Account")]
    public class Account
    { 
        [Key]
        [Column("id_account")]
        public int IdAccount { get; set; }
        [Required]
        [MaxLength(300)]
        [Column("name")]
        public string Name { get; set; }
    }
}
