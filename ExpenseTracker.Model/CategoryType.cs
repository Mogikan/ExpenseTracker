using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Model
{
    [Table("Type")]
    public class CategoryType
    {
        [Key]
        [Column("id_type")]
        public int IdType { get; set; }
        [Column("name")]
        public string Name { get; set; }
    }
}