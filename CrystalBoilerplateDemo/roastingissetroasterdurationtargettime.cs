namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.roastingissetroasterdurationtargettime")]
    public partial class roastingissetroasterdurationtargettime
    {
        [Key]
        [Column(Order = 0)]
        public TimeSpan roasterDurationTargetTime { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte roastingCode { get; set; }

        public virtual roasting roasting { get; set; }
    }
}
