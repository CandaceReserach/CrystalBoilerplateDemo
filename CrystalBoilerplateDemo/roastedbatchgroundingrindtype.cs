namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.roastedbatchgroundingrindtype")]
    public partial class roastedbatchgroundingrindtype
    {
        [Key]
        [Column(Order = 0, TypeName = "char")]
        [StringLength(63)]
        public string grindTypeCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int roastedBatchNr { get; set; }
    }
}
