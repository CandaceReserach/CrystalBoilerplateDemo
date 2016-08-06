namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.farmerownsfarm")]
    public partial class farmerownsfarm
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string farmerName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string farmName { get; set; }
    }
}
