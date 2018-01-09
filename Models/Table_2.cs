namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_2
    {
        [Key]
        [Column(Order = 0)]
        public int cost { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string carss { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string bikee { get; set; }

        public virtual Table_1 Table_1 { get; set; }
    }
}
