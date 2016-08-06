namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.blendedisusedinbrewedcoffee")]
    public partial class blendedisusedinbrewedcoffee
    {
        [Key]
        [Column(Order = 0, TypeName = "char")]
        [StringLength(63)]
        public string blendedCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string brewedCoffeeName { get; set; }
    }
}
