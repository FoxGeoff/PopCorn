using System.ComponentModel.DataAnnotations;

namespace Popcorn.Data.Entities
{
    public partial class SS_LinkTable
    {
        [StringLength(40)]
        public string SS_ID { get; set; }

        [StringLength(40)]
        public string Nr_ID { get; set; }

        [StringLength(24)]
        public string Figure { get; set; }

        [StringLength(12)]
        public string Thickness { get; set; }

        [StringLength(40)]
        public string File_ID { get; set; }

        [StringLength(5)]
        public string Reference { get; set; }

        public int KeyCol { get; set; }

        public int Id { get; set; }
    }
}
