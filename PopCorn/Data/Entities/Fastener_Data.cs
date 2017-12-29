using System.ComponentModel.DataAnnotations;

namespace Popcorn.Entities
{
    public partial class Fastener_Data
    {
        [StringLength(100)]
        public string Fastener_Specification { get; set; }

        [StringLength(15)]
        public string Fastener_Diameter { get; set; }

        public float? Nominal_Diameter { get; set; }

        public float? Root_Diameter { get; set; }

        public float? Hole_Diameter { get; set; }

        public float? Head_Height { get; set; }

        public int? Ptu { get; set; }

        public int? Psu { get; set; }

        [StringLength(10)]
        public string FastenerID { get; set; }

        public int KeyCol { get; set; }

        public int Id { get; set; }
    }
}
