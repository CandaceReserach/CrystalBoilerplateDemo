namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.beantempinstance/showsroastingatroasttime")]
    public partial class beantempinstance_showsroastingatroasttime
    {
        [Key]
        [Column(Order = 0)]
        public double beanTempInstance { get; set; }

        [Key]
        [Column(Order = 1)]
        public TimeSpan roastTime { get; set; }

        public byte roastingCode { get; set; }

        public virtual roasting roasting { get; set; }
    }
}
