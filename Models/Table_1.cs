namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_1()
        {
            Table_2 = new HashSet<Table_2>();
        }

        [Key]
        public int cost { get; set; }

        [Required]
        [StringLength(10)]
        public string cars { get; set; }

        [Required]
        [StringLength(10)]
        public string bike { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_2> Table_2 { get; set; }
    }
}
