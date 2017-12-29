using System.ComponentModel.DataAnnotations;

namespace Popcorn.Entities
{
    public partial class Curve_Description
    {
        [StringLength(50)]
        public string Panel_Type { get; set; }

        [StringLength(50)]
        public string Panel_Loading { get; set; }

        [StringLength(30)]
        public string Edge_Configuration { get; set; }

        public bool? Infinite { get; set; }

        [StringLength(40)]
        public string Descriptor { get; set; }

        public int Id { get; set; }
    }
}
