using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Popcorn.Entities
{
    [Table("TRF")]
    public partial class TRF
    {
        [StringLength(25)]
        public string TRF_Page { get; set; }

        [StringLength(30)]
        public string TRF_ID { get; set; }

        [StringLength(15)]
        public string Hours { get; set; }

        public int? Temperature { get; set; }

        [StringLength(15)]
        public string PropertyVal { get; set; }

        public int KeyCol { get; set; }

        public int Id { get; set; }
    }
}
