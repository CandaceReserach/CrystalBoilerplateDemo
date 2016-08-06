namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.singleorigincoffeewasharvestedonmonthofyear")]
    public partial class singleorigincoffeewasharvestedonmonthofyear
    {
        [Key]
        [Column(Order = 0)]
        public TimeSpan monthOfYear { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string singleOriginCoffeeName { get; set; }

        public virtual singleorigincoffee singleorigincoffee { get; set; }
    }
}
