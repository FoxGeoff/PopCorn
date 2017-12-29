using System.ComponentModel.DataAnnotations;

namespace Popcorn.Entities
{
    public partial class Fastener_Sheet
    {
        [StringLength(10)]
        public string JS_ID1 { get; set; }

        [StringLength(10)]
        public string JS_ID2 { get; set; }

        [StringLength(100)]
        public string Fastener_Specification { get; set; }

        [StringLength(10)]
        public string MatGroup { get; set; }

        [StringLength(10)]
        public string FastenerID { get; set; }

        public int KeyCol { get; set; }

        public int Id { get; set; }
    }
}
