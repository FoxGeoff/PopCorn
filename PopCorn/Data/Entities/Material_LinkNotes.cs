using System.ComponentModel.DataAnnotations;

namespace Popcorn.Data.Entities
{
    public partial class Material_LinkNotes
    {
        [StringLength(20)]
        public string IMatID { get; set; }

        [StringLength(10)]
        public string IFtu_L { get; set; }

        [StringLength(10)]
        public string IFtu_LT { get; set; }

        [StringLength(10)]
        public string IFtu_ST { get; set; }

        [StringLength(10)]
        public string IFty_L { get; set; }

        [StringLength(10)]
        public string IFty_LT { get; set; }

        [StringLength(10)]
        public string IFty_ST { get; set; }

        [StringLength(10)]
        public string IFcy_L { get; set; }

        [StringLength(10)]
        public string IFcy_LT { get; set; }

        [StringLength(10)]
        public string IFcy_ST { get; set; }

        [StringLength(10)]
        public string IFsu { get; set; }

        [StringLength(10)]
        public string IFbru15 { get; set; }

        [StringLength(10)]
        public string IFbru20 { get; set; }

        [StringLength(10)]
        public string IFbry15 { get; set; }

        [StringLength(10)]
        public string IFbry20 { get; set; }

        [StringLength(10)]
        public string IE { get; set; }

        [StringLength(10)]
        public string IEc { get; set; }

        [StringLength(10)]
        public string IG { get; set; }

        [StringLength(10)]
        public string IElong_L { get; set; }

        [StringLength(10)]
        public string IElong_LT { get; set; }

        [StringLength(10)]
        public string IElong_ST { get; set; }

        [StringLength(10)]
        public string IAlpha { get; set; }

        [StringLength(10)]
        public string IMu { get; set; }

        [StringLength(10)]
        public string IOmega { get; set; }

        public int Id { get; set; }
    }
}
