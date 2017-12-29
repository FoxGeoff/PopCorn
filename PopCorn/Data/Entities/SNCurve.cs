using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Popcorn.Data.Entities
{ 
    [Table("SNCurve")]
    public class SNCurve
    {
        [StringLength(40)]
        public string SN_ID { get; set; }

        [StringLength(20)]
        public string MatID { get; set; }

        [StringLength(20)]
        public string Material_Kind { get; set; }

        [StringLength(24)]
        public string Figure { get; set; }

        public bool? bL { get; set; }

        public bool? bLT { get; set; }

        public bool? bST { get; set; }

        [StringLength(7)]
        public string Temperature { get; set; }

        [StringLength(5)]
        public string Kt { get; set; }

        [StringLength(5)]
        public string a1 { get; set; }

        [StringLength(5)]
        public string a2 { get; set; }

        [StringLength(5)]
        public string a3 { get; set; }

        [StringLength(5)]
        public string a4 { get; set; }

        [StringLength(5)]
        public string a5 { get; set; }

        [StringLength(255)]
        public string Reference { get; set; }

        [StringLength(255)]
        public string StressLimits { get; set; }

        [StringLength(40)]
        public string File_ID { get; set; }

        public int KeyCol { get; set; }

        public int Id { get; set; }
    }
}
