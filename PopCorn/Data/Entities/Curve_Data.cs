using System.ComponentModel.DataAnnotations;

namespace Popcorn.Data.Entities
{
    public partial class Curve_Data
    {
        [StringLength(40)]
        public string Descriptor { get; set; }

        public float? X1 { get; set; }

        public float? Y1 { get; set; }

        public int KeyCol { get; set; }

        public int Id { get; set; }
    }
}
