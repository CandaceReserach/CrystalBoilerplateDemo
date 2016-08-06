namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.blendedhasroastprofileofblendedcoffee")]
    public partial class blendedhasroastprofileofblendedcoffee
    {
        [Key]
        [Column(Order = 0, TypeName = "char")]
        [StringLength(63)]
        public string blendedCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string blendedCoffeeName { get; set; }
    }
}
