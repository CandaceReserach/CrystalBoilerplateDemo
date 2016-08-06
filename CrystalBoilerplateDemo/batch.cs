namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.batch")]
    public partial class batch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public batch()
        {
            roastings = new HashSet<roasting>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int batchNr { get; set; }

        public int? roastedBatchNr { get; set; }

        public int? greenCoffeeWeight { get; set; }

        [StringLength(255)]
        public string singleOriginCoffeeName { get; set; }

        public virtual singleorigincoffee singleorigincoffee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<roasting> roastings { get; set; }
    }
}
