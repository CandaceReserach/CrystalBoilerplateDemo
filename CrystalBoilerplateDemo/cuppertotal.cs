namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.cuppertotal")]
    public partial class cuppertotal
    {
        [Key]
        public float grade { get; set; }

        public int? roastedBatchNr { get; set; }

        [StringLength(255)]
        public string badScoreName { get; set; }
    }
}
