using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Popcorn.Entities
{
    [Table("Composite")]
    public partial class Composite
    {
        [StringLength(255)]
        public string Reference { get; set; }

        [StringLength(50)]
        public string Composite_Name { get; set; }

        [StringLength(5)]
        public string Curing_Type { get; set; }

        public short? Curing_Temp { get; set; }

        public float? Thickness { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public double? Density { get; set; }

        public float? F11t { get; set; }

        public float? F22t { get; set; }

        public float? F11c { get; set; }

        public float? F22c { get; set; }

        public float? F12 { get; set; }

        public float? F13 { get; set; }

        public float? F23 { get; set; }

        public float? F33t { get; set; }

        public float? F33c { get; set; }

        public float? e11t { get; set; }

        public float? e22t { get; set; }

        public float? e11c { get; set; }

        public float? e22c { get; set; }

        public float? e12 { get; set; }

        public float? E_11t { get; set; }

        public float? E_22t { get; set; }

        public float? E_33t { get; set; }

        public float? E_11c { get; set; }

        public float? E_22c { get; set; }

        public float? E_33c { get; set; }

        public float? G12 { get; set; }

        public float? G13 { get; set; }

        public float? G23 { get; set; }

        public float? v12t { get; set; }

        public float? v21t { get; set; }

        public float? v12c { get; set; }

        public float? v21c { get; set; }

        public float? Alpha1 { get; set; }

        public float? Alpha2 { get; set; }

        public int? CTEtemp { get; set; }

        public int? Tglass { get; set; }

        public float? Fbru { get; set; }

        public float? Fbry { get; set; }

        public float? GIc { get; set; }

        public float? GIIc { get; set; }

        public int KeyCol { get; set; }

        public int Id { get; set; }
    }
}
