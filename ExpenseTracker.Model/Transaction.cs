using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Model
{
    [Table("Transaction")]
    public class Transaction
    {
        [Key]
        [Column("id_transaction")]
        public int IdTransaction { get; set; }
        [Column("id_account")]
        public int FKAccount { get; set; }
        [Column("id_category")]
        public int FkCategory { get; set; }
        [Column("name")]
        public string Name { get; set; }
        public System.DateTime date { get; set; }
        public string notes { get; set; }
        [ForeignKey("FKAccount")]
        public virtual Account Account { get; set; }
        [ForeignKey("FkCategory")]
        public virtual Category Category { get; set; }
    }
}
