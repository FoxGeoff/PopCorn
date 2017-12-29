namespace Popcorn.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Nr")]
    public partial class Nr
    {
        [StringLength(24)]
        public string Figure { get; set; }

        [StringLength(40)]
        public string Nr_ID { get; set; }

        [StringLength(12)]
        public string Thickness { get; set; }

        [StringLength(5)]
        public string HrsExposed { get; set; }

        public int? Temperature { get; set; }

        [StringLength(5)]
        public string NType { get; set; }

        public float? N { get; set; }

        public int KeyCol { get; set; }

        public int Id { get; set; }
    }
}
