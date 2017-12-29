using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Popcorn.Data.Entities
{
    [Table("Material")]
    public partial class Material
    {
        [StringLength(20)]
        public string MatPage { get; set; }

        [StringLength(20)]
        public string MatID { get; set; }

        [StringLength(20)]
        public string Material_Kind { get; set; }

        [StringLength(20)]
        public string Material_Type { get; set; }

        [StringLength(70)]
        public string Specification { get; set; }

        [StringLength(50)]
        public string Condition_Temper { get; set; }

        [StringLength(55)]
        public string Form { get; set; }

        [StringLength(2)]
        public string Basis { get; set; }

        [StringLength(15)]
        public string Thickness { get; set; }

        [StringLength(15)]
        public string TestTemp { get; set; }

        [StringLength(255)]
        public string Reference { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(3000)]
        public string Footnote { get; set; }

        [StringLength(50)]
        public string FtReference { get; set; }

        public int Id { get; set; }
    }
}
