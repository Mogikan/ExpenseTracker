using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Model
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [Column("id_category")]
        public int IdCategory { get; set; }
        [Column("id_type")]
        public int FKType { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [ForeignKey("FKType")]
        public virtual CategoryType Type { get; set; }
    }
}
