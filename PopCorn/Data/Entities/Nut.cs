using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Popcorn.Entities
{
    [Table("Nut")]
    public partial class Nut
    {
        [StringLength(50)]
        public string Reference { get; set; }

        [StringLength(100)]
        public string Bolt_Specification { get; set; }

        [StringLength(50)]
        public string Bolt_Type { get; set; }

        [StringLength(100)]
        public string Bolt_Kind { get; set; }

        [StringLength(15)]
        public string Bolt_Diameter { get; set; }

        [StringLength(100)]
        public string Nut_Specification { get; set; }

        [StringLength(50)]
        public string Nut_Type { get; set; }

        [StringLength(100)]
        public string Nut_Kind { get; set; }

        public int? Ftu { get; set; }

        public int? Ptu { get; set; }

        [StringLength(7)]
        public string Nut_Height { get; set; }

        [StringLength(25)]
        public string LFtu { get; set; }

        [StringLength(20)]
        public string MatID { get; set; }

        public int KeyCol { get; set; }

        public int Id { get; set; }
    }
}
