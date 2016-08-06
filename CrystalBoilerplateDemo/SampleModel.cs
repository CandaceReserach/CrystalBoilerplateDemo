namespace CrystalBoilerplateDemo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SampleModel : DbContext
    {
        public SampleModel()
            : base("name=SampleModel")
        {
        }

        public virtual DbSet<batch> batches { get; set; }
        public virtual DbSet<beantemp> beantemps { get; set; }
        public virtual DbSet<beantempinstance_showsroastingatroasttime> beantempinstance_showsroastingatroasttime { get; set; }
        public virtual DbSet<blendedhasroastprofileofblendedcoffee> blendedhasroastprofileofblendedcoffees { get; set; }
        public virtual DbSet<blendedincludes_isinroastedbatchhasmixpercent> blendedincludes_isinroastedbatchhasmixpercent { get; set; }
        public virtual DbSet<blendedisusedinbrewedcoffee> blendedisusedinbrewedcoffees { get; set; }
        public virtual DbSet<brewedcoffeehasbrewkind> brewedcoffeehasbrewkinds { get; set; }
        public virtual DbSet<brewedcoffeeisroastedbatch> brewedcoffeeisroastedbatches { get; set; }
        public virtual DbSet<coffeecup> coffeecups { get; set; }
        public virtual DbSet<cupper> cuppers { get; set; }
        public virtual DbSet<cuppertotal> cuppertotals { get; set; }
        public virtual DbSet<farmerownsfarm> farmerownsfarms { get; set; }
        public virtual DbSet<region> regions { get; set; }
        public virtual DbSet<roastedbatchgroundingrindtype> roastedbatchgroundingrindtypes { get; set; }
        public virtual DbSet<roastedbatchhasroastedcoffeeweight> roastedbatchhasroastedcoffeeweights { get; set; }
        public virtual DbSet<roasterisroastertype> roasterisroastertypes { get; set; }
        public virtual DbSet<roasting> roastings { get; set; }
        public virtual DbSet<roastingdisplayedatroasttimecolorofcoffeecolorinst> roastingdisplayedatroasttimecolorofcoffeecolorinsts { get; set; }
        public virtual DbSet<roastinghashotairinlettemp> roastinghashotairinlettemps { get; set; }
        public virtual DbSet<roastingissetforbeancolor> roastingissetforbeancolors { get; set; }
        public virtual DbSet<roastingissetroasterdurationtargettime> roastingissetroasterdurationtargettimes { get; set; }
        public virtual DbSet<roastingproducedroastedbatch> roastingproducedroastedbatches { get; set; }
        public virtual DbSet<roasttype> roasttypes { get; set; }
        public virtual DbSet<singleorigincoffee> singleorigincoffees { get; set; }
        public virtual DbSet<singleorigincoffeewasharvestedonmonthofyear> singleorigincoffeewasharvestedonmonthofyears { get; set; }
        public virtual DbSet<processtype> processtypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<batch>()
                .Property(e => e.singleOriginCoffeeName)
                .IsUnicode(false);

            modelBuilder.Entity<batch>()
                .HasMany(e => e.roastings)
                .WithRequired(e => e.batch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<beantemp>()
                .HasMany(e => e.roasttypes)
                .WithOptional(e => e.beantemp1)
                .HasForeignKey(e => e.beanTemp);

            modelBuilder.Entity<blendedhasroastprofileofblendedcoffee>()
                .Property(e => e.blendedCode)
                .IsUnicode(false);

            modelBuilder.Entity<blendedhasroastprofileofblendedcoffee>()
                .Property(e => e.blendedCoffeeName)
                .IsUnicode(false);

            modelBuilder.Entity<blendedincludes_isinroastedbatchhasmixpercent>()
                .Property(e => e.blendedCode)
                .IsUnicode(false);

            modelBuilder.Entity<blendedisusedinbrewedcoffee>()
                .Property(e => e.blendedCode)
                .IsUnicode(false);

            modelBuilder.Entity<blendedisusedinbrewedcoffee>()
                .Property(e => e.brewedCoffeeName)
                .IsUnicode(false);

            modelBuilder.Entity<brewedcoffeehasbrewkind>()
                .Property(e => e.brewedCoffeeName)
                .IsUnicode(false);

            modelBuilder.Entity<brewedcoffeehasbrewkind>()
                .Property(e => e.brewKindCode)
                .IsUnicode(false);

            modelBuilder.Entity<brewedcoffeeisroastedbatch>()
                .Property(e => e.brewedCoffeeName)
                .IsUnicode(false);

            modelBuilder.Entity<coffeecup>()
                .Property(e => e.coffeeCupName)
                .IsUnicode(false);

            modelBuilder.Entity<coffeecup>()
                .Property(e => e.brewedCoffeeName)
                .IsUnicode(false);

            modelBuilder.Entity<cuppertotal>()
                .Property(e => e.badScoreName)
                .IsUnicode(false);

            modelBuilder.Entity<farmerownsfarm>()
                .Property(e => e.farmerName)
                .IsUnicode(false);

            modelBuilder.Entity<farmerownsfarm>()
                .Property(e => e.farmName)
                .IsUnicode(false);

            modelBuilder.Entity<region>()
                .Property(e => e.regionName)
                .IsUnicode(false);

            modelBuilder.Entity<region>()
                .Property(e => e.countryName)
                .IsUnicode(false);

            modelBuilder.Entity<roastedbatchgroundingrindtype>()
                .Property(e => e.grindTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<roasterisroastertype>()
                .Property(e => e.roastertypeName)
                .IsUnicode(false);

            modelBuilder.Entity<roasting>()
                .Property(e => e.employeeName)
                .IsUnicode(false);

            modelBuilder.Entity<roasting>()
                .HasMany(e => e.beantempinstance_showsroastingatroasttime)
                .WithRequired(e => e.roasting)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<roasting>()
                .HasMany(e => e.roastingdisplayedatroasttimecolorofcoffeecolorinsts)
                .WithRequired(e => e.roasting)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<roasting>()
                .HasMany(e => e.roastinghashotairinlettemps)
                .WithRequired(e => e.roasting)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<roasting>()
                .HasMany(e => e.roastingissetforbeancolors)
                .WithRequired(e => e.roasting)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<roasting>()
                .HasMany(e => e.roastingissetroasterdurationtargettimes)
                .WithRequired(e => e.roasting)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<roasting>()
                .HasMany(e => e.roastingproducedroastedbatches)
                .WithRequired(e => e.roasting)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<roastingdisplayedatroasttimecolorofcoffeecolorinst>()
                .Property(e => e.coffeeColorInstName)
                .IsUnicode(false);

            modelBuilder.Entity<roastingissetforbeancolor>()
                .Property(e => e.beanColorName)
                .IsUnicode(false);

            modelBuilder.Entity<roasttype>()
                .Property(e => e.roastTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<roasttype>()
                .Property(e => e.beanColorName)
                .IsUnicode(false);

            modelBuilder.Entity<roasttype>()
                .Property(e => e.aromaName)
                .IsUnicode(false);

            modelBuilder.Entity<roasttype>()
                .Property(e => e.tastesName)
                .IsUnicode(false);

            modelBuilder.Entity<singleorigincoffee>()
                .Property(e => e.singleOriginCoffeeName)
                .IsUnicode(false);

            modelBuilder.Entity<singleorigincoffee>()
                .Property(e => e.specialtyCoffeeName)
                .IsUnicode(false);

            modelBuilder.Entity<singleorigincoffee>()
                .Property(e => e.estateGrownMillName)
                .IsUnicode(false);

            modelBuilder.Entity<singleorigincoffee>()
                .Property(e => e.microFarmGrownFarmName)
                .IsUnicode(false);

            modelBuilder.Entity<singleorigincoffee>()
                .Property(e => e.regionName)
                .IsUnicode(false);

            modelBuilder.Entity<singleorigincoffee>()
                .Property(e => e.varietalName)
                .IsUnicode(false);

            modelBuilder.Entity<singleorigincoffee>()
                .HasMany(e => e.processtypes)
                .WithRequired(e => e.singleorigincoffee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<singleorigincoffee>()
                .HasMany(e => e.singleorigincoffeewasharvestedonmonthofyears)
                .WithRequired(e => e.singleorigincoffee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<singleorigincoffee>()
                .HasMany(e => e.roasttypes)
                .WithMany(e => e.singleorigincoffees)
                .Map(m => m.ToTable("singleorigincoffeehasprofileatroasttype", "coffeeproduction").MapLeftKey("singleOriginCoffeeName").MapRightKey("roastTypeName"));

            modelBuilder.Entity<singleorigincoffeewasharvestedonmonthofyear>()
                .Property(e => e.singleOriginCoffeeName)
                .IsUnicode(false);

            modelBuilder.Entity<processtype>()
                .Property(e => e.singleOriginCoffeeName)
                .IsUnicode(false);

            modelBuilder.Entity<processtype>()
                .Property(e => e.processType1)
                .IsUnicode(false);
        }
    }
}
