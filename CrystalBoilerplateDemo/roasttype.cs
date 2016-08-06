namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.roasttype")]
    public partial class roasttype
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public roasttype()
        {
            singleorigincoffees = new HashSet<singleorigincoffee>();
        }

        [Key]
        [StringLength(255)]
        public string roastTypeName { get; set; }

        [StringLength(255)]
        public string beanColorName { get; set; }

        [StringLength(255)]
        public string aromaName { get; set; }

        public double? beanTemp { get; set; }

        [StringLength(255)]
        public string tastesName { get; set; }

        public virtual beantemp beantemp1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<singleorigincoffee> singleorigincoffees { get; set; }
    }
}
