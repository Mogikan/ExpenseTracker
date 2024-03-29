﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Model
{
    [Table("Category")]
    [DataContract]
    public class Category
    {
        [Key]
        [Column("id_category")]
        [DataMember]
        public int IdCategory { get; set; }
        [Column("id_type")]
        [DataMember]
        public int FKType { get; set; }
        [Column("name")]
        [DataMember]
        public string Name { get; set; }
        [ForeignKey("FKType")]
        [DataMember]
        public virtual CategoryType Type { get; set; }
    }
}
