namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.region")]
    public partial class region
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public region()
        {
            singleorigincoffees = new HashSet<singleorigincoffee>();
        }

        [Key]
        [StringLength(255)]
        public string regionName { get; set; }

        [StringLength(255)]
        public string countryName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<singleorigincoffee> singleorigincoffees { get; set; }
    }
}
