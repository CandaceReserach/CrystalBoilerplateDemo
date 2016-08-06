namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.roastingproducedroastedbatch")]
    public partial class roastingproducedroastedbatch
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int roastedBatchNr { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte roastingCode { get; set; }

        public virtual roasting roasting { get; set; }
    }
}
