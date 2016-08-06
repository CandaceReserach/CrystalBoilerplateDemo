namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.brewedcoffeeisroastedbatch")]
    public partial class brewedcoffeeisroastedbatch
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string brewedCoffeeName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int roastedBatchNr { get; set; }
    }
}
