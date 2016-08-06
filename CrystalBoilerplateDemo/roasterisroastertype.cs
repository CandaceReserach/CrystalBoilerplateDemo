namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.roasterisroastertype")]
    public partial class roasterisroastertype
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int roasterNr { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string roastertypeName { get; set; }
    }
}
