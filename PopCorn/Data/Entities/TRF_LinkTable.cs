namespace Popcorn.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class TRF_LinkTable
    {
        [StringLength(25)]
        public string TRF_Page { get; set; }

        [StringLength(30)]
        public string TRF_ID { get; set; }

        [StringLength(15)]
        public string Hours { get; set; }

        [StringLength(15)]
        public string Property { get; set; }

        [Column(TypeName = "ntext")]
        public string Reference { get; set; }

        public int KeyCol { get; set; }

        public int Id { get; set; }
    }
}
