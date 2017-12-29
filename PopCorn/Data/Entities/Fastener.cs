using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Popcorn.Data.Entities
{
    [Table("Fastener")]
    public partial class Fastener
    {
        [StringLength(50)]
        public string Reference { get; set; }

        [StringLength(25)]
        public string Fastener_Group { get; set; }

        [StringLength(10)]
        public string FastenerID { get; set; }

        [StringLength(100)]
        public string Fastener_Specification { get; set; }

        [StringLength(50)]
        public string VendorID { get; set; }

        [StringLength(20)]
        public string NAS_Designation { get; set; }

        [StringLength(25)]
        public string NAS_Type { get; set; }

        [StringLength(50)]
        public string Fastener_Type { get; set; }

        [StringLength(100)]
        public string Fastener_Kind { get; set; }

        public short? Flush_Angle { get; set; }

        public short? JSOnly { get; set; }

        public int? Ftu { get; set; }

        public int? Fsu { get; set; }

        public int? Fbru { get; set; }

        [StringLength(50)]
        public string LFtu { get; set; }

        [StringLength(50)]
        public string LFsu { get; set; }

        [StringLength(50)]
        public string LFbru { get; set; }

        [StringLength(20)]
        public string MatID { get; set; }

        [StringLength(20)]
        public string FileID { get; set; }

        public int Id { get; set; }
    }
}
