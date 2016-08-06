namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.beantemp")]
    public partial class beantemp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public beantemp()
        {
            roasttypes = new HashSet<roasttype>();
        }

        [Key]
        public double CelsiusValue { get; set; }

        public byte? roastingCode { get; set; }

        public virtual roasting roasting { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<roasttype> roasttypes { get; set; }
    }
}
