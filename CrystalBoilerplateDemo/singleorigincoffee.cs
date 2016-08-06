namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.singleorigincoffee")]
    public partial class singleorigincoffee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public singleorigincoffee()
        {
            batches = new HashSet<batch>();
            processtypes = new HashSet<processtype>();
            singleorigincoffeewasharvestedonmonthofyears = new HashSet<singleorigincoffeewasharvestedonmonthofyear>();
            roasttypes = new HashSet<roasttype>();
        }

        [Key]
        [StringLength(255)]
        public string singleOriginCoffeeName { get; set; }

        [StringLength(255)]
        public string specialtyCoffeeName { get; set; }

        [StringLength(255)]
        public string estateGrownMillName { get; set; }

        [StringLength(255)]
        public string microFarmGrownFarmName { get; set; }

        [StringLength(255)]
        public string regionName { get; set; }

        public int? specialtyCoffeeGoodScore { get; set; }

        [StringLength(255)]
        public string varietalName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<batch> batches { get; set; }

        public virtual region region { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<processtype> processtypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<singleorigincoffeewasharvestedonmonthofyear> singleorigincoffeewasharvestedonmonthofyears { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<roasttype> roasttypes { get; set; }
    }
}
