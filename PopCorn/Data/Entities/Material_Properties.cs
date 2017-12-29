using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Popcorn.Data.Entities
{
    public class Material_Properties
    {
        [StringLength(20)]
        public string PMatID { get; set; }

        [StringLength(15)]
        public string PFtu_L { get; set; }

        [StringLength(15)]
        public string PFtu_LT { get; set; }

        [StringLength(15)]
        public string PFtu_ST { get; set; }

        [StringLength(15)]
        public string PFty_L { get; set; }

        [StringLength(15)]
        public string PFty_LT { get; set; }

        [StringLength(15)]
        public string PFty_ST { get; set; }

        [StringLength(15)]
        public string PFcy_L { get; set; }

        [StringLength(15)]
        public string PFcy_LT { get; set; }

        [StringLength(15)]
        public string PFcy_ST { get; set; }

        [StringLength(15)]
        public string PFsu { get; set; }

        [StringLength(15)]
        public string PFbru15 { get; set; }

        [StringLength(15)]
        public string PFbru20 { get; set; }

        [StringLength(15)]
        public string PFbry15 { get; set; }

        [StringLength(15)]
        public string PFbry20 { get; set; }

        [StringLength(15)]
        public string PE { get; set; }

        [StringLength(15)]
        public string PEc { get; set; }

        [StringLength(15)]
        public string PG { get; set; }

        [StringLength(15)]
        public string PElong_L { get; set; }

        [StringLength(15)]
        public string PElong_LT { get; set; }

        [StringLength(15)]
        public string PElong_ST { get; set; }

        [StringLength(15)]
        public string PAlpha { get; set; }

        [StringLength(15)]
        public string PMu { get; set; }

        [StringLength(15)]
        public string POmega { get; set; }

        public int Id { get; set; }
    }
}
