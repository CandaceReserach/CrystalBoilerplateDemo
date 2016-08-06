namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.roastingdisplayedatroasttimecolorofcoffeecolorinst")]
    public partial class roastingdisplayedatroasttimecolorofcoffeecolorinst
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string coffeeColorInstName { get; set; }

        [Key]
        [Column(Order = 1)]
        public TimeSpan roastTime { get; set; }

        public byte roastingCode { get; set; }

        public virtual roasting roasting { get; set; }
    }
}
