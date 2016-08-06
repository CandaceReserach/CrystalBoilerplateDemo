namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.roastingissetforbeancolor")]
    public partial class roastingissetforbeancolor
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string beanColorName { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte roastingCode { get; set; }

        public virtual roasting roasting { get; set; }
    }
}
