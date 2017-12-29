using System.ComponentModel.DataAnnotations;

namespace Popcorn.Data.Entities
{
    public partial class Material_PropNotes
    {
        [StringLength(20)]
        public string NMatID { get; set; }

        [StringLength(10)]
        public string NFtu_L { get; set; }

        [StringLength(10)]
        public string NFtu_LT { get; set; }

        [StringLength(10)]
        public string NFtu_ST { get; set; }

        [StringLength(10)]
        public string NFty_L { get; set; }

        [StringLength(10)]
        public string NFty_LT { get; set; }

        [StringLength(10)]
        public string NFty_ST { get; set; }

        [StringLength(10)]
        public string NFcy_L { get; set; }

        [StringLength(10)]
        public string NFcy_LT { get; set; }

        [StringLength(10)]
        public string NFcy_ST { get; set; }

        [StringLength(10)]
        public string NFsu { get; set; }

        [StringLength(10)]
        public string NFbru15 { get; set; }

        [StringLength(10)]
        public string NFbru20 { get; set; }

        [StringLength(10)]
        public string NFbry15 { get; set; }

        [StringLength(10)]
        public string NFbry20 { get; set; }

        [StringLength(10)]
        public string NE { get; set; }

        [StringLength(10)]
        public string NEc { get; set; }

        [StringLength(10)]
        public string NG { get; set; }

        [StringLength(10)]
        public string NElong_L { get; set; }

        [StringLength(10)]
        public string NElong_LT { get; set; }

        [StringLength(10)]
        public string NElong_ST { get; set; }

        [StringLength(10)]
        public string NAlpha { get; set; }

        [StringLength(10)]
        public string NMu { get; set; }

        [StringLength(10)]
        public string NOmega { get; set; }

        public int Id { get; set; }
    }
}
