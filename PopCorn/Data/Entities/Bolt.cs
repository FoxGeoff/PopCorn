using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Popcorn.Data.Entities
{
    [Table("Bolt")]
    public partial class Bolt
    {
        [StringLength(50)]
        public string MatPage { get; set; }

        [StringLength(20)]
        public string BoltID { get; set; }

        [StringLength(100)]
        public string Bolt_Specification { get; set; }

        [StringLength(50)]
        public string Bolt_Type { get; set; }

        [StringLength(100)]
        public string Bolt_Kind { get; set; }

        [StringLength(15)]
        public string Bolt_Diameter { get; set; }

        public float? Nominal_Diameter { get; set; }

        public float? Root_Diameter { get; set; }

        public float? Hole_Diameter { get; set; }

        public float? Head_Diameter { get; set; }

        public float? Head_Height { get; set; }

        public int? Psu { get; set; }

        public int? Ptu { get; set; }

        [StringLength(20)]
        public string MatID { get; set; }

        [StringLength(50)]
        public string Reference { get; set; }

        [StringLength(4000)]
        public string Footnote { get; set; }

        [StringLength(50)]
        public string FtReference { get; set; }

        public int Id { get; set; }
    }
}
