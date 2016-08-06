namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.coffeecup")]
    public partial class coffeecup
    {
        [Key]
        [StringLength(255)]
        public string coffeeCupName { get; set; }

        public float? cupperGradingCupperCorrection { get; set; }

        [StringLength(255)]
        public string brewedCoffeeName { get; set; }

        public float? cupperGradingBody { get; set; }

        public float? cupperGradingBrightness { get; set; }

        public float? cupperGradingCleanCup { get; set; }

        public float? cupperGradingComplexity { get; set; }

        public float? cupperGradingDryFragrance { get; set; }

        public float? cupperGradingFinish { get; set; }

        public float? cupperGradingFlavor { get; set; }

        public float? cupperGradingSweetness { get; set; }

        public float? cupperGradingUniformity { get; set; }

        public float? cupperGradingWetAroma { get; set; }

        public int? cupperId { get; set; }

        public int? coffeeCupNr { get; set; }

        public virtual cupper cupper { get; set; }
    }
}
