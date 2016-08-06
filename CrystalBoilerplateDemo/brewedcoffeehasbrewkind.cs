namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.brewedcoffeehasbrewkind")]
    public partial class brewedcoffeehasbrewkind
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string brewedCoffeeName { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(63)]
        public string brewKindCode { get; set; }
    }
}
