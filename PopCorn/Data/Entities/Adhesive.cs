using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Popcorn.Data.Entities
{
    [Table("Adhesive")]
    public partial class Adhesive
    {
        [StringLength(20)]
        public string Reference { get; set; }

        [StringLength(20)]
        public string Adhesive_Name { get; set; }

        [StringLength(25)]
        public string Adhesive_Type { get; set; }

        [StringLength(40)]
        public string Curing_Type { get; set; }

        [StringLength(10)]
        public string Curing_Temp { get; set; }

        [StringLength(10)]
        public string Test_Environment { get; set; }

        [StringLength(10)]
        public string Test_Temp { get; set; }

        [StringLength(10)]
        public string G { get; set; }

        [StringLength(10)]
        public string Tmax { get; set; }

        [StringLength(10)]
        public string Ymax { get; set; }

        [StringLength(10)]
        public string Thickness { get; set; }

        public int KeyCol { get; set; }

        public int Id { get; set; }
    }
}
