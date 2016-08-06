namespace CrystalBoilerplateDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coffeeproduction.roasting")]
    public partial class roasting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public roasting()
        {
            beantemps = new HashSet<beantemp>();
            beantempinstance_showsroastingatroasttime = new HashSet<beantempinstance_showsroastingatroasttime>();
            roastingdisplayedatroasttimecolorofcoffeecolorinsts = new HashSet<roastingdisplayedatroasttimecolorofcoffeecolorinst>();
            roastinghashotairinlettemps = new HashSet<roastinghashotairinlettemp>();
            roastingissetforbeancolors = new HashSet<roastingissetforbeancolor>();
            roastingissetroasterdurationtargettimes = new HashSet<roastingissetroasterdurationtargettime>();
            roastingproducedroastedbatches = new HashSet<roastingproducedroastedbatch>();
        }

        [Key]
        public byte roastingCode { get; set; }

        public int batchNr { get; set; }

        public int roasterNr { get; set; }

        public DateTime startTime { get; set; }

        [StringLength(255)]
        public string employeeName { get; set; }

        public virtual batch batch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<beantemp> beantemps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<beantempinstance_showsroastingatroasttime> beantempinstance_showsroastingatroasttime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<roastingdisplayedatroasttimecolorofcoffeecolorinst> roastingdisplayedatroasttimecolorofcoffeecolorinsts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<roastinghashotairinlettemp> roastinghashotairinlettemps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<roastingissetforbeancolor> roastingissetforbeancolors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<roastingissetroasterdurationtargettime> roastingissetroasterdurationtargettimes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<roastingproducedroastedbatch> roastingproducedroastedbatches { get; set; }
    }
}
