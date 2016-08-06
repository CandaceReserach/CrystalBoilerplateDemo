namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.processtype")]
    public partial class processtype
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string singleOriginCoffeeName { get; set; }

        [Key]
        [Column("processType", Order = 1)]
        [StringLength(255)]
        public string processType1 { get; set; }

        public virtual singleorigincoffee singleorigincoffee { get; set; }
    }
}
